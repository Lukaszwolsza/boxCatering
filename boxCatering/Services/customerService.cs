using boxCatering.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxCatering.Services
{
    class customerService
    {
        public void addCustomerToBase(Customer customer)
        {
            string sqlStringConnector = "Server =.; Database = boxCatering; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"INSERT INTO dbo.customers VALUES ('{customer.Name}','{customer.Surname}','{customer.Email}', '{customer.Address}', '{customer.Postcode}', '{customer.City}', '{customer.Phone}')", sqlConnection))
                {
                    var result = command.ExecuteNonQuery();
                }
            }
        }
    }
}
