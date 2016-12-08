/*Phase 5
 * Xingguo Zhao & Justin Holland
 * programming in C# 
 * 2016/12/8
 * SearchByZip.aspx.cs
 */

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

        /**
         * This funciton will pull out the record based on the zipcode
         */
        protected void btnSearchByZip_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            try
            {
                //using entity framework to connect to database
                using (LicenseEntities le = new LicenseEntities())
                {
                    //reset the Grid View
                    gvSearchByZip.DataSource = null;
                    gvSearchByZip.DataBind();
                    //check any exist input by user
                    if (!String.IsNullOrWhiteSpace(ddlZip.SelectedValue))
                    {
                        var licenses = le.LicenseDBs;
                        //get the result from the entites search
                        var result = licenses.Where(n => n.Zip == ddlZip.SelectedValue);

                        if (result.Count() == 0)
                        {
                            lblMessage.Text = "No Result Found!";
                        }
                        // lvTopThree.DataSource = result.ToList();
                        gvSearchByZip.DataSource = result.ToList();
                        gvSearchByZip.DataBind();
                        //show number of the result 
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