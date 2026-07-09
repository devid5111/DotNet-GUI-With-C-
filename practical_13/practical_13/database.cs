
using Microsoft.Data.SqlClient;
using System.Data;

namespace practical_13
{
    public class database
    {
        string uname;
        string upass;

        SqlConnection cn = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=C:\CLG-WORK\sem-5\DotNet_practical\practical_13\practical_13\mydb.mdf;
              Integrated Security=True");

        public database(string name, string pass)
        {
            uname = name;
            upass = pass;
        }

        public string FetchResult()
        {
            return data();
        }

        private string data()
        {
            SqlDataAdapter d = new SqlDataAdapter(
                "SELECT * FROM login WHERE username = @uname", cn);

            d.SelectCommand.Parameters.AddWithValue("@uname", uname);

            DataSet ds = new DataSet();

            d.Fill(ds);

           
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return "false";
            }

            string password = ds.Tables[0].Rows[0][1].ToString();

            if (password == upass)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
    }
}