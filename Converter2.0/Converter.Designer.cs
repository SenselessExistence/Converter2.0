namespace Converter2._0
{
    partial class Converter
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
            this.TypeOfMoney = new System.Windows.Forms.ComboBox();
            this.TypeOfMoney2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputValue = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TypeOfMoney
            // 
            this.TypeOfMoney.FormattingEnabled = true;
            this.TypeOfMoney.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "UAH"});
            this.TypeOfMoney.Location = new System.Drawing.Point(98, 35);
            this.TypeOfMoney.Name = "TypeOfMoney";
            this.TypeOfMoney.Size = new System.Drawing.Size(121, 23);
            this.TypeOfMoney.TabIndex = 0;
            // 
            // TypeOfMoney2
            // 
            this.TypeOfMoney2.FormattingEnabled = true;
            this.TypeOfMoney2.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "UAH"});
            this.TypeOfMoney2.Location = new System.Drawing.Point(277, 35);
            this.TypeOfMoney2.Name = "TypeOfMoney2";
            this.TypeOfMoney2.Size = new System.Drawing.Size(121, 23);
            this.TypeOfMoney2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Из";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "В";
            // 
            // InputValue
            // 
            this.InputValue.Location = new System.Drawing.Point(107, 135);
            this.InputValue.Name = "InputValue";
            this.InputValue.Size = new System.Drawing.Size(100, 23);
            this.InputValue.TabIndex = 4;
            // 
            // Result
            // 
            this.Result.Enabled = false;
            this.Result.Location = new System.Drawing.Point(298, 135);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 23);
            this.Result.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Конвертировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите сумму";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Результат";
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 288);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.InputValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeOfMoney2);
            this.Controls.Add(this.TypeOfMoney);
            this.Name = "Converter";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeOfMoney;
        private System.Windows.Forms.ComboBox TypeOfMoney2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputValue;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}