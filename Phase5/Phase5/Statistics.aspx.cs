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

        protected void btnTopThree_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            try { 
            using(LicenseEntities le = new LicenseEntities())
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
                if (!String.IsNullOrWhiteSpace(ddlCity.SelectedValue))
                {
                    var licenses = le.LicenseDBs;
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