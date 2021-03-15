using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Card ReturnValue { get; set; }

        public Card InitValue { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void txtHp_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if(txt.Text != "")
            {
                int output = 0;
                bool checkNumber = Int32.TryParse(txt.Text, out output);
                if (checkNumber == false)
                {
                    txt.Text = txt.Text.Remove(txt.Text.Length - 1);
                    txt.SelectionStart = txt.Text.Length;
                    txt.SelectionLength = 0;
                }
            }
        }

        private void txtDef_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnImageBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.InitialDirectory = "C:\\";
            //dialog.Filter = "Jpg files(*.jpg)| *.jpg";
            DialogResult result = dialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                txtImage.Text = dialog.FileName;
            }

            
            //else if (result == DialogResult.Cancel)
            //{
            //    txtImage.Text = "";
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Card c = new Card();
            c.Id = Guid.NewGuid().ToString();
            c.Name = txtName.Text;
            c.Image = txtImage.Text;
            c.Hp = txtHp.Text;
            c.Atk = txtAtk.Text;
            c.Def = txtDef.Text;

            this.ReturnValue = c;
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(this.InitValue != null)
            {
                txtId.Text = this.InitValue.Id;
                txtName.Text = this.InitValue.Name;
                txtImage.Text = this.InitValue.Image;
                txtHp.Text = this.InitValue.Hp;
                txtAtk.Text = this.InitValue.Atk;
                txtDef.Text = this.InitValue.Def;
            }
            else
            {
                //txtId.Text = "";
            }
        }

        private void txtImage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                pictureBox1.Image = Image.FromFile(txt.Text);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
