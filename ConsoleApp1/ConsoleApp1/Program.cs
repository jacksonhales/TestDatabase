using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection sqlCon = new SqlConnection("Server=tcp:thugsquad.database.windows.net,1433;Initial Catalog=ThugCoin;Persist Security Info=False;User ID=tsadmin;Password=Thuglife99;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            sqlCon.Open();

            SqlCommand sqlCom = new SqlCommand("SELECT firstName FROM [Table]", sqlCon);

            SqlDataReader reader = sqlCom.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0}", reader.GetString(0));
                }
            }
            else
            {
                reader.Close();
            }



            /*sqlCom.CommandType = CommandType.Text;
            sqlCom.Parameters.Add("firstName", SqlDbType.VarChar);
            sqlCom.Parameters["firstName"].Value = newName;
            sqlCom = new SqlCommand("SELECT firstName FROM dbo.Table WHERE Id=1", sqlCon);
            */

            Console.ReadLine();
        }
    }
}
