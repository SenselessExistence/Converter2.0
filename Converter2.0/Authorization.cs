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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            if(LoginTextBox.Text.Length == 0 || PasswordTextBox.Text.Length == 0)
            {
                EventDialog eventDialog = new EventDialog("Неверный логин или пароль!");
                eventDialog.ShowDialog();
            }
        }
    }
}
