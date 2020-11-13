using boxCatering.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wolsza.Controls;

namespace boxCatering.Services
{
    public class orderService
    {
        public int addOrderToBase(int customerid, int dietid, int cardid)
        {
            string sqlStringConnector = "Server =.; Database = boxCatering; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"INSERT INTO dbo.orders VALUES ('{customerid}','{dietid}','{cardid}')", sqlConnection))
                {
                    var result = command.ExecuteNonQuery();
                }
            }
            return customerid;
        }
    }
}
