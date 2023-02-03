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
    public partial class StartPoint : Form
    {
        public StartPoint()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
        }
    }
}
