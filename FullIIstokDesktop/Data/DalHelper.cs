using System;
using System.Configuration;
using System.Data;
using FullIIstokDesktop.Model;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace FullIIstokDesktop.Data
{
    //Adicionando herança 
    public class DalHelper : IDisposable
    {
        private static SqlConnection sqlConnection;
        private static string sqlConnectionString;

        //Contrutor padrão
        public DalHelper()
        {
        }

        //Métodos de conexão com banco de dados
        private static string DbConnectionString()
        {
            sqlConnectionString = ConfigurationManager.ConnectionStrings["ConnectionSQL"].ConnectionString;
            return sqlConnectionString;
        }

        private static SqlConnection DbConnection()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionSQL"].ConnectionString);
            sqlConnection.Open();
            return sqlConnection;
        }

        public static Product Read(string sku)
        {
            SqlDataAdapter a = null;
            DataTable dt = new DataTable();
            Product product = new Product();

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Product WHERE Sku = '" + sku + "'";
                    a = new SqlDataAdapter(cmd.CommandText, DbConnection());
                    a.Fill(dt);
                    product.Sku = dt.Rows[0]["Sku"].ToString();
                    product.Name = dt.Rows[0]["Name"].ToString();
                    product.Description = dt.Rows[0]["Description"].ToString();
                    product.Quantity = Convert.ToInt32(dt.Rows[0]["Quantity"]);
                    product.Price = Convert.ToDecimal(dt.Rows[0]["Price"]);
                    return product;
                }
            }
            
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //Create
        public static void Create(Product product)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText =
                        "INSERT INTO Product " +
                        "(Sku, Name, Description, Quantity, Price) " +
                        "VALUES " +
                        "(@Sku, @Name, @Description, @Quantity, @Price)";
                    cmd.Parameters.AddWithValue("@Sku", product.Sku);
                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Description", product.Description);
                    cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Update
        public static void Update(Product product)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    if (product != null)
                    {
                        cmd.CommandText =
                            "UPDATE Product " +
                            "SET " +
                            "Sku = @Sku, Name = @Name, Description = @Description, Quantity = @Quantity , Price = @Price " +
                            "WHERE Sku = @Sku";
                        cmd.Parameters.AddWithValue("@Sku", product.Sku);
                        cmd.Parameters.AddWithValue("@Name", product.Name);
                        cmd.Parameters.AddWithValue("@Description", product.Description);
                        cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                        cmd.Parameters.AddWithValue("@Price", product.Price);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Delete
        public static int Delete(string sku)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText =
                        "DELETE FROM " +
                        "Product " +
                        "WHERE Sku = @Sku";
                    cmd.Parameters.AddWithValue("@Sku", sku);
                    int result = cmd.ExecuteNonQuery();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Método de login
        public static int Access(string user, string password)
        {

            //SqlDataAdapter a = null;
            //DataTable dt = new DataTable();
            //User us = new User();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText =
                                "SELECT Login, Password, nmUser " +
                                "FROM [User] " +
                                "WHERE Login = @User " +
                                "AND Password = @Password";
                    cmd.Parameters.AddWithValue("@User", user);
                    cmd.Parameters.AddWithValue("@Password", password);
                    SqlDataReader dados = cmd.ExecuteReader();
                    if (dados.Read())
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
