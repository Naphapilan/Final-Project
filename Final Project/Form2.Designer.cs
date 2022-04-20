namespace Final_Project
{
    partial class Form2
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
            this.rdIncome = new System.Windows.Forms.RadioButton();
            this.rdExpenses = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdIncome
            // 
            this.rdIncome.AutoSize = true;
            this.rdIncome.BackColor = System.Drawing.Color.Silver;
            this.rdIncome.Location = new System.Drawing.Point(100, 73);
            this.rdIncome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdIncome.Name = "rdIncome";
            this.rdIncome.Size = new System.Drawing.Size(111, 46);
            this.rdIncome.TabIndex = 0;
            this.rdIncome.TabStop = true;
            this.rdIncome.Text = "รายรับ";
            this.rdIncome.UseVisualStyleBackColor = false;
            // 
            // rdExpenses
            // 
            this.rdExpenses.AutoSize = true;
            this.rdExpenses.Location = new System.Drawing.Point(100, 150);
            this.rdExpenses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdExpenses.Name = "rdExpenses";
            this.rdExpenses.Size = new System.Drawing.Size(123, 46);
            this.rdExpenses.TabIndex = 1;
            this.rdExpenses.TabStop = true;
            this.rdExpenses.Text = "รายจ่าย";
            this.rdExpenses.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.rdExpenses);
            this.groupBox1.Controls.Add(this.rdIncome);
            this.groupBox1.Font = new System.Drawing.Font("TH Kodchasal", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(91, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(360, 252);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ประเภท";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TH Kodchasal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 70);
            this.label1.TabIndex = 3;
            this.label1.Text = "Income And Expenses";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Lime;
            this.buttonOK.Font = new System.Drawing.Font("TH Kodchasal", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.Location = new System.Drawing.Point(283, 371);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(134, 57);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "ยืนยัน";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("TH Kodchasal", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(141, 371);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(134, 57);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "ออก";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(520, 457);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("TH Kodchasal", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdIncome;
        private RadioButton rdExpenses;
        private GroupBox groupBox1;
        private Label label1;
        private Button buttonOK;
        private Button buttonExit;
    }
}