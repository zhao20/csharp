using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase5
{
    public partial class SearchByZip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }
        protected void btnSearchByZip_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            try
            {

                using (LicenseEntities le = new LicenseEntities())
                {
                    gvSearchByZip.DataSource = null;
                    gvSearchByZip.DataBind();
                    if (!String.IsNullOrWhiteSpace(ddlZip.SelectedValue))
                    {
                        var licenses = le.LicenseDBs;
                        var result = licenses.Where(n => n.Zip == ddlZip.SelectedValue);

                        // lvTopThree.DataSource = result.ToList();
                        gvSearchByZip.DataSource = result.ToList();
                        gvSearchByZip.DataBind();
                        

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