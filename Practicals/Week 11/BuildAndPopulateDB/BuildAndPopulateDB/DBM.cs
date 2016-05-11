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
            SqlConnection connection = new SqlConnection();

            //Very fussy connection string
            connection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" +            //Data Source
                                          "Initial Catalog = IN700001_201601_KEIGDL1;" +    //Initial Catalog
                                          "User ID = keigdl1;" +                            //BitDev Username
                                          "Password = " + StaticInfo.pw + ";";              //Shh! It's a gosh darn plain text password!

            //Open a connection to the database
            connection.Open();
        }
    }
}
