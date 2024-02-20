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
    public partial class Form7 : Form
    {
        private string date1, date2;

        public Form7(Empresa empresa)
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            DateTime dt1 = dateTimePicker1.Value.Date;
            DateTime dt2 = dateTimePicker2.Value.Date;

            // Assuming Form8 constructor accepts two strings
            Form8 f8 = new Form8(date1, date2,dt1,dt2);
            f8.Show();
            this.Hide();
        }
    }
}
