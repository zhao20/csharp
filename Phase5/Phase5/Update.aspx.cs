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

        }


        protected void btnModify_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtFID.Text))
            {
                using (LicenseEntities le = new LicenseEntities())
                {
                    try
                    {
                        int fid = Convert.ToInt32(txtFID.Text);
                        var lic = le.LicenseDBs.SingleOrDefault(n => n.FID == fid);
                        if (lic != null)
                        {


                            txtBusiness_Name.Text = lic.Business_Name;
                            txtBusiness_Phone_Number.Text = lic.Business_Phone_Number;
                            txtCity.Text = lic.City;
                            txtClassficationCode.Text = lic.Classification_Code;
                            txtClassficationDes.Text = lic.Classification_Description;
                            txtLicense_Status.Text = lic.License_Status;
                            txtState.Text = lic.State;
                            txtStreet_Address.Text = lic.Street_Address;
                            txtZip.Text = lic.Zip;


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

    }
}