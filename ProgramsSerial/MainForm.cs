using System;
using System.Windows.Forms;
using PA.SystemValidation;

namespace ProgramsSerial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string GenerateSerial(string A, string B, string C)
        {
            string A1, A2, B1, B2, C1, C2;

            if (A.Length != 2 || B.Length != 2 || C.Length != 2)
                throw new Exception("Invalid Params");

            int a = int.Parse(A);
            int b = int.Parse(B);
            int c = int.Parse(C);

            if (a > 63 || b > 63 || c > 63)
                throw new Exception("Invalid Params 0-63 is valid");

            a = a ^ 34;
            b = b ^ 29;
            c = c ^ 43;

            int a1 = (a / 10) ^ 1;
            int a2 = (a % 10) ^ 1;

            int b1 = (b / 10) ^ 1;
            int b2 = (b % 10) ^ 1;

            int c1 = (c / 10) ^ 1;
            int c2 = (c % 10) ^ 1;

            if (a1 > 9 || a2 > 9 || b1 > 9 || b2 > 9 || c1 > 9 || c2 > 9)
                throw new Exception("Internal error");

            A1 = a1.ToString();
            A2 = a2.ToString();
            B1 = b1.ToString();
            B2 = b2.ToString();
            C1 = c1.ToString();
            C2 = c2.ToString();

            Random r = new Random(DateTime.Now.Millisecond * DateTime.Now.Minute);

            //XXAXXAXBXCXCXBX
            string result = "";

            result += r.Next(0, 10).ToString();
            result += r.Next(0, 10).ToString();
            result += C1;
            result += r.Next(0, 10).ToString();
            result += r.Next(0, 10).ToString();
            result += r.Next(0, 10).ToString();
            result += A2;
            result += B2;
            result += r.Next(0, 10).ToString();
            result += A1;
            result += r.Next(0, 10).ToString();
            result += B1;
            result += r.Next(0, 10).ToString();
            result += r.Next(0, 10).ToString();
            result += C2;

            if (result.Length != 15)
                throw new Exception("Internal error");

            return result;
        }

        private void btnGenerateSerial_Click(object sender, EventArgs e)
        {
            int count = int.Parse(countTextBox.Text);
            for (int i = 0; i < count; i++)
            {
                try
                {
                    Serial s = null;
                    string serial = "";

                    do
                    {
                        serial = GenerateSerial(txtA.Text, txtB.Text, txtC.Text);
                        s = null;
                    } while (s != null);

                    PCS pcs = new PCS();

                    txtA.Enabled = false;
                    txtB.Enabled = false;
                    txtC.Enabled = false;

                    txtSerial.Text = serial;
                    txtSystemCode.Text = pcs.GetSystemSerial();

                    txtPreACVCode.Text = pcs.GetPreActivationCode(txtSerial.Text, txtSystemCode.Text);
                    txtACVCode.Text = pcs.GetActivationCode(txtPreACVCode.Text);

                    pcs.ParsePreActivationCode(txtPreACVCode.Text);
                    txtRSerial.Text = pcs.pSerial;
                    txtRSystemCode.Text = pcs.sSerial;

                    pcs.ParseSerial(txtRSerial.Text);
                    txtRA.Text = pcs.A.ToString();
                    txtRB.Text = pcs.B.ToString();
                    txtRC.Text = pcs.C.ToString();

                    Insert2DB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSaveSerial_Click(object sender, EventArgs e)
        {
            Insert2DB();
        }

        private void Insert2DB()
        {
            if (txtSerial.Text != string.Empty)
            {
                Serial s = new Serial(txtSerial.Text);
                s.A = txtA.Text;
                s.B = txtB.Text;
                s.C = txtC.Text;

                Serial.Insert(s);

                txtA.Enabled = true;
                txtB.Enabled = true;
                txtC.Enabled = true;
            }
        }

        private void clearData()
        {
            txtSerial.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtSystemCode.Text = "";
            txtPreACVCode.Text = "";
            txtACVCode.Text = "";
            txtRA.Text = "";
            txtRB.Text = "";
            txtRC.Text = "";
            txtRSerial.Text = "";
            txtRSystemCode.Text = "";
        }

        private void btnCancelSerial_Click(object sender, EventArgs e)
        {
            txtA.Enabled = true;
            txtB.Enabled = true;
            txtC.Enabled = true;

            clearData();
        }

        private void btnGetActivationCode_Click(object sender, EventArgs e)
        {
            GetActivationCodeForm F = new GetActivationCodeForm();
            F.ShowDialog();
        }

    }
}
