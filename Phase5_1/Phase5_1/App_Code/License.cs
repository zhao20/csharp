/*Phase 4
 * Xingguo Zhao & Justin Holland
 * programming in C# 
 * 2016/11/17
 * License.cs
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase5_1
{

    /// <summary>
    /// Summary description for License
    /// </summary>
    public class License
    {

        private string business_Name;
        private string street_Address;
        private string city;
        private string state;
        private string zip;
        private string business_Phone_Number;
        private string license_Status;
        private int fid;
        private string classficationCode;
        private string classficationDis;

        //the following are all properties
        public string Business_Name
        {
            get
            {
                return business_Name;
            }

            set
            {
                business_Name = value;
            }
        }

        public string Street_Address
        {
            get
            {
                return street_Address;
            }

            set
            {
                street_Address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public string Zip
        {
            get
            {
                return zip;
            }

            set
            {
                zip = value;
            }
        }

        public string Business_Phone_Number
        {
            get
            {
                return business_Phone_Number;
            }

            set
            {
                business_Phone_Number = value;
            }
        }

        public string License_Status
        {
            get
            {
                return license_Status;
            }

            set
            {
                license_Status = value;
            }
        }


        public int Fid
        {
            get
            {
                return fid;
            }

            set
            {
                fid = value;
            }
        }

        public string ClassficationCode
        {
            get
            {
                return classficationCode;
            }

            set
            {
                classficationCode = value;
            }
        }

        public string ClassficationDis
        {
            get
            {
                return classficationDis;
            }

            set
            {
                classficationDis = value;
            }
        }

        /****************************************************/

        /**
         * Default Constructor
         */
        public License()
        {
            
        }

        /**
         * This constructor takes all class variables
         * keep for Fulture use
         */
        //public License(string business_Name, string street_Address, string city, string state, string zip, string business_Phone_Number, 
        //    string license_Expir_Date, string issue_Date, string license_Fiscal_Year, string license_Status, int fid)
        //{
        //    this.fid = fid;
        //    this.business_Name = business_Name;
        //    this.street_Address = street_Address;
        //    this.city = city;
        //    this.state = state;
        //    this.zip = zip;
        //    this.business_Phone_Number = business_Phone_Number;
        //    this.license_Status = license_Status;
        //}

        /*
         This constructor is take datarow file 
         * use for parse the data read from csv file
         */
        public License(DataRow dr)
        {       
                this.fid = int.Parse(dr["FID"].ToString());
                this.business_Name = dr["Business_Name"].ToString();
                this.street_Address = dr["Street_Address"].ToString();
                this.city = dr["City"].ToString();
                this.state = dr["State"].ToString();
                this.zip = dr["Zip"].ToString();
                this.business_Phone_Number = dr["Business_Phone_Number"].ToString();
                this.license_Status = dr["License_Status"].ToString();
                this.classficationCode = dr["Classification_Code"].ToString();
            //this.classficationDis = dr["Classification_Description"].ToString();

               
        }

        /*
         *This is a static function to return an array of column title
         */
        public static String[]  ColumnTitle()
        {
            //list to contain all the titles
            List<string> title = new List<string>();
            title.Add("FID");
            title.Add("Business_Name");
            title.Add("Street_Address");
            title.Add("City");
            title.Add("State");
            title.Add("Zip");
            title.Add("Business_Phone_Number");
            title.Add("License_Status");
            title.Add("Classification_Code");
            title.Add("Classification_Description");
            
            //convert list to array
            return title.ToArray();
        }

        /*
         *override the tostring function from system
         */
        override public string ToString()
        {
            string str = String.Empty;
            str = String.Format("{0,5}  {1, 5}  {2, 25}  {3, 10}  {4, 2}  {5, 5}  {6, 11}  {7, 2}  {8, 10}  {9, 30} ",
                    Fid,Business_Name,Street_Address,City,State,Zip,Business_Phone_Number,License_Status,ClassficationCode,ClassficationDis);
            //str = fid + "\t" + business_Name + "\t" + street_Address + "\t" + city + "\t" + state + "\t" + zip + "\t"
            //    + business_Phone_Number + "\t" + license_Status + "\t" + ClassficationCode + "\t" + ClassficationDis +"\n"; 
            return str;
        }

        //Add a new record to collection object
        public License AddNewRecord(ref License newLicense, int fid)
        {
            


            //add information to new license object
            newLicense.Fid = fid;

                newLicense.Business_Name = GetStringInput("\nBusiness Name");
                newLicense.Street_Address = GetStringInput("\nStreet Address");
                newLicense.City = GetStringInput("\nCity");
                newLicense.State = GetStringInput("\nState");
                newLicense.Zip = GetStringInput("\nZip");
                newLicense.Business_Phone_Number = GetStringInput("\nBusiness Phone Number");
                newLicense.License_Status = GetStringInput("\nLicense Status");

            
            newLicense.ClassficationDis = GetStringInput("\nClassfication Discrption");
                //return completed information object
                return newLicense;
            
        }
 
        /**
         * Read string input from user
         */
        public static string GetStringInput(string title)
        {
            String result = "";
            try
            {
                Console.WriteLine(title + " : ");
                result = Console.ReadLine();
                if (result == string.Empty) throw new Exception();
            }
            catch (Exception)
            {
                GetStringInput(title);
            }
            return result;

        }
        /**
         *Read integer input from user 
         */
        public static int GetIntegerInput(string title)
        {
            int result = int.MinValue;
            try
            {
                Console.WriteLine(title + " : ");
                result = Convert.ToInt32(Console.ReadLine());
                if (result == int.MinValue) throw new Exception();
            }
            catch (Exception e)
            {
                GetStringInput(title);
            }
            return result;
        }
    }
}
