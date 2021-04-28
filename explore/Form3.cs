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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stk = txtId.Text;
            string name = txtName.Text;
            string expire = txtExpire.Text;
            DateTime date;

            bool datecheck = DateTime.TryParse(expire, out date);
            if (stk.Trim() == "")
            {
                MessageBox.Show("nhap STK ");
                return;
            }
            if (datecheck == false)
            {
                MessageBox.Show("sai date ");
                return;
            }
            if (dataGridView1.DataSource == null)
            {
               
                DataTable dt = new DataTable();
                dt.Columns.Add("So Tai Khoan");
                dt.Columns.Add("Ten Chu Tai Khoan");
                dt.Columns.Add("Ngay Het Han");
                DataRow dtrow = dt.NewRow();
                dtrow["So Tai Khoan"] = stk;
                dtrow["Ten Chu Tai Khoan"] = name;
                dtrow["Ngay Het Han"] = expire;
                dt.Rows.Add(dtrow);
                dataGridView1.DataSource = dt;
            }
            else
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                foreach (DataRow item in dt.Rows)
                {
                    if ( item["So Tai Khoan"].ToString() == stk)
                    {
                        MessageBox.Show("Trung STK");
                        return;
                    }
                    
                }
                DataRow dtrow = dt.NewRow();
                dtrow["So Tai Khoan"] = stk;
                dtrow["Ten Chu Tai Khoan"] = name;
                dtrow["Ngay Het Han"] = expire;
                dt.Rows.Add(dtrow);
                dataGridView1.DataSource = dt;
            }
            
        }
    }
}
