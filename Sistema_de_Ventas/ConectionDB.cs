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

        public DataTable getProducts(string word)
        {
            word = Regex.Replace(word, @"[^0-9A-Za-z ]", "", RegexOptions.None);
            String query;
            if (word == "")
            {
                query = "select * from dbo.product;";
            } else
            {
                query = "select * from dbo.product where name like '%" + word + "%';";
            }
            SqlCommand comando = new SqlCommand(query, conDB);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            tabla.Columns["name"].ColumnName = "Nombre del Producto";
            tabla.Columns["amount"].ColumnName = "Cantidad";
            tabla.Columns["sale_price"].ColumnName = "Precio de Venta";
            tabla.Columns["minimum"].ColumnName = "Stock Minimo";
            tabla.Columns["bar_code"].ColumnName = "Codigo de Barras";

            return tabla;
        }

        public DataTable getProductsForPurchase(string word)
        {
            word = Regex.Replace(word, @"[^0-9A-Za-z ]", "", RegexOptions.None);
            String query;
            if (word == "")
            {
                query = "select id, name, amount from dbo.product;";
            }
            else
            {
                query = "select id, name, amount from dbo.product where name like '%" + word + "%';";
            }
            SqlCommand comando = new SqlCommand(query, conDB);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            tabla.Columns["name"].ColumnName = "Nombre del Producto";
            tabla.Columns["amount"].ColumnName = "Cantidad";

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
            string n = Regex.Replace(name, @"[^0-9A-Za-z. ]", "", RegexOptions.None);
            string a = Regex.Replace(amount, @"[^0-9.]", "", RegexOptions.None);
            string p = Regex.Replace(price, @"[^0-9.]", "", RegexOptions.None);
            string s = Regex.Replace(stock, @"[^0-9.]", "", RegexOptions.None);
            String query = "insert into dbo.product values ('"+ n +"'," + a + "," + p + "," + s + ",NULL ,NULL)";
            SqlCommand comando = new SqlCommand(query, conDB);
            comando.ExecuteNonQuery();
            return true;
        }

        public bool UpdateProduct(string id, string name, string amount, string price, string stock)
        {
            string n = Regex.Replace(name, @"[^0-9A-Za-z. ]", "", RegexOptions.None);
            string a = Regex.Replace(amount, @"[^0-9.]", "", RegexOptions.None);
            string p = Regex.Replace(price, @"[^0-9.]", "", RegexOptions.None);
            string s = Regex.Replace(stock, @"[^0-9.]", "", RegexOptions.None);
            String query = "update dbo.product set name='" + n + "', amount=" + a + ", sale_price=" + p + ", minimum=" + s + " where id=" + id + ";";
            SqlCommand comando = new SqlCommand(query, conDB);
            comando.ExecuteNonQuery();
            return true;
        }

        public bool DeleteProduct(string id)
        {
            String query = "DELETE FROM dbo.product WHERE id=" + id + ";";
            SqlCommand comando = new SqlCommand(query, conDB);
            comando.ExecuteNonQuery();
            return true;
        }

        public bool RegisterWareHouseEntry(string id_product, string name, string price, string amount, string original_amount)
        {
            string n = Regex.Replace(name, @"[^0-9A-Za-z. ]", "", RegexOptions.None);
            string a = Regex.Replace(amount, @"[^0-9.]", "", RegexOptions.None);
            string p = Regex.Replace(price, @"[^0-9.]", "", RegexOptions.None);
            float total = float.Parse(a) * float.Parse(p);
            String query = "insert into dbo.entries values (" + id_product + ",'" + n + "'," + p + "," + a + "," + total.ToString() + ")";
            SqlCommand comando = new SqlCommand(query, conDB);
            comando.ExecuteNonQuery();
            float new_amount = float.Parse(a) + float.Parse(original_amount);
            query = "update dbo.product set amount=" + new_amount.ToString() + " where id=" + id_product + ";";
            SqlCommand comando2 = new SqlCommand(query, conDB);
            comando2.ExecuteNonQuery();
            return true;
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
                Console.WriteLine("error:" + ex.ToString());
                return false;
            }
            
            return true;
        }

        public bool sale()
        {
            return true;
        }
        
    }
}
