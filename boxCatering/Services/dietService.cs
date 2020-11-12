using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using boxCatering.Classes;
using boxCatering.Forms;

namespace boxCatering.Services
{
    class dietService
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

        public int getDietObj(string fieldWithDiet)
        {
            int userID = 0;
            IDiet Diet = null;

            switch (fieldWithDiet)
            {
                case "2000kcal Diet":
                    {
                        Diet = new lowCaloriesDiet();
                        userID = Diet.dietID;
                        return userID;
                    }
                case "2500kcal Diet":
                    {
                        Diet = new midCaloriesDiet();
                        userID = Diet.dietID;
                        return userID;
                    }
                case "3000kcal Diet":
                    {
                        Diet = new highCaloriesDiet();
                        userID = Diet.dietID;
                        return userID;
                    }
                case "Vegan Diet":
                    {
                        Diet = new veganDiet();
                        userID = Diet.dietID;
                        return userID;
                    }
                case "Keto Diet":
                    {
                        Diet = new ketoDiet();
                        userID = Diet.dietID;
                        return userID;
                    }
                case "Vegatarian Diet":
                    {
                        Diet = new vegetarianDiet();
                        userID = Diet.dietID;
                        return userID;
                    }
            }
            return userID;
        }

        //public int getDietID(string fieldWithDiet)
        //{
        //    int userID = 0;
        //    IDiet Diet = null;

        //    switch (fieldWithDiet)
        //    {
        //        case "dietBox1":
        //            {
        //                Diet = new lowCaloriesDiet();
        //                userID = Diet.dietID;
        //                return userID;
        //            }
        //        case "dietBox2":
        //            {
        //                Diet = new midCaloriesDiet();
        //                userID = Diet.dietID;
        //                return userID;
        //            }
        //        case "dietBox3":
        //            {
        //                Diet = new highCaloriesDiet();
        //                userID = Diet.dietID;
        //                return userID;
        //            }
        //        case "dietBox4":
        //            {
        //                Diet = new veganDiet();
        //                userID = Diet.dietID;
        //                return userID;
        //            }
        //        case "dietBox5":
        //            {
        //                Diet = new ketoDiet();
        //                userID = Diet.dietID;
        //                return userID;
        //            }
        //        case "dietBox6":
        //            {
        //                Diet = new vegetarianDiet();
        //                userID = Diet.dietID;
        //                return userID;
        //            }
        //    }
        //    return userID;
        //}

    }
}
