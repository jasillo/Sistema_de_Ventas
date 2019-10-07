using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Sistema_de_Ventas
{
    class ConectionDB
    {
        string cadena = "Data Source=DESKTOP-E68479P\\SQLEXPRESS;Initial Catalog=SalesSystemDB; Integrated Security=True";
        public SqlConnection conDB = new SqlConnection();

        public ConectionDB()
        {
            conDB.ConnectionString = cadena;
        }

        public void openConnection()
        {
            try
            {
                conDB.Open();
                Console.WriteLine("coneccion a base de datos iniciada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("fallo conneccion a base de datos");
            }
        }

        public void closeConnection()
        {
            conDB.Close();
        }

        public DataTable getProductsInventory(string word)
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
            tabla.Columns["name"].ColumnName = "Nombre del Producto";
            tabla.Columns["amount"].ColumnName = "Cantidad";
            tabla.Columns["sale_price"].ColumnName = "Precio de Venta";
            tabla.Columns["minimum"].ColumnName = "Stock Minimo";
            tabla.Columns["bar_code"].ColumnName = "Codigo de Barras";
            tabla.Columns["photo"].ColumnName = "Imagen";

            return tabla;
        }

        public DataTable getProductsForPurchase(string word)
        {
            string query;
            if (word == "")
            {
                query = "select id, name, amount, minimum from dbo.product;";
            }
            else
            {
                query = "select id, name, amount, minimum from dbo.product where name like '%" + word + "%';";
            }
            SqlCommand comando = new SqlCommand(query, conDB);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            tabla.Columns["name"].ColumnName = "Nombre del Producto";
            tabla.Columns["amount"].ColumnName = "Cantidad";
            tabla.Columns["minimum"].ColumnName = "Stock Minimo";

            return tabla;
        }

        public DataTable getProductsForSales(string word)
        {
            word = Regex.Replace(word, @"[^0-9A-Za-z ]", "", RegexOptions.None);
            String query;
            if (word == "")
            {
                query = "select id, name, sale_price from dbo.product;";
            }
            else
            {
                query = "select id, sale_price, name from dbo.product where name like '%" + word + "%';";
            }
            SqlCommand comando = new SqlCommand(query, conDB);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            tabla.Columns["name"].ColumnName = "Nombre del Producto";
            tabla.Columns["sale_price"].ColumnName = "Precio";

            return tabla;
        }

        public bool CreateProduct(string name, string amount, string price, string stock)
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
                return false;
            }
        }

        public bool UpdateProduct(string id, string name, string amount, string price, string stock)
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
                return false;
            }
            
        }

        public bool DeleteProduct(string id)
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
                return false;
            }
        }

        public bool RegisterWareHouseEntry(string id_product, string name, string price, string amount)
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
                return false;
            }
        }

        public bool updateCurrentStock (string id_product, string old_stock, string entry_stock)
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
                return false;
            }
        }

        public bool validateFieldAsNumber(string word)
        {
            string temp0 = word.Trim();
            string temp1 = Regex.Replace(temp0, @"[^0-9.]", "", RegexOptions.None).Trim();
            if (temp1 == "" || temp1 == "." || temp0 != temp1)
            {
                return false;
            }
            return true;
        }

        public bool validateFieldAsString(string word)
        {
            string temp0 = word.Trim();
            string temp1 = Regex.Replace(temp0, @"[^0-9A-Za-z. ]", "", RegexOptions.None).Trim();
            if (temp1 == "" || temp0 != temp1)
            {
                return false;
            }
            return true;
        }

        public string decimalFormat(string word)
        {
            return Regex.Replace(word, @"[^0-9.]", "", RegexOptions.None).Trim();
        }

        public bool makeBackup(string dir)
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
                return false;
            }
            
            return true;
        }

        public int insertSale(int amount, string total)
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
            catch (Exception)
            {
                return -1;
            }
        }

        public bool insertDetailSale(int id_sale, string id_product, string product_name, string price, string amount, string total)
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
                return false;
            }
        }

        public bool reduceInventory(string id_product, string amount)
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
                return false;
            }
        }

        public string validString(string word)
        {
            return Regex.Replace(word.Trim().ToLower(), @"[^0-9a-zñ., ]", "", RegexOptions.None);
        }

        public string validNumber(string word)
        {
            try
            {
                float temp = float.Parse(word.Trim().Replace(".", ","));
                return temp.ToString().Replace(",",".");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "error";
            }
        }
    }
}
