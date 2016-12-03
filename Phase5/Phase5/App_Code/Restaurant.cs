/*Phase 4
 * Xingguo Zhao & Justin Holland
 * programming in C# 
 * 2016/11/17
 * Restaurant.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Phase5
{
    public class Restaurant:License
    {   
        //Descrpition of Business
        private string restaurantDescription;

        //Constructor to initilize value by data from CSV file
        public Restaurant(DataRow dr):base(dr)
        {
            RestaurantDescription = dr["Classification_Description"].ToString();
        }
        //default constructor
        public Restaurant()
        {

        }
        //mutator
        public string RestaurantDescription
        {
            get { return restaurantDescription; }
            set { restaurantDescription = value; }
        }

        //overidding the ToString
        public override string ToString()
        {
            return base.ToString() + "\t"+ RestaurantDescription + "\n" ;

        }
    }
}
