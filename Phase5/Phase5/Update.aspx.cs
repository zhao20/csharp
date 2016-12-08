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


        protected void btnModify_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtFID.Text))
            {
                CleanText();
                using (LicenseEntities le = new LicenseEntities())
                {
                    try
                    {
                        int fid = Convert.ToInt32(txtFID.Text);
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
                    catch (Exception ex)
                    {
                       
                    }
                }

            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<string> GetFID(string pre)
        {
            List<string> allFID = new List<string>();
            using (LicenseEntities dc = new LicenseEntities())
            {
               // allFID = dc.LicenseDBs.Where(n => n.FID.StartsWith(pre)).ToList();
                 allFID = (from a in dc.LicenseDBs
                                  where (SqlFunctions.StringConvert((double)a.FID)).Trim().StartsWith(pre)
                                  select SqlFunctions.StringConvert((double)a.FID).Trim()).ToList();
            }
            return allFID;
        }

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
                            lblMessage.Text = "Updata Success!";
                        }
                    }
                    catch (Exception)
                    {
                        lblMessage.Text = "Updata failed!";
                    }
                }
            }
        }

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

    }
}