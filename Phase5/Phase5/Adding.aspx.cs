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

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            LicenseEntities le = new LicenseEntities();
            LicenseDB lDB = new LicenseDB();
            lDB.Business_Name =txtBusiness_Name.Text;
            lDB.Business_Phone_Number = txtBusiness_Phone_Number.Text;
            lDB.City = txtCity.Text;
            lDB.State = txtState.Text;
            lDB.Zip = txtZip.Text;
            lDB.License_Status = txtLicense_Status.Text;
            lDB.FID = Convert.ToInt32(txtFID.Text);
            lDB.Classification_Code = txtClassficationCode.Text;
            lDB.Classification_Description = txtClassficationDes.Text;

            le.LicenseDBs.Add(lDB);
            le.SaveChanges();
            lblSuccess.Text = "Adding Success!!";
        }

        private void success()
        {
            txtBusiness_Name.Text = "";
            txtBusiness_Phone_Number.Text = "";
            txtCity.Text = "";
            txtClassficationCode.Text = "";
            txtClassficationDes.Text = "";
            txtFID.Text = "";
            txtLicense_Status.Text = "";
            txtState.Text = "";
            txtStreet_Address.Text = "";
            txtZip.Text = "";
            
        }

        protected void btnADD_Click(object sender, EventArgs e)
        {

        }
    }
}
