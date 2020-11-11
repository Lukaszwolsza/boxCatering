using boxCatering.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wolsza.Controls;

namespace boxCatering.Services
{
    class paymentService
    {
        public void addCardToBase(Card card)
        {
            string sqlStringConnector = "Server =.; Database = boxCatering; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"INSERT INTO dbo.cards+ VALUES ('{card.cardNumber}','{card.cardExpDate}','{card.cardCCV}')", sqlConnection))
                {
                    var result = command.ExecuteNonQuery();
                } 
            }
        }

    }
}
