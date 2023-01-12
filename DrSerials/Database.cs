using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PA.SystemValidation
{
    public static class Database
    {
        public static OleDbConnection Connection = new OleDbConnection(string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}\\Data\\myDB.mdb", Application.StartupPath));


        public static int GetCount(string tableName, string where)
        {
            OleDbCommand command = new OleDbCommand("", Database.Connection);

            Database.Connection.Open();
            try
            {
                string sql = "Select Count(*) From " + tableName;

                if (where != null && where != string.Empty)
                    sql += " Where " + where;

                command.CommandText = sql;
                return (int)command.ExecuteScalar();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        public static object GetFirstValue(string tableName, string fieldName, string where)
        {
            OleDbCommand command = new OleDbCommand("", Database.Connection);

            Database.Connection.Open();
            try
            {
                string sql = "Select " + fieldName + " From " + tableName;

                if (where != null && where != string.Empty)
                    sql += " Where " + where;

                command.CommandText = sql;
                return command.ExecuteScalar();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        public static string SafeGetString(OleDbDataReader reader, string fName)
        {
            int fid = reader.GetOrdinal(fName);

            return reader.IsDBNull(fid) ? "" : reader.GetString(fid);
        }

        public static string SafeGetString(OleDbDataReader reader, string fName, string defVal)
        {
            int fid = reader.GetOrdinal(fName);

            return reader.IsDBNull(fid) ? defVal : reader.GetString(fid);
        }

        public static Int32 SafeGetInt32(OleDbDataReader reader, string fName)
        {
            int fid = reader.GetOrdinal(fName);

            return reader.IsDBNull(fid) ? 0 : reader.GetInt32(fid);
        }

        public static Int32 SafeGetInt32(OleDbDataReader reader, string fName, int defVal)
        {
            int fid = reader.GetOrdinal(fName);

            return reader.IsDBNull(fid) ? defVal : reader.GetInt32(fid);
        }

        public static bool SafeGetBool(OleDbDataReader reader, string fName)
        {
            int fid = reader.GetOrdinal(fName);

            return reader.IsDBNull(fid) ? false : reader.GetBoolean(fid);
        }

        public static DateTime? SafeGetDateTime(OleDbDataReader reader, string fName)
        {
            int fid = reader.GetOrdinal(fName);

            return reader.IsDBNull(fid) ? (DateTime?)null : (DateTime?)reader.GetDateTime(fid);
        }
    }
}
