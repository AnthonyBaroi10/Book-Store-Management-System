using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
//using Oracle.ManagedDataAccess.Client;




namespace TinyLibraryBook_Store
{
    internal class Connection
    {
        public OracleConnection thisConnection = new OracleConnection("Data Source=XE;User ID=LibraryBookStore;Password=system;");
    }
}
