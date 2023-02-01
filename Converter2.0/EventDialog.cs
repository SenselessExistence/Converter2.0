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
    public partial class EventDialog : Form
    {
        public EventDialog(string text)
        {
            InitializeComponent();
            this.label1.Text = text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (this.label1.Text == "Успешная регистрация!")
            {
                Authorization authorization = new Authorization();
                authorization.ShowDialog();
            }
        }
    }
}
