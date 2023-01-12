namespace ProgramsSerial
{
    partial class GetActivationCodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPreCode = new System.Windows.Forms.TextBox();
            this.txtACVCode = new System.Windows.Forms.TextBox();
            this.btnGetActivationCode = new System.Windows.Forms.Button();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPreCode
            // 
            this.txtPreCode.BackColor = System.Drawing.Color.White;
            this.txtPreCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPreCode.Location = new System.Drawing.Point(133, 12);
            this.txtPreCode.Name = "txtPreCode";
            this.txtPreCode.Size = new System.Drawing.Size(275, 30);
            this.txtPreCode.TabIndex = 16;
            this.txtPreCode.TextChanged += new System.EventHandler(this.txtPreCode_TextChanged);
            // 
            // txtACVCode
            // 
            this.txtACVCode.BackColor = System.Drawing.Color.White;
            this.txtACVCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtACVCode.Location = new System.Drawing.Point(12, 158);
            this.txtACVCode.Name = "txtACVCode";
            this.txtACVCode.ReadOnly = true;
            this.txtACVCode.Size = new System.Drawing.Size(520, 30);
            this.txtACVCode.TabIndex = 17;
            // 
            // btnGetActivationCode
            // 
            this.btnGetActivationCode.Location = new System.Drawing.Point(205, 85);
            this.btnGetActivationCode.Name = "btnGetActivationCode";
            this.btnGetActivationCode.Size = new System.Drawing.Size(130, 49);
            this.btnGetActivationCode.TabIndex = 31;
            this.btnGetActivationCode.Text = "Get Activation Code";
            this.btnGetActivationCode.UseVisualStyleBackColor = true;
            this.btnGetActivationCode.Click += new System.EventHandler(this.btnGetActivationCode_Click);
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.White;
            this.txtMobile.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMobile.Location = new System.Drawing.Point(133, 49);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(275, 30);
            this.txtMobile.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "System Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mobile Number";
            // 
            // GetActivationCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.btnGetActivationCode);
            this.Controls.Add(this.txtACVCode);
            this.Controls.Add(this.txtPreCode);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetActivationCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetActivationCodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPreCode;
        private System.Windows.Forms.TextBox txtACVCode;
        private System.Windows.Forms.Button btnGetActivationCode;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}