using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAndPopulateDB
{
    //Database manager class
    class DBM
    {
        //Attr here
        SqlConnection connection;

        //Ctor
        public DBM()
        {
            //blank ctor
        }

        //Begin Methods

        //1) Establish connection to db
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

        //2) Check if tables already exist before making them, if so - drop.
        private void dropTable(string tblName)
        {
            String xDropCommand = "IF OBJECT_ID('" + tblName + "') IS NOT NULL DROP TABLE" + tblName + ";";

            //Call nonqueryexecute, feeding it a command STRING.
            executeNonQuery(xDropCommand);
        }

        //X) Realised midway through writing drop that i'll need a handler for nonQueries.
        private void executeNonQuery(string command)
        {
            SqlCommand nonQuery = new SqlCommand(command, connection);

            //Open connection
            connection.Open();

            //Execute non query
            nonQuery.ExecuteNonQuery();

            //Close connection
            connection.Close();
        }

        //3) Create the tables for the database. Should parametise this, but I want to keep it easy for now.
        private void makeTables()
        {
            //Before creating, try deleting.
            dropTable("tblLecturer");
            dropTable("tblPaper");
            dropTable("tblAssignment");

            //Begin writing create strings
            String createLecturers = "CREATE TABLE tblLecturer(" +
                                        "lecID int IDENTITY, " +
                                        "firstName VARCHAR(30) NOT NULL, " +
                                        "lastName VARCHAR(30) NOT NULL, " +
                                        "email VARCHAR(100) NOT NULL, " +
                                        "PRIMARY KEY(lecID));";
        }
    }
}
