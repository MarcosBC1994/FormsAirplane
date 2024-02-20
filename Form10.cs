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
    public partial class Form10 : Form
    {
        Empresa empresaCalculo = new Empresa();
        int days;
        public Form10(int daysNumber)
        {
            InitializeComponent();
            empresaCalculo.ReadAllFiles();
            days = daysNumber;
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

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
            if (comboBox2.Text == "Cargos")
            {
                ListsCargos();
            }
            if (comboBox2.Text == "Jets")
            {
                ListsJets();
            }     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            string text = empresaCalculo.PlaneType(id);

            label2.Text=text;

            if(empresaCalculo.PlaneType(id)=="Not Found")
            {
                MessageBox.Show("Plane not found");
            }
            else
            {
                if (empresaCalculo.PlaneType(id) == "Cargo")
                {
                    label2.Text="Cargo Found\nPrice for "+ days+" days: "+empresaCalculo.Search(id,days);
                }

                else if (empresaCalculo.PlaneType(id) == "Jet")
                {
                    label2.Text = "Jet Found\nPrice for " + days + " days: " + empresaCalculo.Search(id, days);
                }

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
