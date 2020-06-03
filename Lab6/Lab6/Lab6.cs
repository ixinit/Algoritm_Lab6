using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Lab6 : Form
    {
        private static double first, second;
        public Lab6()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            double result;
            if ((Double.TryParse(tbFirst.Text, out first)) && (Double.TryParse(tbSecond.Text, out second)))
            {
                result = 1 / (1 / first + 1 / second);
                lblResult.Text = "Заполнят вместе за:" + result;
            }
            else
                lblResult.Text = "Ошибка";
        }
    }
}
