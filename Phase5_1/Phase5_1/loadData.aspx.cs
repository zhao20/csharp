using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Phase5_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Entities en = new Entities();

            License ls = new License();
            LicenseCollection lc = new LicenseCollection();


            foreach (License l in lc)
            {

                en.LicenseDB.Add((LicenseDB));

            }

            en.LicenseDBs.Add();
        }
    }

    protected LicenseDB Convert(License l)
    {
        LicenseDB lDB = new LicenseDB();
        lDB.Business_Name = l.Business_Name;
        lDB.Business_Phone_Number = l.Business_Phone_Number;
        lDB.City = l.City;
        l

        return new LicenseDB();
    }
}

