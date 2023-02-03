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
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TypeOfMoney.Text.Length == 0 || TypeOfMoney2.Text.Length == 0 || InputValue.Text.Length == 0)
            {
                return;
            }

            else
            {
                Operation operation = new Operation();
                Result.Text = operation.Convertation(Convert.ToDouble(InputValue.Text), TypeOfMoney.Text, TypeOfMoney2.Text);
            }
            
        }
    }
}
