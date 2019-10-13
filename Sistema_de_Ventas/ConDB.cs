using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Sistema_de_Ventas
{
    public static class ConDB
    {
        private static string cadena;
        private static SqlConnection conDB = new SqlConnection();
        public static int userId = -1;
        public static int userRole = 0;

        public static bool openConnection()
        {
            try
            {
                cadena = "Data Source=DESKTOP-E68479P\\SQLEXPRESS;Initial Catalog=SalesSystemDB; Integrated Security=True";
                conDB.ConnectionString = cadena;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al consegurir configurarcion o coneccion esta ya iniciada");
            }
            try
            {
                conDB.Open();
                Console.WriteLine("coneccion a base de datos iniciada");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("fallo conneccion a base de datos: " + ex.ToString());
                return false;
            }
        }

        public static void closeConnection()
        {
            try
            {
                conDB.Close();
                Console.WriteLine("coneccion a base de datos terminada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("fallo al cerrar la coneccion: " + ex.ToString());
            }
        }

        public static bool login(string username, string pasword)
        {
            try
            {
                userId = getUserID(username, pasword);
                if (userId == -1)
                    return false;
                userRole = getUserRole();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                log("login", ex.ToString());
                return false;
            }
        }

        public static DataTable getProductsList(string word)
        {
            string query;
            if (word == "")
                query = "select * from dbo.product;";
            else
                query = "select * from dbo.product where name like '%" + word + "%';";
            SqlCommand comando = new SqlCommand(query, conDB);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public static bool CreateProduct(string name, string amount, string price, string stock)
        {
            try
            {
                string query = "select count(1) from dbo.product where name='" + name + "'";
                SqlCommand comando = new SqlCommand(query, conDB);
                int res = (int)comando.ExecuteScalar();
                if (res > 0)
                    return false;
                query = "insert into dbo.product values ('"+ name +"'," + amount + "," + stock + "," + price + ",NULL ,NULL)";
                SqlCommand comando2 = new SqlCommand(query, conDB);
                comando2.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                log("create product", ex.ToString());
                return false;
            }
        }

        public static bool UpdateProduct(string id, string name, string amount, string price, string stock)
        {
            try
            {
                string query = "select count(1) from dbo.product where name='" + name + "' and id!=" + id;
                SqlCommand comando = new SqlCommand(query, conDB);
                int res = (int)comando.ExecuteScalar();
                if (res > 0)
                    return false;
                query = "update dbo.product set name='" + name + "', amount=" + amount + ", sale_price=" + price + ", minimum=" + stock + " where id=" + id + ";";
                SqlCommand comando2 = new SqlCommand(query, conDB);
                comando2.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                log("update product", ex.ToString());
                return false;
            }
            
        }

        public static bool DeleteProduct(string id)
        {
            try
            {
                string query = "DELETE FROM dbo.product WHERE id=" + id;
                SqlCommand comando = new SqlCommand(query, conDB);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                log("delete procuct", ex.ToString());
                return false;
            }
        }

        public static bool RegisterWareHouseEntry(string id_product, string name, string price, string amount)
        {
            try
            {
                string query = "insert into dbo.entries values (" + id_product + ",'" + name + "'," + amount + "," + price + ")";
                SqlCommand comando = new SqlCommand(query, conDB);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                log("Register WareHous Entry", ex.ToString());
                return false;
            }
        }

        public static bool updateCurrentStock (string id_product, string old_stock, string entry_stock)
        {
            try
            {
                float new_amount = float.Parse(old_stock.Replace(".", ",")) + float.Parse(entry_stock.Replace(".", ","));
                string query = "update dbo.product set amount=" + validNumber(new_amount.ToString()) + " where id=" + id_product + ";";
                SqlCommand comando = new SqlCommand(query, conDB);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                log("update current stock", ex.ToString());
                return false;
            }
        }

       public static bool makeBackup(string dir)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("dbo.backupInventoryDB", conDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@folderDir", dir);
                cmd.ExecuteNonQuery();    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                log("make backup", ex.ToString());
                return false;
            }
            
            return true;
        }

        public static int insertSale(int amount, string total)
        {
            try
            {
                string a = amount.ToString();
                string t = total.Replace(",", ".");
                DateTime today = DateTime.Today;
                String query = "insert into dbo.sale output INSERTED.ID values (NULL," + a + "," + t + ",'" + today.ToString() + "')";
                SqlCommand comando = new SqlCommand(query, conDB);
                int res = (int)comando.ExecuteScalar();
                return res;
            }
            catch (Exception ex)
            {
                log("insert sale", ex.ToString());
                return -1;
            }
        }

        public static bool insertDetailSale(int id_sale, string id_product, string product_name, string price, string amount, string total)
        {
            try
            {
                string id_s = id_sale.ToString();
                string p = price.Replace(",", ".");
                string a = amount.Replace(",", ".");
                string t = total.Replace(",", ".");
                String query = "insert into dbo.detail values (" + id_s + "," + id_product + ",'" + product_name + "'," + p + "," + a + "," + t + ")";
                SqlCommand comando = new SqlCommand(query, conDB);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                log("insert detail sale", ex.ToString());
                return false;
            }
        }

        public static bool reduceInventory(string id_product, string amount)
        {
            try
            {
                String query = "select amount from dbo.product where id=" + id_product;
                SqlCommand comando = new SqlCommand(query, conDB);
                float current = float.Parse(comando.ExecuteScalar().ToString());
                float a = float.Parse(amount.Replace(".", ","));
                string new_amount = (current - a).ToString().Replace(",", ".");
                query = "update dbo.product set amount=" + new_amount + " where id=" + id_product;
                SqlCommand comando2 = new SqlCommand(query, conDB);
                comando2.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                log("reduce inventory", ex.ToString());
                return false;
            }
        }

        public static string validString(string word)
        {
            return Regex.Replace(word.Trim().ToLower(), @"[^0-9a-zñ., ]", "", RegexOptions.None);
        }

        public static string validNumber(string word)
        {
            try
            {
                float temp = float.Parse(word.Trim().Replace(".", ","));
                return temp.ToString().Replace(",",".");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                log("valid number", ex.ToString());
                return "error";
            }
        }

        private static int getUserID(string username, string pwd)
        {
            try
            {
                string query = "select id from dbo.users where username='" + username + "' and PWDCOMPARE('" + pwd +"', password)= 1";
                SqlCommand comando = new SqlCommand(query, conDB);
                int res = (int)comando.ExecuteScalar();
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                log("get user id", ex.ToString());
                return -1;
            }
        }

        private static int getUserRole()
        {
            try
            {
                string query = "select role from dbo.users where id=" + userId;
                SqlCommand comando = new SqlCommand(query, conDB);
                int res = (int)comando.ExecuteScalar();
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                log("get user role", ex.ToString());
                return 0;
            }
        }

        public static bool changePassword(string new_pwd)
        {
            try
            { 
                string query = "update dbo.users set password=PWDENCRYPT('" + new_pwd + "') where id=" + userId.ToString();
                SqlCommand comando2 = new SqlCommand(query, conDB);
                comando2.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                log("chenge password", ex.ToString());
                return false;
            }
        }

        private static void log(string type, string error)
        {
            string pathString = @"D:\ErrorLog\log.txt";
            try
            {
                if (!File.Exists(pathString))
                {
                    using (StreamWriter sw = File.CreateText(pathString))
                    {
                        sw.WriteLine("Log de Errores del sistema");
                    }
                }
                using (StreamWriter sw = File.AppendText(pathString))
                {
                    sw.WriteLine(type);
                    sw.WriteLine(error);
                    sw.WriteLine("");
                }
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }
}
