using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxCatering.Classes
{
    public interface IDiet
    {
        int dietID { get; set; }
        string dietType { get; set; }
        int dietCalories { get; set; }
        string dietCost { get; set; }
        string dietDescription();
    }

    class lowCaloriesDiet : IDiet
    {
        public int dietID { get; set; }
        public string dietType { get; set; }
        public int dietCalories { get; set; }
        public string dietCost { get; set; }
        public string dietDescription()
        {
            return "A balanced diet which include 2000kcal";
        }

        public lowCaloriesDiet()
        {
            this.dietID = 1;
            this.dietType = "2000kcal Diet";
            this.dietCalories = 2000;
            this.dietCost = "300$";
            dietDescription();
        }
    }

    class midCaloriesDiet : IDiet
    {
        public int dietID { get; set; }
        public string dietType { get; set; }
        public int dietCalories { get; set; }
        public string dietCost { get; set; }

        public string dietDescription()
        {
            return "A balanced diet which include 2500kcal";
        }
        public midCaloriesDiet()
        {
            this.dietID = 2;
            this.dietType = "2500kcal Diet";
            this.dietCalories = 2500;
            this.dietCost = "350$";
            dietDescription();
        }
    }
    class highCaloriesDiet : IDiet
    {
        public int dietID { get; set; }
        public string dietType { get; set; } 
        public int dietCalories { get; set; }
        public string dietCost { get; set; }

        public string dietDescription()
        {
            return "A balanced diet which include 3000kcal";
        }
        public highCaloriesDiet()
        {
            this.dietID = 3;
            this.dietType = "3000kcal Diet";
            this.dietCalories = 3000;
            this.dietCost = "400$";
            dietDescription();
        }
    }
    class veganDiet : IDiet
    {
        public int dietID { get; set; }
        public string dietType { get; set; }
        public int dietCalories { get; set; }
        public string dietCost { get; set; }

        public string dietDescription()
        {
            return "A diet for vegans, doesn't contain animal products and meat.";
        }
        public veganDiet()
        {
            this.dietID = 4;
            this.dietType = "Vegan Diet";
            this.dietCalories = 2700;
            this.dietCost = "360$";
            dietDescription();
        }
    }
    class ketoDiet : IDiet
    {
        public int dietID { get; set; }
        public string dietType { get; set; }
        public int dietCalories { get; set; }
        public string dietCost { get; set; }

        public string dietDescription()
        {
            return "A keto diet is based on protein, fat and small amount of carbs.";
        }
        public ketoDiet()
        {
            this.dietID = 5;
            this.dietType = "Keto Diet";
            this.dietCalories = 2300;
            this.dietCost = "350$";
            dietDescription();
        }
    }
    class vegetarianDiet : IDiet
    {
        public int dietID { get; set; }
        public string dietType { get; set; }
        public int dietCalories { get; set; }
        public string dietCost { get; set; }
        public string dietDescription()
        {
            return "A diet which doesn't contain meat.";
        }
        public vegetarianDiet()
        {
            this.dietID = 6;
            this.dietType = "Vegatarian Diet";
            this.dietCalories = 2500;
            this.dietCost = "300$";
            dietDescription();
        }
    }
}
