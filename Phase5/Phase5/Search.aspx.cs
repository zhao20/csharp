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


        protected void Button1_Click(object sender, EventArgs e)
        {
            //connectionstring



            //con.Open();
            //comm.ExecuteNonQuery();


            //SqlDataAdapter da = new SqlDataAdapter();
            ////da.SelectCommand = comm;
            //DataSet ds = new DataSet();
            //da.Fill(ds, "Business_Name");
            //ListView1.DataSource = ds;
            //ListView1.DataBind();

            //string find = "select * from LicenseDB where(Business_Name like '%' + @business_Name + '%')";// or Phone like '&' + @phone + '%')";
            //SqlCommand comm = new SqlCommand(find);
            //con.Close();

            //string search = 
            // comm.Parameters.Add("@business_Name", SqlDbType.NVarChar).Value = TextBox1.Text;



        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Label1.Text = "Refreshed at " + DateTime.Now.ToString();

             
            
            using (LicenseEntities le = new LicenseEntities())
            {
                LinqDataSource ld = new LinqDataSource();
                
                var search = le.LicenseDBs;
                     
                 var   searcher = search.Where(n => n.Business_Name.Contains(TextBox1.Text));


                GridView1.DataSource = searcher.ToList() ;
                GridView1.DataBind();
                
            }

        } 
    }
}