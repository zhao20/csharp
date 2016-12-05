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
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Data Source=db.webteach.iu.edu;User ID=zhao20_1583911;Password=7iCXpYl"].ConnectionString);


        protected void Page_Load(object sender, EventArgs e)
        {


        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            //connectionstring
            string search = "select * from LicenseDB where(Business_Name like '%' + @business_Name + '%')";// or Phone like '&' + @phone + '%')";
            SqlCommand comm = new SqlCommand(search, con);
            comm.Parameters.Add("@business_Name", SqlDbType.NVarChar).Value = TextBox1.Text;


            con.Open();
            comm.ExecuteNonQuery();


            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;
            DataSet ds = new DataSet();
            da.Fill(ds, "Business_Name");
            GridView1.DataSource = ds;
            GridView1.DataBind();


            con.Close();


        }

    }