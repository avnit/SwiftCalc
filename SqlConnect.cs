using System;
using System.Data.SqlClient;

namespace AcousticalModeling
{
    public class SqlConnect
    {

        string source = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=SSPI;Initial Catalog=master;";

        public Dictionary<string,Object> sqlMaterial(string name)
        {
            try {
           /*     string source = @"Provider=SQLNCLI11;Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=SSPI;Initial Catalog=master;providerName =System.Data.OleDb"; */
                   using (SqlConnection s = new SqlConnection(source))
                  {
                      Materials M = new Materials();
                      Dictionary<string, Object> Output = new Dictionary<string, object>();
                       s.Open();
                      string SqlCommand = "select * from [dbo].[materials] where name = '" + name + "'";
                      SqlCommand command = new SqlCommand();
                      command.CommandText = SqlCommand;
                      command.CommandType = System.Data.CommandType.Text;
                      command.Connection = s;
                      SqlDataReader rtd = command.ExecuteReader();
                      if (s.HasRows)
                          {
                              while (s.Read())
                              {
                                  M._htz125 = (double)s["htz125"];
                                  M._htz250 = (double)s["htz250"];
                                  M._htz500 = (double)s["htz500"];
                                  M._htz1k = (double)s["htz1k"];
                                  M._htz2k = (double)s["htz2k"];
                                  M._htz4k = (double)s["htz4k"];
                                  M.name = name;
                                  Output.Add(name, M);
                              }
                          }
                      

                    return Output;

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
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = s;
                SqlDataReader rtd = command.ExecuteReader();


              //  return rtd;

                // ExecuteSqlCommand(s, SqlCommand);


            }

        }
    }
     }
 









