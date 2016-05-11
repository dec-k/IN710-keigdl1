using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropoutPrevention
{
    public class DatabaseHelper
    {
        SqlConnection connection;
        ListBox lb;

        public DatabaseHelper(ListBox lb)
        {
            this.lb = lb;
            makeConnection();
        }

        private void makeConnection()
        {
            //Declare connection instance
            connection = new SqlConnection();

            //Very fussy connection string
            connection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" +            //Data Source
                                          "Initial Catalog = IN700001_201601_KEIGDL1;" +    //Initial Catalog
                                          "User ID = keigdl1;" +                            //BitDev Username
                                          "Password = " + StaticInfo.pw + ";";              //Shh! It's a gosh darn plain text password!
        }

        public void ShowPapers()
        {
            //Open connection first
            connection.Open();

            //Query string
            string commandString = "SELECT tblPaper.paperName, tblLecturer.firstName, tblLecturer.lastName, tblLecturer.email " +
                                   "FROM tblPaper JOIN tblLecturer ON tblPaper.paperID=tblLecturer.lecID;";

            //Instantiate a sqlcommand
            SqlCommand commandToExecute = new SqlCommand();

            //Set command connection
            commandToExecute.Connection = connection;
            commandToExecute.CommandText = commandString;

            //Create a sql data reader
            SqlDataReader dataReader;
            dataReader = commandToExecute.ExecuteReader();

            while (dataReader.Read())
            {
                lb.Items.Add(dataReader["paperName"]);
            }


        }


    }
}
