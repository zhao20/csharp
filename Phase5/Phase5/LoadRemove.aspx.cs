using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Phase5
{
    public partial class LoadRemove : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        
        {
            string path = "";
           

            if (!String.IsNullOrWhiteSpace(fuCSV.FileName))
            {
                path = fuCSV.FileName;
                path = Convert.ToString(fuCSV.PostedFile.FileName);
                lblResult.Text = path;
                LicenseCollection lc = new LicenseCollection(path);


                 LicenseEntities en = new LicenseEntities();
 
            License ls = new License();
           
 
 
            foreach (var l in lc)
            {
                if (Existed(l.Fid)) continue;
                LicenseDB lDB = new LicenseDB();
                lDB.Business_Name = l.Business_Name;
                lDB.Street_Address = l.Street_Address;
                lDB.Business_Phone_Number = l.Business_Phone_Number;
                lDB.City = l.City;
                lDB.State = l.State;
                lDB.Zip = l.Zip;
                lDB.License_Status = l.License_Status;
                lDB.FID = l.Fid;
                lDB.Classification_Code = l.ClassficationCode;
                if (l.GetType() == typeof(Hotel))
                {
                    lDB.Classification_Description = ((Hotel)l).ClassficationDis;
                }
                else if (l.GetType() == typeof(Auto))
                {
                    lDB.Classification_Description = ((Auto)l).ClassficationDis;
                }
                else if (l.GetType() == typeof(Restaurant))
                {
                    lDB.Classification_Description = ((Restaurant)l).ClassficationDis;
                }
                else if (l.GetType() == typeof(OtherBusiness))
                {
                    OtherBusiness newOther = (OtherBusiness)l;
                    lDB.Classification_Description = newOther.ClassficationDis;
                }
                //lDB.Classification_Description = l.ClassficationDis;
 
                en.LicenseDBs.Add(lDB);
                en.SaveChanges();
            }
            }
            lblResult.Text = "Your data has been update Database!";
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            using (LicenseEntities le = new LicenseEntities())
            {


                foreach (var entity in le.LicenseDBs)
                    le.LicenseDBs.Remove(entity);
                le.SaveChanges();
                

            }
            lblResult.Text = "All the data has been removed from database!";
        }

        private bool Existed(int fid)
        {
            using(LicenseEntities le = new LicenseEntities()){

                var exist = le.LicenseDBs.Any(n=>n.FID == fid);
                if(exist){
                    return true;
                }else{
                    return false;
                }
            }
        }
    }
}