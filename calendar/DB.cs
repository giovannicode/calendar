
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class DB
    { 
        //This method takes a query string as an argument excutes it.
        private static List<String> executeQuery(String query)
        {
            List<String> r = new List<String>();
            int count = 0;
            String connString = "Server=localhost; Port=3306; userid=root;password=password;database=daycare";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            MySqlDataReader reader;
            try
            {

                conn.Open();
                command.CommandText = query;
                reader = command.ExecuteReader();
                //count = reader.FieldCount;
                while(reader.Read())
                {
                    //Console.WriteLine(reader["firstname"]);
                    r.Add(reader["firstname"] + "," + reader["lastname"] + "," + reader["age"]);
       
                }             
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

            }
            Console.WriteLine("" + count);
            if (conn != null)
            {
                conn.Close();
            }
            return r;
        }

        public static List<String> loadData()
        {
            List<String> r = executeQuery("SELECT * FROM child");
            return r;
        }

       /* public static void saveChild(Child child)
        {
            String insertChild = childToQuery(child);
            executeQuery(insertChild);
        }

        //This method takes a Distributor object as an argument, and creates a query that inserts all of the object's values into the database.
        //The query is returner as a string so it can be excuted by another method.
        private static String childToQuery(Child child)
        {
            String query;
            query = "INSERT INTO Child VALUES (NULL, " + "'" + child.firstName + "'" + "," + "'" + child.lastName + "'" + ","
                    + "'" + child.middleName + "'" + "," + "'" + child.age + "'" + "," + "'" + child.birthDate.ToString("yyyy-MM-dd") + "'" + "," + "'" + child.sex + "'" + ")";
            Console.WriteLine(query);
            return query;
        }*/
    }
}