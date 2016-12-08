using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase5
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            //ddlCity.Items.Insert(0, new ListItem("", ""));
            //ddlCity.SelectedIndex = 0;

            //ddlStates.Items.Insert(0, new ListItem("", ""));
            //ddlStates.SelectedIndex = 0;
            //ddlStatus.Items.Insert(0, new ListItem("", ""));
            //ddlStatus.SelectedIndex = 0;
            //ddlZip.Items.Insert(0, new ListItem("", ""));
            //ddlZip.SelectedIndex = 0;
            

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {
                using (LicenseEntities le = new LicenseEntities())
                {
                    IQueryable<LicenseDB> result = le.LicenseDBs;
                    if (!String.IsNullOrWhiteSpace(txtFID.Text))
                    {
                        int fid = Convert.ToInt32(txtFID.Text);
                        result = result.Where(n => n.FID == fid);
                        flag = true;
                    }
                    if (!String.IsNullOrWhiteSpace(txtBusinessName.Text))
                    {
                        flag = true;
                        result = result.Where(n => n.Business_Name.Contains(txtBusinessName.Text));
                    }
                    if (!String.IsNullOrWhiteSpace(txtAddress.Text))
                    {
                        flag = true;
                        result = result.Where(n => n.Street_Address.Contains(txtAddress.Text));
                    }
                    if (!String.IsNullOrWhiteSpace(ddlCity.SelectedValue))
                    {
                        flag = true;
                        result = result.Where(n => n.City.Contains(ddlCity.SelectedValue));
                    }
                    if (!String.IsNullOrWhiteSpace(ddlStates.SelectedValue))
                    {
                        flag = true;
                        result = result.Where(n => n.State.Contains(ddlStates.SelectedValue));
                    }
                    if (!String.IsNullOrWhiteSpace(ddlZip.SelectedValue))
                    {
                        flag = true;
                        result = result.Where(n => n.Zip.Contains(ddlZip.SelectedValue));
                    }
                    if (!String.IsNullOrWhiteSpace(txtPhoneNumber.Text))
                    {
                        flag = true;
                        result = result.Where(n => n.Business_Phone_Number.Contains(txtPhoneNumber.Text));
                    }
                    if (!String.IsNullOrWhiteSpace(ddlStatus.SelectedValue))
                    {
                        flag = true;
                        result = result.Where(n => n.License_Status.Contains(ddlStatus.SelectedValue));
                    }
                    if (!String.IsNullOrWhiteSpace(txtClassificationCode.Text))
                    {
                        flag = true;
                        result = result.Where(n => n.Classification_Code.Contains(txtClassificationCode.Text));
                    }
                    if (!String.IsNullOrWhiteSpace(txtClassficationDes.Text))
                    {
                        flag = true;
                        result = result.Where(n => n.Classification_Description.Contains(txtClassficationDes.Text));
                    }


                    if (result.Count() > 0 && flag)
                    {
                        gvSearch.DataSource = result.ToList();

                    }
                    else
                    {
                        gvSearch.DataSource = null;

                    }
                    gvSearch.DataBind();

                }

            }
            catch (Exception)
            {
                lblMessage.Text = "Database connection error!";

            }
        }
    }
}