/*Phase 5
 * Xingguo Zhao & Justin Holland
 * programming in C# 
 * 2016/12/8
 * Statistic.aspx.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase5
{
    public partial class Statistics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        /*
         * This function the get all business by zipcode
         * 
         */
        protected void btnTopThree_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            try
            {
                using (LicenseEntities le = new LicenseEntities())
                {
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                    if (!String.IsNullOrWhiteSpace(ddlCity.SelectedValue))
                    {
                        var licenses = le.LicenseDBs;
                        //get result by zipcode
                        var result = licenses.Where(n => n.City == ddlCity.SelectedValue).Take(3);

                        // lvTopThree.DataSource = result.ToList();
                        GridView1.DataSource = result.ToList();
                        GridView1.DataBind();

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