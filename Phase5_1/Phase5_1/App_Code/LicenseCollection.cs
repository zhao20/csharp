/*Phase 4
 * Xingguo Zhao & Justin Holland
 * programming in C# 
 * 2016/11/17
 * LicenseCollection.cs
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase5_1
{
    public class LicenseCollection : Collection<License>
    {

        private List<License> LicenseList;

        //creates license collection class
        public LicenseCollection()
        {

            //creates new list 
            LicenseList = new List<License>();
            ParseData();
                             
        }

        //method to parse data to populate our database
        public void ParseData()
        {
            DataTable dt = CSVFileHelper.OpenCSV("Business_Licenses1.csv");

            //iterates and adds data to list
            foreach (DataRow row in dt.Rows)
            {
                if (row["Classification_Code"].ToString().Equals("REST"))
                {
                    LicenseList.Add(new Restaurant(row));
                }else if (row["Classification_Code"].ToString().Equals("HOTEL"))
                {
                    LicenseList.Add(new Hotel(row));
                }else if (row["Classification_Code"].ToString().Equals("AUTO"))
                {
                    LicenseList.Add(new Auto(row));
                }else
                {
                    LicenseList.Add(new OtherBusiness(row));
                }
                //LicenseList.Add(new License(row));
            }

        }

        //method to convert list data to data table
        public DataTable CovertToDataTable()
        {
            //creates data table and adds column names
            DataTable dt = new DataTable();
            foreach (var column in License.ColumnTitle())
            {
                DataColumn dc = new DataColumn(column);
                dt.Columns.Add(dc);
            }

            //creates rows for data table
            foreach(var row in LicenseList)
            {
                DataRow dr = dt.NewRow();
                dr[0] = row.Fid;
                dr[1] = row.Business_Name;
                dr[2] = row.Street_Address;
                dr[3] = row.City;
                dr[4] = row.State;
                dr[5] = row.Zip;
                dr[6] = row.Business_Phone_Number;
                dr[7] = row.License_Status;
                dr[8] = row.ClassficationCode;
                dr[9] = row.ClassficationDis;

                dt.Rows.Add(dr);
            }
            return dt;
        }


        //method to modify record in database
        public void Modify(){
            try
            {
                String titles = "";
                int options = 0;
                int id = 0;

                //get the fid
                id = GetIntegerInput("Please input FID code");


                //searches proposed FID to modify record
                License result = LicenseList.Find(s=>s.Fid == id);
                if (result == null)
                {
                    Console.WriteLine("Please input a valid FID!");
                    return;
                }
                   
                Console.WriteLine(TitleString());
                Console.WriteLine(result);
                Console.WriteLine("Please input number of OPTION you select to Change:");
                Console.WriteLine("\n\t1.Business Name\n\t2.Business Phone Number\n" +
                              "\t3.Street Address\n\t4.City\n\t5.State\n" +
                              "\t6.License Status\n\t7.Zip Code\n");
                Console.Write("Please input your choice:");
                int option = Convert.ToInt32(Console.ReadLine());

                //returns selected option to modify
                switch (option)
                {
                    case 1:
                        string bn = GetStringInput("Please Input Business Name");
                        result.Business_Name = bn;
                        break;
                    case 2:
                        string bpn = GetStringInput("Please Input Business Phone Number");
                        result.Business_Phone_Number = bpn;
                        break;  
                    case 3:
                        string sa = GetStringInput("Please Input Street Address");
                        result.Street_Address = sa;
                        break;
                    case 4:
                        string city = GetStringInput("Please Input City");
                        result.City = city;
                        break;
                    case 5:
                        string state = GetStringInput("Please input state shortcuts");
                        result.State = state;
                        break;
                    case 6:
                        string ls = GetStringInput("Please input License Status");
                        result.License_Status = ls;
                        break;
                    case 7:
                        string zip = GetStringInput("Please input zipcode");
                        result.Zip = zip;
                        break;
                    default:
                        Console.WriteLine("Please input a right option from List above!");
                        break;
                }

                Console.WriteLine("This Record has benn changed as below:");
                Console.WriteLine(TitleString());
                Console.WriteLine(result);
      
            }catch(Exception){


            }

        }


        //method to search by business name
        public void searchBusinessName(string value){
            List<License> searchResults = LicenseList.Where(s => (s.Business_Name.ToUpper()).Contains(value.ToUpper())).ToList() ;
            //print the search result on screen 
           if (searchResults.Count >0 )
               PrintList(searchResults);
           else
               Console.WriteLine("No Results found!");

        }

        //method to search by address
        public void searchAddress(string value)
        {
            List<License> searchResults = LicenseList.FindAll(s => (s.Street_Address.ToUpper()).Contains(value.ToUpper())).ToList();
            //print the search result on screen 
            if (searchResults.Count > 0)
                PrintList(searchResults);
            else
                Console.WriteLine("No Results found!");
        }
        
        //method to search by city
        public void searchCity(string value)
        {
            List<License> searchResults = LicenseList.FindAll(s => s.City.ToUpper() == value.ToUpper()).ToList();
            //print the search result on screen 
            if (searchResults.Count > 0)
                PrintList(searchResults);
            else
                Console.WriteLine("No Results found!");
        }

       //method to search by state
        public void searchState(string value)
        {
            List<License> searchResults = LicenseList.FindAll(s => s.State.ToUpper() == value.ToUpper()).ToList();
            //print the search result on screen 
            if (searchResults.Count >0 )
                PrintList(searchResults);
            else
                Console.WriteLine("No Results found!");
        }

        //method to search by license type
        public void searchLicenseStatus(string value)
        {
            List<License> searchResults = LicenseList.Where(s => s.License_Status.ToUpper() == value.ToUpper()).ToList();
            //print the search result on screen 
            if (searchResults.Count > 0)
                PrintList(searchResults);
            else
                Console.WriteLine("No Results found!");
        }

        //method to search by zip
        public void searchZip(string value)
        {
            List<License> searchResults = LicenseList.FindAll(s => s.Zip == value).ToList();
            //print the search result on screen 
            if (searchResults.Count > 0)
                PrintList(searchResults);
            else
                Console.WriteLine("No Results found!");
        }


        //method to search by phone number
        public void searchBusinessPhoneNumber(string value)
        {
            List<License> searchResults = LicenseList.FindAll(s => s.Business_Phone_Number == value).ToList();
            //print the search result on screen 
            if (searchResults.Count > 0)
                PrintList(searchResults);
            else
                Console.WriteLine("No Results found!");
        }

        //search method made into boolean for easier redundancy checks
        public bool searchFID(int value)
        {
            try
            {
                List<License> searchResults = LicenseList.FindAll(s => s.Fid == value).ToList();
                //print the search result on screen 
                if (searchResults.Count > 0)
                {
                    PrintList(searchResults);
                    return true;
                }
                else
                {
                    Console.WriteLine("No Results found!");
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }


           //method to check ids to avoid redundancies
        public bool CheckFID(int value)
        {
            try
            {
                List<License> searchResults = LicenseList.Where(s => s.Fid == value).ToList();
                //print the search result on screen 
                if (searchResults.Count > 0)
                {
                    return true;
                }
                else
                {
                    // Console.WriteLine("No Results found!");
                    return false;
                }
            }catch(NullReferenceException ){
                return false;
            }
        }


        //method to print data list
        private void PrintList(List<License> list)
        {
            string printout = "";
            foreach (var t in License.ColumnTitle())
                printout += t + "\t";
            printout += "\n";
            foreach (var l in list)
            {
                printout += l;
            }
            Console.WriteLine(printout);


        }

        //toString method
        public override string ToString()
        {
            string result = "";
            foreach (var t in License.ColumnTitle())
                result += t + "\t";
            result += "\n";
            foreach (var l in LicenseList){
                result += l;
            }
            return result;
        }

        //reads user input
        private  string GetStringInput(string title)
        {
            String result = "";
          
                Console.WriteLine(title + " : ");
                result = Console.ReadLine();
            return result;

        }

        //sets string titles
        private string TitleString(){

            String titles = "";
             foreach (var t in License.ColumnTitle())
                titles += t + "\t";
             return titles;
        }
        public int TotalRecords()
        {
            return LicenseList.Count;
        }
  


   

    /**
     *This function will show the search option to user 
     * 
     */
    public void Search()
    {
        int option = 0;
        //print out the option for user to opterate
        Console.WriteLine("Please input number of OPTION you select to search:");
        Console.Write("1.FID\t\t 2.Business Name\t\t 3.Business Phone Number\n" +
                      "4.Street Address\t\t 5.City\t\t 6.State\n" +
                      "7.License Status\t\t 8.Zip Code");
        option = GetIntegerInput("You choose Option");

        switch (option)
        {   //search by fid
            case 1:
                int fid = GetIntegerInput("Please Input Fid number");
                       searchFID(fid);
                break;
            //search by business name
            case 2:
                string bn = GetStringInput("Please Input Business Name");
                searchBusinessName(bn);
                break;
            //search by phone number
            case 3:
                string bpn = GetStringInput("Please Input Business Phone Number");
                searchBusinessPhoneNumber(bpn);
                break;
            //search by address
            case 4:
                string sa = GetStringInput("Please Input Street Address");
                searchAddress(sa);
                break;
            //search by city
            case 5:
                string city = GetStringInput("Please Input City");
                searchCity(city);
                break;
            //search by state
            case 6:
                string state = GetStringInput("Please input state shortcuts");
                searchState(state);
                break;
            //search by license status
            case 7:
                string ls = GetStringInput("Please input License Status");
                searchLicenseStatus(ls);
                break;
            //search by zip
            case 8:
                string zip = GetStringInput("Please input zipcode");
                searchZip(zip);
                break;
            default:
                Console.WriteLine("Please input a right option from List above!");
                break;
        }

    }

        /*
        * This function will create a new object by different child class
        */
        public void Add()
        {
            int fid = 0;
            //new parent object
            License newLicense;

            //object of Restaurant 
            String classfication = GetClassficationCode();
            if (classfication.Equals("REST"))
            {
                Restaurant rest = new Restaurant();
                rest.ClassficationCode = "REST";
                newLicense = rest;
            }
            //object of Auto business 
            else if (classfication.Equals("AUTO"))
            {
                Auto at = new Auto();
                at.ClassficationCode = "AUTO";
                newLicense = at;
            }//object of Hotel 
            else if (classfication.Equals("HOTEL"))
            {

                Hotel ht = new Hotel();
                ht.ClassficationCode = "HOTEL";
                newLicense = ht;
            }
            //object of Other Business 
            else
            {
                OtherBusiness ob = new OtherBusiness();
                ob.ClassficationCode = "OTHER";
                newLicense = ob;
            }

            //checking fid existing or not
            while (true)
            {
                 fid = GetIntegerInput("FID");
                if (CheckFID(fid))
                {
                    Console.WriteLine("This ID is already Exist!");
                }
                else
                {
                    //put valid Fid to the new object
                    newLicense = newLicense.AddNewRecord(ref newLicense, fid);
                    break;
                }
            }

            //adding the new object to list
            LicenseList.Add(newLicense);
            //print out the new object 
            foreach (var t in License.ColumnTitle())
                Console.Write(t + "\t");

            Console.WriteLine(newLicense);
        }

        /*
         * This function will ask user to select a valid 
         * Category.
         */
        public string GetClassficationCode()
        {
            int option;
            Console.WriteLine(String.Format("1.Auto \t 2.Restaurant \t 3.Hotel \t 4.Other"));
            option = GetIntegerInput("Please select your business type Above:");
            switch (option)
            {
                case 1:
                    return "AUTO";
                case 2:
                    return "REST";
                case 3:
                    return "HOTEL";
                default:
                    return "OTHER";
            }
        }

    /*
     *get the total number of the  records
     */
    public void DisplayTotal()
    {
        Console.WriteLine("There are {0} businesses in records!", TotalRecords());
    }


        /**
         *read integer input from user 
         */
        private int GetIntegerInput(string title)
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
                GetIntegerInput(title);
            }
            return result;
        }

        /*
         *Phase 4 Statistic menu 
         */
        public void Statistic()
        {
            int option = 0;

            while (true)
            {
                Console.WriteLine("Please select the statistic result of below:" +
                    "\n 1. Top three Business base on Alpha order."
                    + "\n 2. List shops base on Zipcode"
                    + "\n 3. List of shops base on Categroy"
                    + "\n 4. License with certain zipcode with category"
                    + "\n 5. Number of shops base on Zipcode"
                    + "\n 6. Number of shops base on Categroy"
                    + "\n 7. Exit Statistcs"
                    + "\n 8. count different Business License in categories by zipcode");

                //get user input
                option = GetIntegerInput("Your Option");
                switch (option)
                {

                    case 1:
                        //print out first three row of result
                        TopThree();
                        break;
                    case 2:
                        //print out result by zipcode
                        ShopByZip();
                        break;
                    case 3:
                        //print out result by category
                        ShopByCatagory();
                        break;
                    case 4:
                        //print out the result by zipcode and Category
                        ShopByZipCatagory();
                        break;
                    case 5:
                        //total number of Shops under certain zip code
                        NumberOfShopByZip();
                        break;
                    case 6:
                        //total number of Shops under category
                        NumberOfShopByCategory();
                        break;
                    case 7:
                        return;
                        break;
                    case 8:

                        LicenseCountByZipcode();
                        break;
                    default:
                        Console.WriteLine("Please input a valid option!");

                        break;

                }
            }
        }

        /*
         *print out the the top three row of result by user input category 
         * 
         */
        public void TopThree()
        {
            //get user input category
            string categroy = GetCategory();
            if (categroy != "")
            {
                //query of first three result by category 
                var result = LicenseList.Where(n => n.ClassficationCode.Contains(categroy)).Take(3);

                if (result.Count() > 0)
                {
                    //print out result
                    foreach (var t in License.ColumnTitle())
                        Console.Write(t + "\t");
                    Console.Write("\n");
                    foreach (var r in result)
                    {
                        Console.WriteLine(r);
                    }
                }
                else
                    Console.WriteLine("No Results found!");
             }
         }

        /*
         * Print out all the result by zipcode
         */
        public void ShopByZip()
        {   //get user input result
            int zipcode = GetZipcode();
            //query result by zipcode
            var result = LicenseList.Where(n => n.Zip.Contains(zipcode.ToString())).OrderBy(n => n.Fid);
            if (result.Count() > 0)
            {
                //print out result
                foreach (var t in License.ColumnTitle())
                    Console.Write(t + "\t");
                Console.Write("\n");
                foreach (var r in result)
                {
                    Console.WriteLine(r);
                }
            }
            else
                Console.WriteLine("No Results found!");
        }

        /*
         *Print out all the result by category 
         */
        public void ShopByCatagory()
        {
            //get user input category
            string catagory = GetCategory();
            //query result by category
            var result = LicenseList.Where(n => n.ClassficationCode.Contains(catagory)).OrderBy(n => n.Fid);
            if (result.Count() > 0)
            {
                //print out result
                foreach (var t in License.ColumnTitle())
                    Console.Write(t + "\t");
                Console.Write("\n");
                foreach (var r in result)
                {
                    Console.WriteLine(r);
                }
            }
            else
                Console.WriteLine("No Results found!");
        }

        /*
         *print result by both category and zipcode 
         */
        public void ShopByZipCatagory()
        {   
            //get user input zipcode and category
            int zipcode = GetZipcode();
            string category = GetCategory();
            //query result by both zipcode and category
            var result = LicenseList.GroupBy(n => new { n.Zip, n.ClassficationCode })
                                .Where(n => n.Key.Zip.Contains(zipcode.ToString()) && n.Key.ClassficationCode.Contains(category))
                                .SelectMany(n => n)
                                .OrderBy(n => n.Zip)
                                .ThenByDescending(n=>n.Business_Name);
            if (result.Count() > 0)
            {
                //print out result
                foreach (var t in License.ColumnTitle())
                    Console.Write(t + "\t");
                Console.Write("\n");
                foreach (var r in result)
                {
                    Console.WriteLine(r);
                }
            }
            else
                Console.WriteLine("No Results found!");
        }
        /*
         *get user input zipcode 
         */
        public int GetZipcode()
        {
            int zip;
            zip = GetIntegerInput("Please input zipcode");
            return zip;
        }

        /*
         * get user select catagory
         */
        public string GetCategory()
        {
            int option = 0;
            string categroy = "";
            Console.WriteLine("Please select the type of Business Below:");
            Console.WriteLine(String.Format("1.Auto \t 2.Restaurant \t 3.Hotel \t 4.Other"));
            
            while (categroy == "")
            {
                option = GetIntegerInput("Please select your business type Above:");
                switch (option)
                {
                    case 1:
                        categroy = "AUTO";
                        break;
                    case 2:
                        categroy = "REST";
                        break;
                    case 3:
                        categroy = "HOTEL";
                        break;
                    case 4:
                        categroy = "OTHER";
                        break;
                    default:
                        Console.WriteLine("Please input a Correct option!");
                        break;
                }
            }
            return categroy;
        }

        //print out the total license number by zip code
        public void NumberOfShopByZip()
        {
            int zipcode = GetZipcode();
            var result = LicenseList.Where(n => n.Zip.Contains(zipcode.ToString())).Count();
            Console.WriteLine("There are total {0} Licenses by zip: {1}", result, zipcode);

        }

        //print out the total license number by zip code
        public void NumberOfShopByCategory()
        {
            string category = GetCategory();
            var result = LicenseList.Where(n => n.ClassficationCode.Contains(category)).Count();
            Console.WriteLine("There are total {0} Licenses by Category: {1}", result, category);

        }

        public void LicenseCountByZipcode()
        {
            int zipcode = GetZipcode();

            var restResult = from l in LicenseList
                             group l by l.Zip into licenseByZip
                             select new
                             {
                                 totalRest = licenseByZip.Count(n => n.Zip.Contains(zipcode.ToString()) && n.ClassficationCode.Contains("rest")),
                                 zip = zipcode
                             };

            foreach (var item in restResult)
                Console.WriteLine(item.zip + " " + item.totalRest);
           

        }
    }
}
