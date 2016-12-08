/*Phase 5
 * Xingguo Zhao & Justin Holland
 * programming in C# 
 * 2016/12/8
 * SearchByZipAndCatagory.aspx.cs
 */

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

        /*This function will show the reuslt similar business in certain area 
         * 
         */
        protected void btnSearchByZipAndCategory_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            try
            {
                //check user input any thing
                if (String.IsNullOrWhiteSpace(ddlCategory.SelectedValue) 
                    || String.IsNullOrWhiteSpace(ddlZip.SelectedValue))
                {
                    //no input get from user
                    lblMessage.Text = "Please select search conditions";
                    return;

                }
                using (LicenseEntities le = new LicenseEntities())
                {
                    gvSearchByZip.DataSource = null;
                    gvSearchByZip.DataBind();

                        var licenses = le.LicenseDBs;
                        //get the result fit for the both condition
                        var result = licenses.Where(n => n.Zip == ddlZip.SelectedValue 
                                                && n.Classification_Code == ddlCategory.SelectedValue);
                        if(result.Count() == 0)
                        {
                            lblMessage.Text = "No Result Found!";
                        }
                    //put search result to Grid View
                    gvSearchByZip.DataSource = result.ToList();
                        gvSearchByZip.DataBind();
                        //show user total number of results have been found
                        lblMessage.Text = "There are " + result.Count() + " results has been found!";
                    }

                
            }
            catch (Exception)
            {
                lblMessage.Text = "DataBase Connection Failed!";
            }
        }
    }
}