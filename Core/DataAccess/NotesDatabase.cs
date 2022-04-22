using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class NotesDatabase
    {
        public static readonly string connectionString = new FbConnectionStringBuilder
        {
            Database = "notes.fdb",
            ServerType = FbServerType.Embedded,
            UserID = "SYSDBA",
            Password = "masterkey",
            ClientLibrary = "fbclient.dll"
        }.ToString();
    }
}
