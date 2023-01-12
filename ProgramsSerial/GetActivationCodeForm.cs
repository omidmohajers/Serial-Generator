using PA.SystemValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgramsSerial
{
    public partial class GetActivationCodeForm : Form
    {
        public GetActivationCodeForm()
        {
            InitializeComponent();
        }

        private void btnGetActivationCode_Click(object sender, EventArgs e)
        {
            ProgramActivation pa =  new ProgramActivation();
            txtACVCode.Text = pa.AnswerActivationCodeRequest(txtPreCode.Text, txtMobile.Text);
        }

        private void txtPreCode_TextChanged(object sender, EventArgs e)
        {
            txtACVCode.Text = "";
        }
    }
}
