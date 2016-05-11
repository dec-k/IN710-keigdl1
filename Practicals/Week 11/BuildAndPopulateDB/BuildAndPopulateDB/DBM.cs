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

            //Lecture table create
            String createLecturers = "CREATE TABLE tblLecturer(" +
                                        "lecID int IDENTITY, " +
                                        "firstName VARCHAR(30) NOT NULL, " +
                                        "lastName VARCHAR(30) NOT NULL, " +
                                        "email VARCHAR(100) NOT NULL, " +
                                        "PRIMARY KEY(lecID));";

            //Paper table create
            String createPapers = "CREATE TABLE tblPaper(" +
                                        "paperID int IDENTITY, " +
                                        "lecID int NOT NULL, " +
                                        "paperName VARCHAR(100) NOT NULL, " +
                                        "PRIMARY KEY(paperID), " +
                                        "FOREIGN KEY(lecID) REFERENCES tblLecturer(lecID));";

            //Assign table create
            String createAssigns = "CREATE TABLE tblAssignment(" +
                                        "assignID int IDENTITY, " + //Heh, had "assID" for a while.
                                        "paperID int NOT NULL, " +
                                        "assignName VARCHAR(50), " +
                                        "deadline date NOT NULL, " +
                                        "score numeric(3) NULL, " +
                                        "PRIMARY KEY(assignID), " +
                                        "FOREIGN KEY(paperID) REFERENCES tblPaper(paperID));";

            //Execute creation queries
            executeNonQuery(createLecturers);
            executeNonQuery(createPapers);
            executeNonQuery(createAssigns);
        }

        //4) Now that we have tables (hopefully), we can add entries to them.
        private void addLecturer(String fn, String ln, String email)
        {
            string addCommand = "INSERT INTO tblLecturer VALUES('" + fn + "', '" + ln + "', '" + email + "');";

            //execute
            //Note to self: executeNonQuery handles open/closing connection to reduce duplication.
            executeNonQuery(addCommand);
        }

        private void addPaper(int li, string name)
        {
            string addCommand = "INSERT INTO tblPaper VALUES(" + li + ", '" + name + "');";

            executeNonQuery(addCommand);
        }

        private void addAssign(int pi, string n, string dl, int score)
        {
            string addCommand = "INSERT INTO tblAssignment VALUES(" + pi + ", '" + n + "', '" + dl + "', " + score + ");";

            executeNonQuery(addCommand);
        }

        //5) Now the fun part, writing seed data! :japanese_goblin:
        private void seedAll()
        {
            seedLecturer();
            seedPaper();
            seedAssignment();
        }

        private void seedLecturer()
        {
            addLecturer("Patricia", "Haden", "phaden@op.ac.nz");
            addLecturer("Crombobulous", "Michael", "rnm@op.ac.nz");
            addLecturer("Pete", "The Polyp", "sendhelp@op.ac.nz");
        }

        private void seedPaper()
        {
            addPaper(1, "Objectively Hard Systems Development");
            addPaper(2, "Introduction to Binge-Watching");
            addPaper(3, "Introduction to Stack Overflow");
            addPaper(3, "Stress Mitigation 101");
        }

        private void seedAssignment()
        {
            addAssign(1, "Grey-Scott Reaction", "2016-5-2", 82);
            addAssign(2, "Game of Thrones, a Summary", "2016-6-2", 100);
            addAssign(3, "Code Tidying", "2016-7-2", 3);
            addAssign(4, "Proper Hydration Techniques", "2016-8-2", 0);
            addAssign(2, "Critical Analysis - Barney", "2016-9-2", 44);
        }
    }
}
