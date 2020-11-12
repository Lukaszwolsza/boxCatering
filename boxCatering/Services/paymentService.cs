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
        public int addCardToBase(Card card)
        {
            int cardID;
            string sqlStringConnector = "Server =.; Database = boxCatering; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"INSERT INTO dbo.cards VALUES ('{card.cardNumber}','{card.cardExpDate}','{card.cardCCV}'); SELECT SCOPE_IDENTITY();", sqlConnection))
                {
                    var result = command.ExecuteNonQuery();
                    cardID = Convert.ToInt32(command.ExecuteScalar());
                    return cardID;
                }
            }
            return cardID;
        }

    }
}
