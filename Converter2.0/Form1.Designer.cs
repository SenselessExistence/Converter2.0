namespace Converter2._0
{
    partial class StartPoint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPoint));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.AuthorizationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WelcomeLabel.Location = new System.Drawing.Point(155, 56);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(115, 15);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Добро пожаловать!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationButton.Location = new System.Drawing.Point(10, 124);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(140, 52);
            this.RegistrationButton.TabIndex = 1;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // AuthorizationButton
            // 
            this.AuthorizationButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AuthorizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthorizationButton.Location = new System.Drawing.Point(271, 124);
            this.AuthorizationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AuthorizationButton.Name = "AuthorizationButton";
            this.AuthorizationButton.Size = new System.Drawing.Size(140, 52);
            this.AuthorizationButton.TabIndex = 2;
            this.AuthorizationButton.Text = "Авторизироваться";
            this.AuthorizationButton.UseVisualStyleBackColor = false;
            this.AuthorizationButton.Click += new System.EventHandler(this.AuthorizationButton_Click);
            // 
            // StartPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(422, 190);
            this.Controls.Add(this.AuthorizationButton);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button AuthorizationButton;
    }
}
