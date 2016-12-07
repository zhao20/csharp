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
                if (TextBox1.Text != "" && TextBox1.Text != "Business Name")
                {
                    var searcher = search.Where(n => n.Business_Name.Contains(TextBox1.Text)).ToList();

                    if (searcher.Count > 0)
                    {
                        GridView1.DataSource = searcher;
                        GridView1.DataBind();
                        Label1.Text = "Refreshed at " + DateTime.Now.ToString();
                    }
                    else {
                        Label1.Text = "No results found." + "\n" + DateTime.Now.ToString();
                    }
                }
                else {
                    if (TextBox2.Text != "" && TextBox2.Text != "Address")
                    {
                        var searcherA = search.Where(n => n.Street_Address.Contains(TextBox2.Text)).ToList();

                        if (searcherA.Count > 0)
                        {
                            GridView1.DataSource = searcherA;
                            GridView1.DataBind();
                            Label1.Text = "Refreshed at " + DateTime.Now.ToString();
                        }
                        else {
                            Label1.Text = "No results found." + "\n" + DateTime.Now.ToString();
                        }
                    }
                    else { Label1.Text = "No results found." + "\n" + DateTime.Now.ToString(); }
                }
            }
        } 
    }
}