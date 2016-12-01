/*Phase 4
 * Xingguo Zhao & Justin Holland
 * programming in C# 
 * 2016/11/17
 * Auto.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApplication1
{
    class Auto : License
    {
        //Descrpition of Business
        private string autoDiscrption;

        //Constructor to initilize value by data from CSV file
        public Auto(DataRow dr) : base(dr)
        {
            AutoDiscrption = dr["Classification_Description"].ToString();
        }
        //default constructor
        public Auto()
        {

        }
        public string AutoDiscrption
        {
            get { return autoDiscrption; }
            set { autoDiscrption = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\t" + AutoDiscrption + "\n";
        }
    }
}

