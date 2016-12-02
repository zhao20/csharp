/*Phase 4
 * Xingguo Zhao & Justin Holland
 * programming in C# 
 * 2016/11/17
 * Hotel.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Phase5_1
{
    public class Hotel:License
    {
        //Descrpition of Business
        private string hotelDiscrption;

        //Constructor to initilize value by data from CSV file
        public Hotel(DataRow dr):base(dr)
        {
            HotelDiscrption = dr["Classification_Description"].ToString(); 
        }
        //default constructor
        public Hotel()
        {

        }
        public string HotelDiscrption
        {
            get { return hotelDiscrption; }
            set { hotelDiscrption = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\t" + HotelDiscrption + "\n";
        }
    }
}
