namespace ISACA_Keygen
{
  partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtInstallCode = new System.Windows.Forms.TextBox();
            this.GenSerial = new System.Windows.Forms.Button();
            this.txtHardwareCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxExam = new System.Windows.Forms.ComboBox();
            this.GenActivation = new System.Windows.Forms.Button();
            this.txtActivationCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInstallCode
            // 
            this.txtInstallCode.Location = new System.Drawing.Point(107, 57);
            this.txtInstallCode.Name = "txtInstallCode";
            this.txtInstallCode.ReadOnly = true;
            this.txtInstallCode.Size = new System.Drawing.Size(171, 20);
            this.txtInstallCode.TabIndex = 0;
            // 
            // GenSerial
            // 
            this.GenSerial.Location = new System.Drawing.Point(107, 83);
            this.GenSerial.Name = "GenSerial";
            this.GenSerial.Size = new System.Drawing.Size(171, 25);
            this.GenSerial.TabIndex = 1;
            this.GenSerial.Text = "Generate Install Code";
            this.GenSerial.UseVisualStyleBackColor = true;
            this.GenSerial.Click += new System.EventHandler(this.GenSerial_Click);
            // 
            // txtHardwareCode
            // 
            this.txtHardwareCode.Location = new System.Drawing.Point(107, 114);
            this.txtHardwareCode.Name = "txtHardwareCode";
            this.txtHardwareCode.Size = new System.Drawing.Size(171, 20);
            this.txtHardwareCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Install Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hardware Code :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboxExam);
            this.groupBox1.Controls.Add(this.GenActivation);
            this.groupBox1.Controls.Add(this.txtActivationCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.GenSerial);
            this.groupBox1.Controls.Add(this.txtInstallCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHardwareCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 236);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coded by sea1731";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Choose \"Manually via the Web\" Activation Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choose Exam :";
            // 
            // cboxExam
            // 
            this.cboxExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxExam.Items.AddRange(new object[] {
            "CISA 2013",
            "CISM 2013",
            "CISA 2014",
            "CISM 2014",
            "CISA 2015",
            "CISM 2015",
            "CISA 2016",
            "CISM 2016"});
            this.cboxExam.Location = new System.Drawing.Point(107, 30);
            this.cboxExam.Name = "cboxExam";
            this.cboxExam.Size = new System.Drawing.Size(171, 21);
            this.cboxExam.TabIndex = 9;
            // 
            // GenActivation
            // 
            this.GenActivation.Location = new System.Drawing.Point(107, 166);
            this.GenActivation.Name = "GenActivation";
            this.GenActivation.Size = new System.Drawing.Size(171, 25);
            this.GenActivation.TabIndex = 6;
            this.GenActivation.Text = "Generate Activation Code";
            this.GenActivation.UseVisualStyleBackColor = true;
            this.GenActivation.Click += new System.EventHandler(this.GenActivation_Click);
            // 
            // txtActivationCode
            // 
            this.txtActivationCode.Location = new System.Drawing.Point(107, 140);
            this.txtActivationCode.Name = "txtActivationCode";
            this.txtActivationCode.Size = new System.Drawing.Size(171, 20);
            this.txtActivationCode.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Activation Code :";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 236);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "ISACA 2016 - Keygen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox txtInstallCode;
    private System.Windows.Forms.Button GenSerial;
    private System.Windows.Forms.TextBox txtHardwareCode;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button GenActivation;
    private System.Windows.Forms.TextBox txtActivationCode;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cboxExam;
    private System.Windows.Forms.Label label5;
  }
}

