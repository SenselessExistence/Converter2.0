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
        Dictionary<string, double> money = new Dictionary<string, double>()
        {
            {"USD", 1 },
            {"EUR", 1.08 },
            {"UAH", 0.025 }

        };
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
            double value = Convert.ToDouble(InputValue.Text);
            Result.Text = Convert.ToString(Math.Round(value * money[TypeOfMoney.Text] / money[TypeOfMoney2.Text], 2));
        }
    }
}
