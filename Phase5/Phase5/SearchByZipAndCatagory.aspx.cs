using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase5
{
    public partial class SearchByZipAndCatagory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        protected void btnSearchByZipAndCategory_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            try
            {
                if (String.IsNullOrWhiteSpace(ddlCategory.SelectedValue) 
                    || String.IsNullOrWhiteSpace(ddlZip.SelectedValue))
                {
                    lblMessage.Text = "Please select search conditions";
                    return;

                }
                using (LicenseEntities le = new LicenseEntities())
                {
                    gvSearchByZip.DataSource = null;
                    gvSearchByZip.DataBind();
                    if (!String.IsNullOrWhiteSpace(ddlZip.SelectedValue))
                    {
                        var licenses = le.LicenseDBs;
                        var result = licenses.Where(n => n.Zip == ddlZip.SelectedValue 
                                                && n.Classification_Code == ddlCategory.SelectedValue);
                        if(result.Count() == 0)
                        {
                            lblMessage.Text = "No Result Found!";
                        }
                        // lvTopThree.DataSource = result.ToList();
                        gvSearchByZip.DataSource = result.ToList();
                        gvSearchByZip.DataBind();

                        lblMessage.Text = "There are " + result.Count() + " results has been found!";
                    }

                }
            }
            catch (Exception)
            {
                lblMessage.Text = "DataBase Connection Failed!";
            }
        }
    }
}