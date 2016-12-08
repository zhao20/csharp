/*Phase 5
 * Xingguo Zhao & Justin Holland
 * programming in C# 
 * 2016/12/8
 * Adding.aspx.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Phase5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*
         The Submit function will pull the data from webpage, put into a LicenseDB object
         Then store it inot the database
         */
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //check the fid field is exist or not, empty throw a excetion to stop
                //the process
                if (CheckFID(Convert.ToInt32(txtFID.Text))) throw new Exception();
                lblSuccess.Text = "";
                //create a entity framework object
                using (LicenseEntities le = new LicenseEntities())
                {
                    LicenseDB lDB = new LicenseDB();
                    lDB.Business_Name = txtBusiness_Name.Text;
                    lDB.Business_Phone_Number = txtBusiness_Phone_Number.Text;
                    lDB.City = txtCity.Text;
                    lDB.State = txtState.Text;
                    lDB.Zip = txtZip.Text;
                    lDB.License_Status = txtLicense_Status.Text;
                    lDB.FID = Convert.ToInt32(txtFID.Text);
                    lDB.Classification_Code = txtClassficationCode.Text;
                    lDB.Classification_Description = txtClassficationDes.Text;

                    //add new record to entity framework
                    le.LicenseDBs.Add(lDB);
                    le.SaveChanges();
                    lblSuccess.Text = "Adding Success!!";
                }
            }
            catch (Exception)
            {
                lblSuccess.Text = "FID is already Existed!!";
            }
        }


        //Check is the user input FID exist 
        private bool CheckFID(int fid)
        {
            //create entity frame work object
            using (LicenseEntities le = new LicenseEntities())
            {
                //check any result in the database of the fid
                var exist = le.LicenseDBs.Any(n => n.FID == fid);
                if (exist)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}
