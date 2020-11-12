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
        public int addCustomerToBase(Customer customer)
        {
            int customerID;

            string sqlStringConnector = "Server =.; Database = boxCatering; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"INSERT INTO dbo.customers VALUES ('{customer.Name}','{customer.Surname}','{customer.Email}', '{customer.Address}', '{customer.Postcode}', '{customer.City}', '{customer.Phone}'); SELECT SCOPE_IDENTITY();", sqlConnection))
                {
                    var result = command.ExecuteNonQuery();
                    customerID = Convert.ToInt32(command.ExecuteScalar());
                    return customerID;
                }
                //using (var command = new SqlCommand($"SELCET SCOPE_IDENTITY()", sqlConnection))
                //{
                //    customerID = Convert.ToInt32(command.ExecuteScalar());
                //    return customerID;
                //}
            }
            return customerID;
        }
    }
}
