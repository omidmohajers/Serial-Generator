using System;
using System.Data.OleDb;

namespace PA.SystemValidation
{
    public class Serial
    {
        private string _SerialNumber;
        private string _SystemCode;
        private string _A;
        private string _B;
        private string _C;
        private string _ACVMobile;
        private DateTime? _ACVDateTime;
        private bool _IsActivated;


        //******************************************************************************************

        public Serial(string serial)
        {
            this._SerialNumber = serial;
            this._SystemCode = "";
            this._A = "";
            this._B = "";
            this._C = "";
            this._ACVMobile = "";
            this._ACVDateTime = null;
            this._IsActivated = false;
        }

        //******************************************************************************************

        public string SerialNumber
        {
            get
            {
                return this._SerialNumber;
            }
        }

        public string SystemCode
        {
            get
            {
                return this._SystemCode;
            }
            set
            {
                this._SystemCode = value;
            }
        }

        public string A
        {
            get
            {
                return this._A;
            }
            set
            {
                this._A = value;
            }
        }

        public string B
        {
            get
            {
                return this._B;
            }
            set
            {
                this._B = value;
            }
        }

        public string C
        {
            get
            {
                return this._C;
            }
            set
            {
                this._C = value;
            }
        }

        public string ACVMobile
        {
            get
            {
                return this._ACVMobile;
            }
            set
            {
                this._ACVMobile = value;
            }
        }

        public DateTime? ACVDateTime
        {
            get
            {
                return this._ACVDateTime;
            }
            set
            {
                this._ACVDateTime = value;
            }
        }

        public bool IsActivated
        {
            get
            {
                return this._IsActivated;
            }
            set
            {
                this._IsActivated = value;
            }
        }



        //******************************************************************************************

        public static Serial Get(string serial)
        {
            string sqlText = "Select SerialNumber, SystemCode, A, B, C, ACVMobile, ACVDateTime, IsActivated FROM Serials WHERE SerialNumber = '" + serial + "'";
            OleDbCommand command = new OleDbCommand(sqlText, Database.Connection);


            Database.Connection.Open();
            try
            {
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Serial value = new Serial("");

                    value._SerialNumber = Database.SafeGetString(reader, "SerialNumber");
                    value._SystemCode = Database.SafeGetString(reader, "SystemCode");
                    value._A = Database.SafeGetString(reader, "A");
                    value._B = Database.SafeGetString(reader, "B");
                    value._C = Database.SafeGetString(reader, "C");
                    value._ACVMobile = Database.SafeGetString(reader, "ACVMobile");
                    value._ACVDateTime = Database.SafeGetDateTime(reader, "ACVDateTime");
                    value._IsActivated = Database.SafeGetBool(reader, "IsActivated");

                    return value;
                }

                if (!reader.IsClosed)
                    reader.Close();

                return null;
            }
            finally
            {
                Database.Connection.Close();
            }
        }

        public static void Insert(Serial value)
        {
            string sqlText = "INSERT INTO Serials (SerialNumber, SystemCode, A, B, C, ACVMobile, ACVDateTime, IsActivated) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

            OleDbCommand command = new OleDbCommand(sqlText, Database.Connection);


            OleDbParameter p1 = new OleDbParameter();
            OleDbParameter p2 = new OleDbParameter();
            OleDbParameter p3 = new OleDbParameter();
            OleDbParameter p4 = new OleDbParameter();
            OleDbParameter p5 = new OleDbParameter();
            OleDbParameter p6 = new OleDbParameter();
            OleDbParameter p7 = new OleDbParameter();
            OleDbParameter p8 = new OleDbParameter();

            p7.IsNullable = true;
            p7.DbType = System.Data.DbType.Date;

            p1.Value = value.SerialNumber;
            p2.Value = value.SystemCode;
            p3.Value = value.A;
            p4.Value = value.B;
            p5.Value = value.C;
            p6.Value = value.ACVMobile;
            p7.Value = value.ACVDateTime == null ? (object)DBNull.Value : (object)value.ACVDateTime;
            p8.Value = value.IsActivated;

            command.Parameters.Add(p1);
            command.Parameters.Add(p2);
            command.Parameters.Add(p3);
            command.Parameters.Add(p4);
            command.Parameters.Add(p5);
            command.Parameters.Add(p6);
            command.Parameters.Add(p7);
            command.Parameters.Add(p8);

            /* you can insert generated serials into your db structure */


            //Database.Connection.Open();
            //try
            //{
            //    command.ExecuteNonQuery();
            //}
            //finally
            //{
            //    Database.Connection.Close();
            //}
        }


        public static void Update(Serial value)
        {
            string sqlText = "UPDATE Serials SET SystemCode = ?, A = ?, B = ?, C = ?, ACVMobile = ?, ACVDateTime = ?, IsActivated = ? WHERE SerialNumber = ?";

            OleDbCommand command = new OleDbCommand(sqlText, Database.Connection);


            OleDbParameter p1 = new OleDbParameter();
            OleDbParameter p2 = new OleDbParameter();
            OleDbParameter p3 = new OleDbParameter();
            OleDbParameter p4 = new OleDbParameter();
            OleDbParameter p5 = new OleDbParameter();
            OleDbParameter p6 = new OleDbParameter();
            OleDbParameter p7 = new OleDbParameter();
            OleDbParameter p8 = new OleDbParameter();

            p6.IsNullable = true;
            p6.DbType = System.Data.DbType.Date;

            p1.Value = value.SystemCode;
            p2.Value = value.A;
            p3.Value = value.B;
            p4.Value = value.C;
            p5.Value = value.ACVMobile;
            p6.Value = value.ACVDateTime == null ? (object)DBNull.Value : (object)value.ACVDateTime;
            p7.Value = value.IsActivated;
            p8.Value = value.SerialNumber;

            command.Parameters.Add(p1);
            command.Parameters.Add(p2);
            command.Parameters.Add(p3);
            command.Parameters.Add(p4);
            command.Parameters.Add(p5);
            command.Parameters.Add(p6);
            command.Parameters.Add(p7);
            command.Parameters.Add(p8);


            Database.Connection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
    }
}
