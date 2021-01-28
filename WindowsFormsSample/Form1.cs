using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<double> listNumber = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        public void Calculate()
        {

            double number = Convert.ToDouble(textBox2.Text);
            Profile pr = new Profile();
            pr.Name = textBox2.Text;

            listNumber.Add(number);
            MessageBox.Show("Da nhap " + number);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int y = 1;
            for (int x = 2; x < 10; x++)
            {
                for (y = 1; y < 11; y++)
                {
                    int z = x * y;
                    textBox3.Text = textBox3.Text + (x + "x" + y + "=" + z) + "\t";
                }

                y = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate();
        }
        public double analyze()
        {
            double BiggestNumber = 0;
            foreach (var item in listNumber)
            {
                if (item > BiggestNumber)
                {
                    BiggestNumber = item;
                }
            }

            return BiggestNumber;
            // double BiggestNumber = Math.Max(SoThuc[0], SoThuc[1]);
            //BiggestNumber = Math.Max(BiggestNumber, SoThuc[2]);
            //return BiggestNumber;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(analyze());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Result = 0;
            foreach (var item in listNumber)
            {
                Result = item + Result;
            }
            textBox1.Text = Convert.ToString(Result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string folder = "C:\\KIET\\";
            string file = "test.txt";
            string path = folder + file;
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                fs.WriteByte((byte)i);
            }
            fs.Position = 0;

            fs.Close();

            Process.Start(folder);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            //table.Columns.Add("Test1");

            for (int i = 0; i < 10; i++)
            {
                DataColumn column = new DataColumn();
                column.ColumnName = "Test" + i.ToString();
                table.Columns.Add(column);
            }


            for (int i = 0; i < 10; i++)
            {
                table.Rows.Add(table.NewRow());
            }


            dataGridView1.DataSource = table;

            int a = 1;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.HeaderCell.Value = a.ToString();
                a++;
            }

            //int a = 1;
            //for (int i = 0; i < table.Rows.Count; i++)
            //{
            //    //for (int j = 0; j < table.Columns.Count; j++)
            //    //{
            //    //    table.Rows[i][j] = a++;
            //    //}
            //    foreach (DataColumn item in table.Columns)
            //    {
            //        table.Rows[i][item.ColumnName] = a++;
            //    }
            //}

            //string col1 = table.Rows[0][1].ToString();
            //MessageBox.Show(col1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool found = false;

            DataTable table = (DataTable)dataGridView1.DataSource;


            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    string colValue = table.Rows[i][j].ToString();
                    string search = textBox6.Text;

                    if (colValue == search)
                    {
                        found = true;

                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[j];
                        //table.Rows[i][j]
                    }

                }

            }

            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //    {
            //        string colValue = dataGridView1.Rows[i].Cells[j].Value.ToString();
            //        string search = textBox6.Text;

            //        if (colValue == search)
            //        {
            //            found = true;

            //            dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[j];
            //            //table.Rows[i][j]
            //        }

            //    }

            //}

        }
    }

}
