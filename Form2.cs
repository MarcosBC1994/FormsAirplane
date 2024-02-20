using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private Empresa empresa2 = new Empresa();

        public Form2(Empresa empresa)
        {
            InitializeComponent();
            empresa2.copyList(empresa);
        }

        private void Form2comercial_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(empresa2);
            this.Hide();
            form3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
