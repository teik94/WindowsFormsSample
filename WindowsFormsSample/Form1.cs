using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<int> listNumber = new List<int>();
        int soLan = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                DialogResult rs = dialog.ShowDialog();
                if(rs == DialogResult.OK)
                {
                    string path = dialog.FileName;
                    Image img = Bitmap.FromFile(path);
                    pictureBox1.Image = img;
                    Graphics g = Graphics.FromImage(img);
                }

                bool check = cbCheckBox.Checked;
                if(check == true)
                {
                    int result = 0;
                    foreach (var item in listNumber)
                    {
                        result = result + item;
                    }
                    txtResult.Text = result.ToString();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Nhap sai");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int soLan = Convert.ToInt32(txtCount.Text);
            if (listNumber.Count < Convert.ToInt32(txtCount.Text))
            {
                Calculate();
            }
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            soLan = Convert.ToInt32(txtCount.Text);
        }

        public void Calculate()
        {
            Rectangle rec = new Rectangle();
            int number = Convert.ToInt32(txtNumberA.Text);
            listNumber.Add(number);
            cbbListNumber.Items.Add(number);
            MessageBox.Show("Da nhap " + number);
        }
    }

   
}
