/*Phase 5
 * Xingguo Zhao & Justin Holland
 * programming in C# 
 * 2016/12/8
 * Update.aspx.cs
 */

using System;
using System.Collections.Generic;
using System.Data.Objects.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase5
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        /*This funtion will get the record from database, the load to the textbox
         * for user to modify
         * 
         */
        protected void btnModify_Click(object sender, EventArgs e)
        {

            //Check the fid has inputted or not
            if (!String.IsNullOrWhiteSpace(txtFID.Text))
            {
                //clean existed value of textboxes
                CleanText();

                using (LicenseEntities le = new LicenseEntities())
                {
                    try
                    {

                        int fid = Convert.ToInt32(txtFID.Text);
                        //check the FID exist or not
                        if (!Existed(fid)) throw new Exception();
                        var lic = le.LicenseDBs.SingleOrDefault(n => n.FID == fid);
                        if (lic != null)
                        {
                            txtBusiness_Name.Text = lic.Business_Name.Trim();
                            txtBusiness_Phone_Number.Text = lic.Business_Phone_Number.Trim();
                            txtCity.Text = lic.City.Trim();
                            txtClassficationCode.Text = lic.Classification_Code.Trim();

                            txtLicense_Status.Text = lic.License_Status.Trim();
                            txtState.Text = lic.State.Trim();
                            txtStreet_Address.Text = lic.Street_Address.Trim();
                            txtZip.Text = lic.Zip.Trim();
                            txtClassficationDes.Text = lic.Classification_Description.Trim();


                        }
                    }
                    catch (Exception)
                    {
                        lblMessage.Text = "FID Not Exist!";
                    }
                }

            }

        }

        /*This is a Websevice method fo the AutoComplete text input
         * 
         */
        [WebMethod]
        //allow the javascript to use the webservice
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<string> GetFID(string pre)
        {
            List<string> allFID = new List<string>();
            using (LicenseEntities dc = new LicenseEntities())
            {
                //get the fid start will the certain number
                // allFID = dc.LicenseDBs.Where(n => n.FID.StartsWith(pre)).ToList();
                allFID = (from a in dc.LicenseDBs
                          where (SqlFunctions.StringConvert((double)a.FID)).Trim().StartsWith(pre)
                          select SqlFunctions.StringConvert((double)a.FID).Trim()).ToList();
            }
            return allFID;
        }

        //This function will update user modified data
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtFID.Text))
            {
                lblMessage.Text = "";
                using (LicenseEntities le = new LicenseEntities())
                {
                    try
                    {
                        int fid = Convert.ToInt32(txtFID.Text);
                        var updataeLicense = le.LicenseDBs.FirstOrDefault(n => n.FID == fid);
                        if (updataeLicense != null)
                        {
                            updataeLicense.Business_Name = txtBusiness_Name.Text;
                            updataeLicense.Business_Phone_Number = txtBusiness_Phone_Number.Text;
                            updataeLicense.City = txtCity.Text;
                            updataeLicense.State = txtState.Text;
                            updataeLicense.Zip = txtZip.Text;
                            updataeLicense.License_Status = txtLicense_Status.Text;

                            updataeLicense.Classification_Code = txtClassficationCode.Text;
                            updataeLicense.Classification_Description = txtClassficationDes.Text;

                            le.Entry(updataeLicense).State = System.Data.EntityState.Modified;
                            le.SaveChanges();
                            lblMessage.Text = "Update Success!";
                        }
                    }
                    catch (Exception)
                    {
                        lblMessage.Text = "Update failed!";
                    }
                }
            }
        }

        //Clean all the textbox contents
        private void CleanText()
        {
            txtBusiness_Name.Text = "";
            txtBusiness_Phone_Number.Text = "";
            txtCity.Text = "";
            txtClassficationCode.Text = "";
            txtClassficationDes.Text = "";
            //txtFID.Text = "";
            txtLicense_Status.Text = "";
            txtState.Text = "";
            txtStreet_Address.Text = "";
            txtZip.Text = "";

        }


        /**
        * Check existence of the FID
        */
        private bool Existed(int fid)
        {
            using (LicenseEntities le = new LicenseEntities())
            {

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