using Practic_work.Class_prakt3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic_work
{
    public partial class UnitTest : Form
    {
        public UnitTest()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                var calc = new Calculation_abc(
                    Convert.ToInt32(a1.Text),
                    Convert.ToInt32(b1.Text),
                    Convert.ToInt32(c1.Text));
                res.Text = calc.D().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                var calc = new Calculation_ab(
                    Convert.ToInt32(a2.Text),
                    Convert.ToInt32(b2.Text));

                sum.Text = calc.Sum().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
