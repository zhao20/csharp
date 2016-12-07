using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Phase5
{
    public class CSVFileHelper
    {
       
        //a method that creates a new CSV file for our data if no directory exists
        
        public static void SaveCSV(DataTable dt, string fullPath)
        {


            FileInfo fi = new FileInfo(fullPath);


            //checks if directory exists and creates new if it does not
            if (!fi.Directory.Exists)
            {
                fi.Directory.Create();
            }


            //creates new file with desired path and encoding
            FileStream fs = new FileStream(fullPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);


            try
            {
               
                string data = "";
               
                //creates a list of columns
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data += dt.Columns[i].ColumnName.ToString();
                    
                    //adds comma between column names for formatting purposes
                    if (i < dt.Columns.Count - 1)
                    {
                        data += ",";
                    }
                }


                sw.WriteLine(data);
                
                //creates a list of rows 
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    data = "";
                    
                    //iterates through all rows and columns 
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        string str = dt.Rows[i][j].ToString();


                        //escapes backslash within a string
                        str = str.Replace("\"", "\"\"");


                        //parses string and formats for C#
                        if (str.Contains(',') || str.Contains('"')
                            || str.Contains('\r') || str.Contains('\n')) 
                        {
                            str = string.Format("\"{0}\"", str);
                        }


                        //adds revised string from streamreader to data string
                        data += str;
                        
                        //formatting 
                        if (j < dt.Columns.Count - 1)
                        {
                            data += ",";
                        }
                    }


                    //writes data from stream to our CSV file
                    sw.WriteLine(data);
                }


                //confirmation of CSV file stream success
                Console.WriteLine("CSV file saved!!!");
            }
            catch (IOException e)   //catch for stream errors and message to verify
            {
                Console.WriteLine("File cannot be writed!!");
            }
            finally
            {
                sw.Close();     //closes streamwriter
                fs.Close();     //closes directory
            }
            
        }


        //method for opening our newly created/modified CSV file
        public static DataTable OpenCSV(string filePath)
        {
           // creates new Data Table and initiates new file stream
            DataTable dt = new DataTable();
            FileStream fs = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);


            //intitiates stream reader for new file stream
            StreamReader sr = new StreamReader(fs);
            
            //creates a new string for our stream reader
            string strLine = "";
            
            //creates a set of arrays for our data table
            string[] aryLine = null;
            string[] tableHead = null;
            
            // initializes column count as an int
            int columnCount = 0;
            
            //boolean for ordering/formatting
            bool IsFirst = true;


            //creating our table
            try
            {


                //parses through all data to populate our table
                while ((strLine = sr.ReadLine()) != null)
                {
                    
                    //selects data up to first comma and uses as column title
                    if (IsFirst == true)
                    {
                        tableHead = strLine.Split(',');
                        IsFirst = false;
                        columnCount = tableHead.Length;
                        
                        //adds column title to table
                        for (int i = 0; i < columnCount; i++)
                        {
                            DataColumn dc = new DataColumn(tableHead[i]);
                            dt.Columns.Add(dc);
                        }
                    }
                    else
                    {
                        //
                        aryLine = strLine.Split(',');
              
                        DataRow dr = dt.NewRow();
                        for (int j = 0; j < columnCount; j++)
                        {
                            dr[j] = aryLine[j];
                        }
                        dt.Rows.Add(dr);
                    }
                   // Console.WriteLine("This are {0} Colums!!", columnCount);
                    // Console.WriteLine(strLine);
                }


            }catch(Exception e){


                Console.WriteLine(e);
            }finally{
                 sr.Close();
                fs.Close();
            }


           
            return dt;
        }
    }
}