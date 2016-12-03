/*Phase 4
 * Xingguo Zhao & Justin Holland
 * programming in C# 
 * 2016/11/17
 * OtherBusiness.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Phase5
{
    public class OtherBusiness:License
    {
        //Descrpition of Business
        private string otherDescription;

        //Constructor to initilize value by data from CSV file
        public OtherBusiness(DataRow dr):base(dr)
        {
            OtherDescription = dr["Classification_Description"].ToString();
        }
        //default constructor
        public OtherBusiness()
        {

        }
        public string OtherDescription
        {
            get { return otherDescription; }
            set { otherDescription = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\t" + OtherDescription + "\n";
        }
    }
}
