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
        public string[] getDietType(string fieldWithDiet)
        {
            IDiet Diet = null;

            string[] info = new string[2];

            switch (fieldWithDiet)
            {
                case "dietBox1":
                    {
                        Diet = new lowCaloriesDiet();
                        info[0] = Diet.dietType.ToString();
                        info[1] = Diet.dietDescription();
                        return info;
                    }
                case "dietBox2":
                    {
                        Diet = new midCaloriesDiet();
                        info[0] = Diet.dietType.ToString();
                        info[1] = Diet.dietDescription();
                        return info;
                    }
                case "dietBox3":
                    {
                        Diet = new highCaloriesDiet();
                        info[0] = Diet.dietType.ToString();
                        info[1] = Diet.dietDescription();
                        return info;
                    }
                case "dietBox4":
                    {
                        Diet = new veganDiet();
                        info[0] = Diet.dietType.ToString();
                        info[1] = Diet.dietDescription();
                        return info;
                    }
                case "dietBox5":
                    {
                        Diet = new ketoDiet();
                        info[0] = Diet.dietType.ToString();
                        info[1] = Diet.dietDescription();
                        return info;
                    }
                case "dietBox6":
                    {
                        Diet = new vegetarianDiet();
                        info[0] = Diet.dietType.ToString();
                        info[1] = Diet.dietDescription();
                        return info;
                    }   
            }
            return info;
        }
      

    }
}
