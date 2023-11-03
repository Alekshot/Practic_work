using Practic_work.Class_prakt4;
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
    public partial class File : Form
    {
        public File()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArraysAB a = new ArraysAB(10);
            FileWrite f = new FileWrite();
            FileRead f2 = new FileRead();
            ShowArray show = new ShowArray();

            string patch = @"1.txt";
            string patch1 = @"2.txt";

            f2.read(patch, a);
            a.calculate();
            f.write(patch1, a);

            label3.Text = show.writeArray(a.a);
            label4.Text = show.writeArray(a.b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void File_Load(object sender, EventArgs e)
        {

        }
    }
}
