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
        DataTable newDt = new DataTable();
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
            //DateTime ngaymothe = Convert.ToDateTime(createDate);
            //DateTime birthday = Convert.ToDateTime(birth);
            //if (id.Trim() == "")
            //{
            //    MessageBox.Show("nhap lai STK");
            //    return;
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    if (name.Contains(i.ToString()))
            //    {
            //        MessageBox.Show("ten chu the ko dc chua ky tu so");
            //        return;


            //    }

            //}
            //if (DateTime.TryParse(birth, out date))
            //{

            //    if (now.Year - birthday.Year < 18 || (now.Year - birthday.Year == 18 && now.Month < birthday.Month))
            //    {
            //        MessageBox.Show("ngay sinh phai du 18 tuoi");
            //        return;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("nhap lai ngay sinh");
            //}
            //if (ngaymothe.Year < birthday.Year || (ngaymothe.Year == (birthday.Year +18) && ngaymothe.Month < birthday.Month ||(ngaymothe.Year == (birthday.Year +18) && ngaymothe.Month == birthday.Month && ngaymothe.Day < birthday.Day)))
            //{
            //    MessageBox.Show("ngay2 mo the phai >= ngay sinh 18 nam");
            //}
            //if ( Convert.ToDouble(balance) < 100000)
            //{
            //    MessageBox.Show("so du toi thieu la 100000");
            //}
            //if (pin.Length < 6)
            //{
            //    MessageBox.Show("ma pin phai dung 6 ki tu so");
            //}
            
            if (dataGridView1.DataSource == null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("So tai khoan");
                dt.Columns.Add("Ten chu the");
                dt.Columns.Add("Ngay sinh");
                dt.Columns.Add("So CMND");
                dt.Columns.Add("Ngay mo the");
                dt.Columns.Add("Han su dung");
                dt.Columns.Add("So du");
                dt.Columns.Add("Ma pin");
                DataRow dr = dt.NewRow();
                dr["So tai khoan"] = id;
                dr["Ten chu the"] = name;
                dr["Ngay sinh"] = birth;
                dr["So CMND"] = cmnd;
                dr["Ngay mo the"] = createDate;
                dr["Han su dung"] = expire;
                dr["So du"] = balance;
                dr["Ma pin"] = pin;
                dt.Rows.Add(dr);
                newDt = dt;
                dataGridView1.DataSource = newDt;
            }
            else
            {

                DataRow row = newDt.NewRow();
                row["So tai khoan"] = id;
                row["Ten chu the"] = name;
                row["Ngay sinh"] = birth;
                row["So CMND"] = cmnd;
                row["Ngay mo the"] = createDate;
                row["Han su dung"] = expire;
                row["So du"] = balance;
                row["Ma pin"] = pin;
                newDt.Rows.Add(row);
                dataGridView1.DataSource = newDt;

            }



        }
    }
}
