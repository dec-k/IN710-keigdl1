﻿using System;
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

        private void clearLB(ListBox lb)
        {
            lb.Items.Clear();
        }

        public void ShowPapers()
        {
            //Clear
            clearLB(lb);

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
                lb.Items.Add("Course: " + dataReader["paperName"]);
                lb.Items.Add("Lecturer: " + dataReader["firstName"] + " " + dataReader["lastName"]);
                lb.Items.Add("Lecturer Email: " + dataReader["email"]);
                lb.Items.Add("\n");
            }

            connection.Close();
        }

        public void DueSoon()
        {
            clearLB(lb);

            //Get date that is two weeks from now
            string now = DateTime.Now.ToString("yyyy-MM-dd");
            string twoWeeksFromNow = DateTime.Now.AddDays(14).ToString("yyyy-MM-dd");

            //Open connection first
            connection.Open();

            //Query string
            string commandString = "SELECT tblAssignment.assignName, tblAssignment.deadline " +
                                   "FROM tblAssignment " +
                                   "WHERE tblAssignment.deadline BETWEEN '" + now + "' AND '" + twoWeeksFromNow + "';";

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
                lb.Items.Add("Assignment Name: " + dataReader["assignName"]);
                lb.Items.Add("Due On: " + dataReader["deadline"]);
                lb.Items.Add("\n");
            }

            connection.Close();
        }

        public void AverageGrades()
        {
            clearLB(lb);

            //Get date that is two weeks from now
            string now = DateTime.Now.ToString("yyyy-mm-dd");
            string twoWeeksFromNow = DateTime.Now.AddDays(14).ToString("yyyy-mm-dd");

            //Open connection first
            connection.Open();

            //Query string
            string commandString = "SELECT tblPaper.paperName, CAST(AVG(tblAssignment.score) AS numeric(36,2)) AS scoreAvg " +
                                   "FROM tblAssignment JOIN tblPaper ON tblAssignment.paperID=tblPaper.paperID " + 
                                   "GROUP BY tblPaper.paperName;";

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
                lb.Items.Add("Paper Name: " + dataReader["paperName"]);
                lb.Items.Add("Average Score: " + dataReader["scoreAvg"]);
                lb.Items.Add("\n");
            }

            connection.Close();
        }
    }
}
