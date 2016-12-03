using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase5
{
    public partial class MainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LicenseEntities en = new LicenseEntities();

            License ls = new License();
            LicenseCollection lc = new LicenseCollection();


            foreach (var l in lc)
            {
                LicenseDB lDB = new LicenseDB();
                lDB.Business_Name = l.Business_Name;
                lDB.Business_Phone_Number = l.Business_Phone_Number;
                lDB.City = l.City;
                lDB.State = l.State;
                lDB.Zip = l.Zip;
                lDB.License_Status = l.License_Status;
                lDB.FID = l.Fid;
                lDB.Classification_Code = l.ClassficationCode;
                lDB.Classification_Description = l.ClassficationDis;

                en.LicenseDBs.Add(lDB);
                en.SaveChanges();
            }

        
    }
    }
}