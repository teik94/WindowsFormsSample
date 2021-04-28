using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace explore
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btSAVE_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string birth = txtBirthday.Text;
            string cmnd = txtCMND.Text;
            string createDate = txtCreateDate.Text;
            string expire = txtExpire.Text;
            string balance = txtBalance.Text;
            string pin = txtPIN.Text;
            DateTime now = DateTime.Now;
            DateTime date;


            if (id.Trim() == "")
            {
                MessageBox.Show("nhap lai STK");
                return;
            }
            for (int i = 0; i < 10; i++)
            {
                if (name.Contains(i.ToString()))
                {
                    MessageBox.Show("ten chu the ko dc chua ky tu so");
                    return;
                    
                    
                }
                
            }
            if (DateTime.TryParse(birth, out date))
            {
                DateTime birthday = Convert.ToDateTime(birth);
                if (now.Year - birthday.Year < 18 || (now.Year - birthday.Year == 18 && now.Month < birthday.Month))
                {
                    MessageBox.Show("ngay sinh phai du 18 tuoi");
                    return;
                }
            }
            else
            {
                MessageBox.Show("nhap lai ngay sinh");
            }


        }
    }
}
