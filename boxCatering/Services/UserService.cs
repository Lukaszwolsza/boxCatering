using boxCatering.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxCatering.Services
{
    public class UserService
    {
        public void addUserToBase(User user)
        {
            string sqlStringConnector = "Server =.; Database = boxCatering; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"INSERT INTO dbo.users VALUES ('{user.userLogin}','{user.userPassword}', '{user.userEmail}', '{user.isAdmin}')", sqlConnection))
                {
                    var result = command.ExecuteNonQuery();
                }
            }
        }

        public bool userAuthenticationInBase(string login, string password)
        {
            bool isLogged = false;
            string sqlStringConnector = "Server =.; Database = boxCatering; Trusted_Connection = True;";
            string query = "SELECT * FROM dbo.users WHERE USER_LOGIN = '" + login + "' AND USER_PASSWORD = '" + password + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlStringConnector);
            DataTable dta = new DataTable();
            sda.Fill(dta);

            if (dta.Rows.Count == 1)
            {
                isLogged = true;
            }
            else
            {
                isLogged = false;
            }

            return isLogged;
        }


    }
}
