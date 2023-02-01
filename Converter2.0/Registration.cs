using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter2._0
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool access = true;

            access = LoginTextBox.Text.Length != 0 && LoginTextBox.Text.Length > 5 ? access : false;
            access = PasswordTextBox.Text.Length != 0 && PasswordTextBox.Text.Length >= 8 ? access : false;
            access = ConfirmPassTextBox.Text.Length != 0 && ConfirmPassTextBox.Text.Length >= 8 ? access : false;
            access = EmailTextBox.Text.Length != 0 && EmailTextBox.Text.Contains("@") ? access : false;

            if (access == false)
            {
                return;
            }

            UserManagment userManagment = new UserManagment();
            userManagment.RegUser(this.LoginTextBox.Text, this.PasswordTextBox.Text, this.EmailTextBox.Text);
            EventDialog eventDialog = new EventDialog("Успешная регистрация!");
            eventDialog.ShowDialog();
            this.Hide();
        }
    }
}
