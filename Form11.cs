using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form11 : Form
    {
        List<string> ids = new List<string>();
        List<string> dailyvalues = new List<string>();
        List<string> initialDate = new List<string>();
        List<string> finalDate = new List<string>();


        public Form11(Empresa empresa)
        {
            InitializeComponent();
        }
        private void Form11_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            string filePath = @"freight.csv";

            // Clear lists before reading new data
            ids.Clear();
            dailyvalues.Clear();
            initialDate.Clear();
            finalDate.Clear();

            using (StreamReader file = new StreamReader(filePath))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] fields = line.Split(';');

                    ids.Add(fields[0]);
                    dailyvalues.Add(fields[1]);
                    initialDate.Add(fields[2]);
                    finalDate.Add(fields[3]);
                }
            }

            // Get the selected dates from DateTimePickers
            DateTime dt1 = dateTimePicker1.Value.Date;
            DateTime dt2 = dateTimePicker2.Value.Date;

            verifyDates(dt1,dt2);


            // Calculate total value within date range
            double totalvalue = 0;
            DateTime currentDate = dt1;

            while (currentDate <= dt2)
            {
                for (int i = 0; i < ids.Count; i++)
                {
                    DateTime reservaInicial, reservaFinal;
                    if (!DateTime.TryParse(initialDate[i], out reservaInicial) ||
                        !DateTime.TryParse(finalDate[i], out reservaFinal))
                    {
                        // Handle invalid date format
                        continue;
                    }

                    if (currentDate >= reservaInicial && currentDate <= reservaFinal)
                    {
                        totalvalue += double.Parse(dailyvalues[i]);
                    }
                }
                currentDate = currentDate.AddDays(1);
            }

            label2.Text = totalvalue.ToString();
        }

        private void verifyDates(DateTime dt1, DateTime dt2)
        {
            if (dt1 > dt2)
            {
                MessageBox.Show("Invalid date range");
                return;
            }
        }
    }
}

