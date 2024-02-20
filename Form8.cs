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
    public partial class Form8 : Form
    {
        public string date1, date2;
        DateTime datetime1, datetime2;
        Empresa empresa = new Empresa();
        public Form8(string dateS,string dateE,DateTime dt1,DateTime dt2)
        {
            empresa.ReadAllFiles();
            InitializeComponent();
            date1 = dateS;
            date2 = dateE;
            datetime1 = dt1;
            datetime2 = dt2;

            MessageBox.Show(date1);
        }


        //FILTERS THE TABLE

        private void ListsPlanes()
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"planes.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "State", "No.Motors", "Brand", "Year Production" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;

            //Adds the lines to the Table and Uodates the Task List
            while ((newline = file.ReadLine()) != null)
            {
                values = newline.Split(';');

                DataRow dr = dt.NewRow();

                // Adiciona os valores à linha
                for (int i = 0; i < values.Length - 2; i++)
                {
                    dr[i] = values[i];
                }

                // Adiciona a linha ao DataTable
                dt.Rows.Add(dr);
            }
            file.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        private void ListsComercials()
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"comercial.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "State", "No.Motors", "Brand", "Year Production", "No. Flights per Day", "Company" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;

            //Adds the lines to the Table and Uodates the Task List
            while ((newline = file.ReadLine()) != null)
            {
                values = newline.Split(';');

                DataRow dr = dt.NewRow();

                // Adiciona os valores à linha
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }

                // Adiciona a linha ao DataTable
                dt.Rows.Add(dr);
            }
            file.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        private void ListsCargos()
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"cargos.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "State", "No.Motors", "Brand", "Year Production", "Cargo capacity", "Freight rate" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;

            //Adds the lines to the Table and Uodates the Task List
            while ((newline = file.ReadLine()) != null)
            {
                values = newline.Split(';');

                DataRow dr = dt.NewRow();

                // Adiciona os valores à linha
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }

                // Adiciona a linha ao DataTable
                dt.Rows.Add(dr);
            }
            file.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        private void ListsJets()
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"jets.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "State", "No.Motors", "Brand", "Year Production", "Number of Owners", "Freight rate" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;

            //Adds the lines to the Table and Uodates the Task List
            while ((newline = file.ReadLine()) != null)
            {
                values = newline.Split(';');

                DataRow dr = dt.NewRow();

                // Adiciona os valores à linha
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }

                // Adiciona a linha ao DataTable
                dt.Rows.Add(dr);
            }
            file.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        private void ListsSmallPlanes()
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"smallPlanes.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "State", "No.Motors", "Brand", "Year Production", "Minimum Takeoff Area", "Minimum Landing Area" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;

            //Adds the lines to the Table and Uodates the Task List
            while ((newline = file.ReadLine()) != null)
            {
                values = newline.Split(';');

                DataRow dr = dt.NewRow();

                // Adiciona os valores à linha
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }

                // Adiciona a linha ao DataTable
                dt.Rows.Add(dr);
            }
            file.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Planes")
            {
                ListsPlanes();
            }
            if (comboBox1.Text == "Comercials")
            {
                ListsComercials();
            }
            if (comboBox1.Text == "Cargos")
            {
                ListsCargos();
            }
            if (comboBox1.Text == "Jets")
            {
                ListsJets();
            }
            if (comboBox1.Text == "SmallPlanes")
            {
                ListsSmallPlanes();
            }

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            label2.Text = "From: " + date1;
            label3.Text = "To: " + date2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpBooking();
        }

        private void SpBooking()
        {
            int id = 0;
            id = int.Parse(textBox1.Text);

            string search=empresa.SearchId(id,date1,date2,datetime1,datetime2);

            if (search == "Not Found")
            {
                MessageBox.Show("Id not found");
            }

        }

        
    }
}
