namespace Wage_Calculator
{
    partial class wageCalculator
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
            this.grpEmployeeData = new System.Windows.Forms.GroupBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtRaise = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpPayPeriod = new System.Windows.Forms.GroupBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.grpEmployeeData.SuspendLayout();
            this.grpPayPeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // grpEmployeeData
            // 
            this.grpEmployeeData.Controls.Add(this.txtHours);
            this.grpEmployeeData.Controls.Add(this.txtRate);
            this.grpEmployeeData.Controls.Add(this.txtRaise);
            this.grpEmployeeData.Controls.Add(this.label5);
            this.grpEmployeeData.Controls.Add(this.label4);
            this.grpEmployeeData.Controls.Add(this.label3);
            this.grpEmployeeData.Controls.Add(this.txtName);
            this.grpEmployeeData.Controls.Add(this.label2);
            this.grpEmployeeData.Location = new System.Drawing.Point(61, 87);
            this.grpEmployeeData.Name = "grpEmployeeData";
            this.grpEmployeeData.Size = new System.Drawing.Size(605, 272);
            this.grpEmployeeData.TabIndex = 2;
            this.grpEmployeeData.TabStop = false;
            this.grpEmployeeData.Text = "Employee Data";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(213, 89);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(176, 22);
            this.txtHours.TabIndex = 3;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(213, 145);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(176, 22);
            this.txtRate.TabIndex = 5;
            // 
            // txtRaise
            // 
            this.txtRaise.Location = new System.Drawing.Point(213, 197);
            this.txtRaise.Name = "txtRaise";
            this.txtRaise.Size = new System.Drawing.Size(176, 22);
            this.txtRaise.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Raise %:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(213, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 22);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(545, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpPayPeriod
            // 
            this.grpPayPeriod.Controls.Add(this.txtEndDate);
            this.grpPayPeriod.Controls.Add(this.txtStartDate);
            this.grpPayPeriod.Controls.Add(this.label7);
            this.grpPayPeriod.Controls.Add(this.label6);
            this.grpPayPeriod.Location = new System.Drawing.Point(61, 394);
            this.grpPayPeriod.Name = "grpPayPeriod";
            this.grpPayPeriod.Size = new System.Drawing.Size(605, 148);
            this.grpPayPeriod.TabIndex = 3;
            this.grpPayPeriod.TabStop = false;
            this.grpPayPeriod.Text = "Pay Period";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(213, 88);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(176, 22);
            this.txtEndDate.TabIndex = 3;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(213, 37);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(176, 22);
            this.txtStartDate.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "End Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Start Date";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(104, 765);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(117, 42);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(313, 765);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 42);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(503, 765);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 42);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Location = new System.Drawing.Point(61, 588);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(605, 122);
            this.lblResults.TabIndex = 4;
            // 
            // wageCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(713, 870);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpPayPeriod);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grpEmployeeData);
            this.Controls.Add(this.label1);
            this.Name = "wageCalculator";
            this.Text = "Wage Calculator";
            this.Load += new System.EventHandler(this.wageCalculator_Load);
            this.grpEmployeeData.ResumeLayout(false);
            this.grpEmployeeData.PerformLayout();
            this.grpPayPeriod.ResumeLayout(false);
            this.grpPayPeriod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpEmployeeData;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtRaise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpPayPeriod;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResults;
    }
}

