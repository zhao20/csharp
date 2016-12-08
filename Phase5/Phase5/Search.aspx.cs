using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Phase5
{
    public partial class Search : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            using (LicenseEntities le = new LicenseEntities())
            {
                LinqDataSource ld = new LinqDataSource();

                var search = le.LicenseDBs;
                var condition = search;
                var condition1 = search.Where(n => n.Business_Name.Contains(TextBox1.Text)).ToList();
                var condition2 = search.Where(n => n.Street_Address.Contains(TextBox2.Text)).ToList();

                string ddl1 = DropDownList1.SelectedValue;
                var condition3 = search.Where(n => n.City.Equals(ddl1)).ToList();

                GridView1.DataSource = condition3;
                GridView1.DataBind();
                Label1.Text = "Businesses matching either Name or Address shown.    Refreshed at " + DateTime.Now.ToString();


                if (condition1.Count > 0 && condition2.Count > 0)
                {

                    foreach (var i in condition1)
                    {
                        condition2.Add(i);
                    }

                    GridView1.DataSource = condition2;
                    GridView1.DataBind();
                    Label1.Text = "Businesses matching either Name or Address shown.    Refreshed at " + DateTime.Now.ToString();
                }
                else {
                    if (condition1.Count > 0)
                    {
                        GridView1.DataSource = condition1;
                        GridView1.DataBind();
                        Label1.Text = "Search performed by Business Name.    Refreshed at " + DateTime.Now.ToString();
                    }
                    else {

                        if (condition2.Count > 0)
                        {
                            GridView1.DataSource = condition2;
                            GridView1.DataBind();
                            Label1.Text = "Search performed by Street Address.    Refreshed at " + DateTime.Now.ToString();
                        }

                        else {
                            Label1.Text = "No Results Found.     Refreshed at " + DateTime.Now.ToString();
                        }
                    }
                }


            }
        }
    }
}

//        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            using (LicenseEntities le = new LicenseEntities())
//            {
//                LinqDataSource ld = new LinqDataSource();

//                var search = le.LicenseDBs;
//                var ddlc = DropDownList2.SelectedIndex;
//                var ddl2 = search.Where(n => n.State.Equals(ddlc)).ToList();

//                if (ddl2.Count > 0)
//                {
//                    GridView1.DataSource = ddl2;
//                    GridView1.DataBind();
//                    Label1.Text = "Search performed by State.    Refreshed at " + DateTime.Now.ToString();
//                }

//                else {
//                    Label1.Text = "No Results Found.     Refreshed at " + DateTime.Now.ToString();
//                }
//            }
//        }
//    }
//}




                //if (TextBox1.Text != "" && TextBox1.Text != "Business Name")
                //{
                //    if (TextBox2.Text != "" && TextBox2.Text != "Address")
                //    {

                //        if (condition3.Count > 0)
                //        {
                //            GridView1.DataSource = condition3;
                //            GridView1.DataBind();
                //            Label1.Text = "Businesses matching either Name or Address shown.    Refreshed at " + DateTime.Now.ToString();
                //        }
                //        else {
                //            Label1.Text = "No results found." + "\n" + DateTime.Now.ToString();
                //        }
                //    }
                //    else {

                //        if (condition1.Count > 0)
                //        {
                //            GridView1.DataSource = condition1;
                //            GridView1.DataBind();
                //            Label1.Text = "Database searched by Business Name.  Refreshed at " + DateTime.Now.ToString();
                //        }
                //        else {
                //            Label1.Text = "No results found." + "\n" + DateTime.Now.ToString();
                //        }

                //    }
                //}
                //else {
                //    if (condition2.Count > 0)
                //    {
                //        GridView1.DataSource = condition2;
                //        GridView1.DataBind();
                //        Label1.Text = "Database searched by Street Address.  Refreshed at " + DateTime.Now.ToString();

                //    }
                //    else { Label1.Text = "No results found." + "\n" + DateTime.Now.ToString(); }
                //}
                //    }
                


            
         