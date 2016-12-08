/*Phase 5
 * Xingguo Zhao & Justin Holland
 * programming in C# 
 * 2016/12/8
 * LoadRemove.aspx.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/***
 * This page will allow user to import the csv file from local computer
 * 
 */
namespace Phase5
{
    public partial class LoadRemove : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";

        }


        /**
         * This function will take the path of user select csv file,
         * then create a license list to store csv file information
         * then store the license into entity framework 
         */
        protected void btnSubmit_Click(object sender, EventArgs e)
        
        {
            string path = "";
            lblMessage.Text = "";
            try
            {
                //check user selection of textbox empty or not
                if (!String.IsNullOrWhiteSpace(fuCSV.FileName))
                {
                    path = fuCSV.FileName;
                    //get the full path of user select file
                    path = Convert.ToString(fuCSV.PostedFile.FileName);
                    //print out the full path of file
                    lblMessage.Text = path;
                    //read the file from 
                    LicenseCollection lc = new LicenseCollection(path);
                    //create entity frame work
                    LicenseEntities en = new LicenseEntities();

                    //store licene once a time to the entiry framework
                    foreach (var l in lc)
                    {   //check fid existence
                        if (Existed(l.Fid)) continue;
                        LicenseDB lDB = new LicenseDB();
                        lDB.Business_Name = l.Business_Name;
                        lDB.Street_Address = l.Street_Address;
                        lDB.Business_Phone_Number = l.Business_Phone_Number;
                        lDB.City = l.City;
                        lDB.State = l.State;
                        lDB.Zip = l.Zip;
                        lDB.License_Status = l.License_Status;
                        lDB.FID = l.Fid;
                        lDB.Classification_Code = l.ClassficationCode;
                        //this part is from the phase 4 , revese back to orginal
                        if (l.GetType() == typeof(Hotel))
                        {
                            lDB.Classification_Description = ((Hotel)l).ClassficationDis;
                        }
                        else if (l.GetType() == typeof(Auto))
                        {
                            lDB.Classification_Description = ((Auto)l).ClassficationDis;
                        }
                        else if (l.GetType() == typeof(Restaurant))
                        {
                            lDB.Classification_Description = ((Restaurant)l).ClassficationDis;
                        }
                        else if (l.GetType() == typeof(OtherBusiness))
                        {
                            OtherBusiness newOther = (OtherBusiness)l;
                            lDB.Classification_Description = newOther.ClassficationDis;
                        }
                        //lDB.Classification_Description = l.ClassficationDis;
                        //save data to database
                        en.LicenseDBs.Add(lDB);
                        en.SaveChanges();
                    }
                }
                //show the final information to user
                lblMessage.Text = "Your data has been update Database!";
                

            }catch(Exception)
            {
                lblMessage.Text = "The CSV file format is not right";

            }
           }

        /**
         * This function will remvoe all the content of database
         * 
         */

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            using (LicenseEntities le = new LicenseEntities())
            {

                //remove records one by one
                foreach (var entity in le.LicenseDBs)
                    le.LicenseDBs.Remove(entity);
                le.SaveChanges();
                
            }
            //show information to user
            lblMessage.Text = "All the data has been removed from database!";
        }

        /**
         * Check existence of the FID
         */
        private bool Existed(int fid)
        {
            using(LicenseEntities le = new LicenseEntities()){

                var exist = le.LicenseDBs.Any(n=>n.FID == fid);
                if(exist){
                    return true;
                }else{
                    return false;
                }
            }
        }
    }
}