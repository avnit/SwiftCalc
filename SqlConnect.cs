using System;
using System.Data.SqlClient;

namespace AcousticalModeling
{
    public class SqlConnect
    {

        string source = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=SSPI;Initial Catalog=master;";

        public SqlDataReader sqlMaterial(string name)
        {
            try {
           /*     string source = @"Provider=SQLNCLI11;Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=SSPI;Initial Catalog=master;providerName =System.Data.OleDb"; */
                   using (SqlConnection s = new SqlConnection(source))
                  { 
            
                    s.Open();
                    string SqlCommand = "select * from [dbo].[materials] where name = '" + name + "'";
                    SqlCommand command = new SqlCommand();
                    command.CommandText = SqlCommand;
                    command.CommandType = System.Data.CommandType.Text;
                    command.Connection = s;
                    SqlDataReader rtd = command.ExecuteReader();


                    return rtd;

                    // ExecuteSqlCommand(s, SqlCommand);


               }
            }
            catch ( Exception ex )
            {
                System.Console.Write(ex.ToString());
                return null;
            }
            }
        public void SqlInsertData (float hz125 , float hz250 , float hz500 , float hz1k , float hz2k , float hz4k )
        {
            using (SqlConnection s = new SqlConnection(source))
            {

                s.Open();
                string SqlCommand = "insert into  ResultStorage values (" + hz125 + "," + hz250 + "," + hz500 + "," + hz1k + "," + hz2k + "," + hz4k + ")" ;
                SqlCommand command = new SqlCommand();
                command.CommandText = SqlCommand;
                SqlDataReader rtd = command.ExecuteReader();


              //  return rtd;

                // ExecuteSqlCommand(s, SqlCommand);


            }

        }
    }
     }
 









