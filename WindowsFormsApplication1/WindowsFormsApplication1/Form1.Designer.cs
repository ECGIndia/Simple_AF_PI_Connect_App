namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPIServer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTagName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTagValue = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtAFServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAFStatus = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtAttribute = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAttributeValue = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txtAFDB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.txtElementName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDBStatus = new System.Windows.Forms.Label();
            this.lstChildElements = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            this.txtElementbyPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstAttributes = new System.Windows.Forms.ListBox();
            this.lstAllChildElements = new System.Windows.Forms.ListBox();
            this.button9 = new System.Windows.Forms.Button();
            this.txtElementName_all = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PI Server Name:";
            // 
            // txtPIServer
            // 
            this.txtPIServer.Location = new System.Drawing.Point(132, 19);
            this.txtPIServer.Name = "txtPIServer";
            this.txtPIServer.Size = new System.Drawing.Size(170, 20);
            this.txtPIServer.TabIndex = 1;
            this.txtPIServer.Text = "SERVER2008";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect to PI Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tag Name : ";
            // 
            // txtTagName
            // 
            this.txtTagName.Location = new System.Drawing.Point(132, 105);
            this.txtTagName.Name = "txtTagName";
            this.txtTagName.Size = new System.Drawing.Size(170, 20);
            this.txtTagName.TabIndex = 4;
            this.txtTagName.Text = "sinusoid";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clcik for Tag Value";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTagValue
            // 
            this.txtTagValue.Location = new System.Drawing.Point(28, 167);
            this.txtTagValue.Name = "txtTagValue";
            this.txtTagValue.Size = new System.Drawing.Size(274, 20);
            this.txtTagValue.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 526);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Exit Applicatoin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(314, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Connect to AF Server";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtAFServer
            // 
            this.txtAFServer.Location = new System.Drawing.Point(405, 20);
            this.txtAFServer.Name = "txtAFServer";
            this.txtAFServer.Size = new System.Drawing.Size(170, 20);
            this.txtAFServer.TabIndex = 9;
            this.txtAFServer.Text = "ECGPISERVER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "AF Server Name:";
            // 
            // lblAFStatus
            // 
            this.lblAFStatus.AutoSize = true;
            this.lblAFStatus.Location = new System.Drawing.Point(361, 80);
            this.lblAFStatus.Name = "lblAFStatus";
            this.lblAFStatus.Size = new System.Drawing.Size(0, 13);
            this.lblAFStatus.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(314, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "PIPoint of Attribute";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtAttribute
            // 
            this.txtAttribute.Location = new System.Drawing.Point(405, 193);
            this.txtAttribute.Name = "txtAttribute";
            this.txtAttribute.Size = new System.Drawing.Size(170, 20);
            this.txtAttribute.TabIndex = 13;
            this.txtAttribute.Text = "\\\\ECGPISERVER\\Portal_DB\\Garima\\Generation\\Wind|Asset Availability";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "AttributeName : ";
            // 
            // txtAttributeValue
            // 
            this.txtAttributeValue.Location = new System.Drawing.Point(314, 263);
            this.txtAttributeValue.Name = "txtAttributeValue";
            this.txtAttributeValue.Size = new System.Drawing.Size(274, 20);
            this.txtAttributeValue.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(314, 138);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Connect to Database";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtAFDB
            // 
            this.txtAFDB.Location = new System.Drawing.Point(418, 106);
            this.txtAFDB.Name = "txtAFDB";
            this.txtAFDB.Size = new System.Drawing.Size(170, 20);
            this.txtAFDB.TabIndex = 17;
            this.txtAFDB.Text = "Portal_DB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "AF Database : ";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(314, 339);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = "Immediate Child elements";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtElementName
            // 
            this.txtElementName.Location = new System.Drawing.Point(405, 302);
            this.txtElementName.Name = "txtElementName";
            this.txtElementName.Size = new System.Drawing.Size(170, 20);
            this.txtElementName.TabIndex = 20;
            this.txtElementName.Text = "France";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "ElementName : ";
            // 
            // lblDBStatus
            // 
            this.lblDBStatus.AutoSize = true;
            this.lblDBStatus.Location = new System.Drawing.Point(361, 170);
            this.lblDBStatus.Name = "lblDBStatus";
            this.lblDBStatus.Size = new System.Drawing.Size(0, 13);
            this.lblDBStatus.TabIndex = 22;
            // 
            // lstChildElements
            // 
            this.lstChildElements.FormattingEnabled = true;
            this.lstChildElements.Location = new System.Drawing.Point(314, 378);
            this.lstChildElements.Name = "lstChildElements";
            this.lstChildElements.Size = new System.Drawing.Size(261, 82);
            this.lstChildElements.TabIndex = 23;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(28, 232);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 23);
            this.button8.TabIndex = 26;
            this.button8.Text = "Attributes of Element";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtElementbyPath
            // 
            this.txtElementbyPath.Location = new System.Drawing.Point(119, 198);
            this.txtElementbyPath.Name = "txtElementbyPath";
            this.txtElementbyPath.Size = new System.Drawing.Size(170, 20);
            this.txtElementbyPath.TabIndex = 25;
            this.txtElementbyPath.Text = "\\\\ECGPISERVER\\Portal_DB\\Garima\\Generation\\Wind";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "ElementPath : ";
            // 
            // lstAttributes
            // 
            this.lstAttributes.FormattingEnabled = true;
            this.lstAttributes.Location = new System.Drawing.Point(28, 270);
            this.lstAttributes.Name = "lstAttributes";
            this.lstAttributes.Size = new System.Drawing.Size(261, 82);
            this.lstAttributes.TabIndex = 27;
            // 
            // lstAllChildElements
            // 
            this.lstAllChildElements.FormattingEnabled = true;
            this.lstAllChildElements.Location = new System.Drawing.Point(28, 435);
            this.lstAllChildElements.Name = "lstAllChildElements";
            this.lstAllChildElements.Size = new System.Drawing.Size(261, 82);
            this.lstAllChildElements.TabIndex = 31;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(28, 396);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(136, 23);
            this.button9.TabIndex = 30;
            this.button9.Text = "All Child elements";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // txtElementName_all
            // 
            this.txtElementName_all.Location = new System.Drawing.Point(119, 359);
            this.txtElementName_all.Name = "txtElementName_all";
            this.txtElementName_all.Size = new System.Drawing.Size(170, 20);
            this.txtElementName_all.TabIndex = 29;
            this.txtElementName_all.Text = "Wind";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "ElementName : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 557);
            this.Controls.Add(this.lstAllChildElements);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.txtElementName_all);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstAttributes);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txtElementbyPath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstChildElements);
            this.Controls.Add(this.lblDBStatus);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtElementName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtAFDB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAttributeValue);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtAttribute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAFStatus);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtAFServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtTagValue);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTagName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPIServer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPIServer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTagName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTagValue;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtAFServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAFStatus;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtAttribute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAttributeValue;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtAFDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtElementName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDBStatus;
        private System.Windows.Forms.ListBox lstChildElements;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtElementbyPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstAttributes;
        private System.Windows.Forms.ListBox lstAllChildElements;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txtElementName_all;
        private System.Windows.Forms.Label label8;
    }
}

