/*Phase 5
 * Xingguo Zhao & Justin Holland
 * programming in C# 
 * 2016/12/8
 * Search.aspx.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


/*This search page will get user input conditions 
 * to find out the records which are fitted for the conditions
 * 
 */
namespace Phase5
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        //This Funtion will pull the information from page
        //and search from the Database
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //this flag to make sure user inputed or selected something
            bool flag = false;
            try
            {
                using (LicenseEntities le = new LicenseEntities())
                {
                    //get all the records in the database
                    IQueryable<LicenseDB> result = le.LicenseDBs;
                    //check user input contents
                    if (!String.IsNullOrWhiteSpace(txtFID.Text))
                    {   //FID is integer value in the database
                        int fid = Convert.ToInt32(txtFID.Text);
                        result = result.Where(n => n.FID == fid);
                        flag = true;
                    }
                    //check user input contents
                    if (!String.IsNullOrWhiteSpace(txtBusinessName.Text))
                    {
                        flag = true;
                        result = result.Where(n => n.Business_Name.Contains(txtBusinessName.Text));
                    }
                    //check user input contents
                    if (!String.IsNullOrWhiteSpace(txtAddress.Text))
                    {
                        flag = true;
                        result = result.Where(n => n.Street_Address.Contains(txtAddress.Text));
                    }
                    //check user input contents
                    if (!String.IsNullOrWhiteSpace(ddlCity.SelectedValue))
                    {
                        flag = true;
                        result = result.Where(n => n.City.Contains(ddlCity.SelectedValue));
                    }
                    //check user input contents
                    if (!String.IsNullOrWhiteSpace(ddlStates.SelectedValue))
                    {
                        flag = true;
                        result = result.Where(n => n.State.Contains(ddlStates.SelectedValue));
                    }
                    //check user input contents
                    if (!String.IsNullOrWhiteSpace(ddlZip.SelectedValue))
                    {
                        flag = true;
                        result = result.Where(n => n.Zip.Contains(ddlZip.SelectedValue));
                    }
                    //check user input contents
                    if (!String.IsNullOrWhiteSpace(txtPhoneNumber.Text))
                    {
                        flag = true;
                        result = result.Where(n => n.Business_Phone_Number.Contains(txtPhoneNumber.Text));
                    }
                    //check user input contents
                    if (!String.IsNullOrWhiteSpace(ddlStatus.SelectedValue))
                    {
                        flag = true;
                        result = result.Where(n => n.License_Status.Contains(ddlStatus.SelectedValue));
                    }
                    //check user input contents
                    if (!String.IsNullOrWhiteSpace(txtClassificationCode.Text))
                    {
                        flag = true;
                        result = result.Where(n => n.Classification_Code.Contains(txtClassificationCode.Text));
                    }
                    //check user input contents
                    if (!String.IsNullOrWhiteSpace(txtClassficationDes.Text))
                    {
                        flag = true;
                        result = result.Where(n => n.Classification_Description.Contains(txtClassficationDes.Text));
                    }

                    //check any result exists in the final
                    if (result.Count() > 0 && flag)
                    {
                        gvSearch.DataSource = result.ToList();

                    }
                    else
                    {
                        //no result find the reset the GridView
                        gvSearch.DataSource = null;

                    }
                    //update the Grid View
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