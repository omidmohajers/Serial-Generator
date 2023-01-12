namespace ProgramsSerial
{
    partial class MainForm
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
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnGenerateSerial = new System.Windows.Forms.Button();
            this.txtSystemCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRC = new System.Windows.Forms.TextBox();
            this.txtRB = new System.Windows.Forms.TextBox();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtRSerial = new System.Windows.Forms.TextBox();
            this.txtPreACVCode = new System.Windows.Forms.TextBox();
            this.txtACVCode = new System.Windows.Forms.TextBox();
            this.txtRSystemCode = new System.Windows.Forms.TextBox();
            this.btnSaveSerial = new System.Windows.Forms.Button();
            this.btnCancelSerial = new System.Windows.Forms.Button();
            this.btnGetActivationCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSerial
            // 
            this.txtSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSerial.Location = new System.Drawing.Point(12, 48);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(225, 30);
            this.txtSerial.TabIndex = 4;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtA.Location = new System.Drawing.Point(12, 12);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(52, 30);
            this.txtA.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtB.Location = new System.Drawing.Point(70, 12);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(52, 30);
            this.txtB.TabIndex = 7;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtC.Location = new System.Drawing.Point(128, 12);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(52, 30);
            this.txtC.TabIndex = 8;
            // 
            // btnGenerateSerial
            // 
            this.btnGenerateSerial.Location = new System.Drawing.Point(468, 12);
            this.btnGenerateSerial.Name = "btnGenerateSerial";
            this.btnGenerateSerial.Size = new System.Drawing.Size(130, 49);
            this.btnGenerateSerial.TabIndex = 14;
            this.btnGenerateSerial.Text = "Generate Serial";
            this.btnGenerateSerial.UseVisualStyleBackColor = true;
            this.btnGenerateSerial.Click += new System.EventHandler(this.btnGenerateSerial_Click);
            // 
            // txtSystemCode
            // 
            this.txtSystemCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSystemCode.Location = new System.Drawing.Point(128, 183);
            this.txtSystemCode.Name = "txtSystemCode";
            this.txtSystemCode.ReadOnly = true;
            this.txtSystemCode.Size = new System.Drawing.Size(275, 30);
            this.txtSystemCode.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "System Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pre Activation Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Reverse System Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Activation Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Reverse Serial:";
            // 
            // txtRC
            // 
            this.txtRC.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRC.Location = new System.Drawing.Point(244, 304);
            this.txtRC.Name = "txtRC";
            this.txtRC.ReadOnly = true;
            this.txtRC.Size = new System.Drawing.Size(52, 30);
            this.txtRC.TabIndex = 24;
            // 
            // txtRB
            // 
            this.txtRB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRB.Location = new System.Drawing.Point(186, 304);
            this.txtRB.Name = "txtRB";
            this.txtRB.ReadOnly = true;
            this.txtRB.Size = new System.Drawing.Size(52, 30);
            this.txtRB.TabIndex = 23;
            // 
            // txtRA
            // 
            this.txtRA.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRA.Location = new System.Drawing.Point(128, 304);
            this.txtRA.Name = "txtRA";
            this.txtRA.ReadOnly = true;
            this.txtRA.Size = new System.Drawing.Size(52, 30);
            this.txtRA.TabIndex = 22;
            // 
            // txtRSerial
            // 
            this.txtRSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRSerial.Location = new System.Drawing.Point(128, 340);
            this.txtRSerial.Name = "txtRSerial";
            this.txtRSerial.ReadOnly = true;
            this.txtRSerial.Size = new System.Drawing.Size(275, 30);
            this.txtRSerial.TabIndex = 21;
            // 
            // txtPreACVCode
            // 
            this.txtPreACVCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPreACVCode.Location = new System.Drawing.Point(128, 219);
            this.txtPreACVCode.Name = "txtPreACVCode";
            this.txtPreACVCode.ReadOnly = true;
            this.txtPreACVCode.Size = new System.Drawing.Size(275, 30);
            this.txtPreACVCode.TabIndex = 25;
            // 
            // txtACVCode
            // 
            this.txtACVCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtACVCode.Location = new System.Drawing.Point(128, 255);
            this.txtACVCode.Name = "txtACVCode";
            this.txtACVCode.ReadOnly = true;
            this.txtACVCode.Size = new System.Drawing.Size(275, 30);
            this.txtACVCode.TabIndex = 26;
            // 
            // txtRSystemCode
            // 
            this.txtRSystemCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRSystemCode.Location = new System.Drawing.Point(128, 376);
            this.txtRSystemCode.Name = "txtRSystemCode";
            this.txtRSystemCode.ReadOnly = true;
            this.txtRSystemCode.Size = new System.Drawing.Size(275, 30);
            this.txtRSystemCode.TabIndex = 27;
            // 
            // btnSaveSerial
            // 
            this.btnSaveSerial.Location = new System.Drawing.Point(468, 67);
            this.btnSaveSerial.Name = "btnSaveSerial";
            this.btnSaveSerial.Size = new System.Drawing.Size(130, 49);
            this.btnSaveSerial.TabIndex = 28;
            this.btnSaveSerial.Text = "Save Serial";
            this.btnSaveSerial.UseVisualStyleBackColor = true;
            this.btnSaveSerial.Click += new System.EventHandler(this.btnSaveSerial_Click);
            // 
            // btnCancelSerial
            // 
            this.btnCancelSerial.Location = new System.Drawing.Point(468, 122);
            this.btnCancelSerial.Name = "btnCancelSerial";
            this.btnCancelSerial.Size = new System.Drawing.Size(130, 49);
            this.btnCancelSerial.TabIndex = 29;
            this.btnCancelSerial.Text = "Cancel Serial";
            this.btnCancelSerial.UseVisualStyleBackColor = true;
            this.btnCancelSerial.Click += new System.EventHandler(this.btnCancelSerial_Click);
            // 
            // btnGetActivationCode
            // 
            this.btnGetActivationCode.Location = new System.Drawing.Point(468, 351);
            this.btnGetActivationCode.Name = "btnGetActivationCode";
            this.btnGetActivationCode.Size = new System.Drawing.Size(130, 49);
            this.btnGetActivationCode.TabIndex = 30;
            this.btnGetActivationCode.Text = "Get Activation Code";
            this.btnGetActivationCode.UseVisualStyleBackColor = true;
            this.btnGetActivationCode.Click += new System.EventHandler(this.btnGetActivationCode_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 418);
            this.Controls.Add(this.btnGetActivationCode);
            this.Controls.Add(this.btnCancelSerial);
            this.Controls.Add(this.btnSaveSerial);
            this.Controls.Add(this.txtRSystemCode);
            this.Controls.Add(this.txtACVCode);
            this.Controls.Add(this.txtPreACVCode);
            this.Controls.Add(this.txtRC);
            this.Controls.Add(this.txtRB);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.txtRSerial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSystemCode);
            this.Controls.Add(this.btnGenerateSerial);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtSerial);
            this.Name = "MainForm";
            this.Text = "Doctor Serials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnGenerateSerial;
        private System.Windows.Forms.TextBox txtSystemCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRC;
        private System.Windows.Forms.TextBox txtRB;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.TextBox txtRSerial;
        private System.Windows.Forms.TextBox txtPreACVCode;
        private System.Windows.Forms.TextBox txtACVCode;
        private System.Windows.Forms.TextBox txtRSystemCode;
        private System.Windows.Forms.Button btnSaveSerial;
        private System.Windows.Forms.Button btnCancelSerial;
        private System.Windows.Forms.Button btnGetActivationCode;
    }
}

