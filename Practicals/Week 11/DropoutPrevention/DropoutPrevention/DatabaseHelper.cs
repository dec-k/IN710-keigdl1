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
        SqlDataReader dataReader;
        SqlCommand commandToExecute;
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

        private void clearLB(ListBox lb)
        {
            lb.Items.Clear();
        }

        private void stringToReader(string commandString){
            //Clear
            clearLB(lb);

            //Open connection first
            connection.Open();

            //Instantiate a sqlcommand
            commandToExecute = new SqlCommand();

            //Set command connection
            commandToExecute.Connection = connection;
            commandToExecute.CommandText = commandString;

            //Create a sql data reader
            dataReader = commandToExecute.ExecuteReader();
        }

        private void closeConnections()
        {
            dataReader.Close();
            connection.Close();
        }

        public void ShowPapers()
        {
            //Query string
            string commandString = "SELECT tblPaper.paperName, tblLecturer.firstName, tblLecturer.lastName, tblLecturer.email " +
                                   "FROM tblPaper JOIN tblLecturer ON tblPaper.paperID=tblLecturer.lecID;";

            //Update reader instance
            stringToReader(commandString);

            //Output specific to each button
            while (dataReader.Read())
            {
                lb.Items.Add("Course: " + dataReader["paperName"]);
                lb.Items.Add("Lecturer: " + dataReader["firstName"] + " " + dataReader["lastName"]);
                lb.Items.Add("Lecturer Email: " + dataReader["email"]);
                lb.Items.Add("\n");
            }

            //Close all connections
            closeConnections();
        }

        public void DueSoon()
        {
            //Get date that is two weeks from now
            string now = DateTime.Now.ToString("yyyy-MM-dd");
            string twoWeeksFromNow = DateTime.Now.AddDays(14).ToString("yyyy-MM-dd");

            //Query string
            string commandString = "SELECT tblAssignment.assignName, tblAssignment.deadline " +
                                   "FROM tblAssignment " +
                                   "WHERE tblAssignment.deadline BETWEEN '" + now + "' AND '" + twoWeeksFromNow + "';";

            stringToReader(commandString);

            while (dataReader.Read())
            {
                lb.Items.Add("Assignment Name: " + dataReader["assignName"]);
                lb.Items.Add("Due On: " + dataReader["deadline"]);
                lb.Items.Add("\n");
            }

            closeConnections();
        }

        public void AverageGrades()
        {
            //Get date that is two weeks from now
            string now = DateTime.Now.ToString("yyyy-mm-dd");
            string twoWeeksFromNow = DateTime.Now.AddDays(14).ToString("yyyy-mm-dd");

            //Query string
            string commandString = "SELECT tblPaper.paperName, CAST(AVG(tblAssignment.score) AS numeric(36,2)) AS scoreAvg " +
                                   "FROM tblAssignment JOIN tblPaper ON tblAssignment.paperID=tblPaper.paperID " + 
                                   "GROUP BY tblPaper.paperName;";

            stringToReader(commandString);

            while (dataReader.Read())
            {
                lb.Items.Add("Paper Name: " + dataReader["paperName"]);
                lb.Items.Add("Average Score: " + dataReader["scoreAvg"]);
                lb.Items.Add("\n");
            }

            closeConnections();
        }
    }
}
