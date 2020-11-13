using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxCatering.Services
{
    public class summaryService
    {
        public string[] customerInformation(int customerID)
        {
            string[] customerInfo = new string[7];

            using (var sqlStringConnector = new SqlConnection("Server =.; Database = boxCatering; Trusted_Connection = True;"))
            {
                sqlStringConnector.Open();
                using (var query = new SqlCommand("SELECT * FROM dbo.customers WHERE ID_CUSTOMER = '" + customerID + "'", sqlStringConnector))
                {
                    using (var reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customerInfo[0] = reader["CUSTOMER_NAME"].ToString();
                            customerInfo[1] = reader["CUSTOMER_SURNAME"].ToString();
                            customerInfo[2] = reader["CUSTOMER_EMAIL"].ToString();
                            customerInfo[3] = reader["CUSTOMER_ADDRESS"].ToString();
                            customerInfo[4] = reader["CUSTOMER_POSTCODE"].ToString();
                            customerInfo[5] = reader["CUSTOMER_CITY"].ToString();
                            customerInfo[6] = reader["CUSTOMER_PHONE"].ToString();

                            return customerInfo;
                        }
                    }
                }
            }
            return customerInfo;
        }

        public string[] dietInformation(int customerID)
        {
            string[] dietInfo = new string[3];

            using (var sqlStringConnector = new SqlConnection("Server =.; Database = boxCatering; Trusted_Connection = True;"))
            {
                sqlStringConnector.Open();
                using (var query = new SqlCommand("SELECT diets.DIET_NAME, diets.DIET_DESC, diets.DIET_COST from dbo.orders inner join diets on orders.ID_DIET = diets.ID_DIET where ID_CUSTOMER = '" + customerID + "'", sqlStringConnector))
                {
                    using (var reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dietInfo[0] = reader["DIET_NAME"].ToString();
                            dietInfo[1] = reader["DIET_DESC"].ToString();
                            dietInfo[2] = reader["DIET_COST"].ToString();
                            return dietInfo;
                        }
                    }
                }
            }
            return dietInfo;
        }


    }
}
