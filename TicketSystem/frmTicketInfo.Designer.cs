namespace TicketSystem
{
    partial class frmTicketInfo
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
            this.txtDefectType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDateAndTime = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Defect Type:";
            // 
            // txtDefectType
            // 
            this.txtDefectType.FormattingEnabled = true;
            this.txtDefectType.Items.AddRange(new object[] {
            "Security Defect",
            "Appearance Defect ",
            "Mechanism Defect ",
            "Station Defect ",
            "Other"});
            this.txtDefectType.Location = new System.Drawing.Point(126, 91);
            this.txtDefectType.Name = "txtDefectType";
            this.txtDefectType.Size = new System.Drawing.Size(121, 28);
            this.txtDefectType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date and Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Batch #:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Station #:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name:";
            // 
            // txtDateAndTime
            // 
            this.txtDateAndTime.Location = new System.Drawing.Point(135, 150);
            this.txtDateAndTime.Name = "txtDateAndTime";
            this.txtDateAndTime.Size = new System.Drawing.Size(280, 26);
            this.txtDateAndTime.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 26);
            this.txtName.TabIndex = 9;
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(98, 201);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(61, 26);
            this.txtBatch.TabIndex = 10;
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(98, 267);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(61, 26);
            this.txtStation.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Describe Action Taken:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Describe Problem:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 14;
            // 
            // txtProblem
            // 
            this.txtProblem.Location = new System.Drawing.Point(176, 317);
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(556, 26);
            this.txtProblem.TabIndex = 15;
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(191, 362);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(556, 26);
            this.txtAction.TabIndex = 16;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(286, 402);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(129, 36);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // frmTicketInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.txtAction);
            this.Controls.Add(this.txtProblem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.txtBatch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDateAndTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDefectType);
            this.Controls.Add(this.label1);
            this.Name = "frmTicketInfo";
            this.Text = "frmTicketInfo";
            this.Load += new System.EventHandler(this.frmTicketInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtDefectType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDateAndTime;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.Button SaveButton;
    }
}