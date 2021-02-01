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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string code = txtPCode.Text;
            string name = txtPName.Text;
            int price = Convert.ToInt32(nmrPrice.Value);
            int quantity = Convert.ToInt32(nmrQuantity.Value);
            string note = txtNote.Text;
            bool promotion = cbPromotion.Checked;
            string type = cbbPType.Text;

            if(code == "")
            {
                MessageBox.Show("Code cannot be empty");
                return;
            }
            else if (name == "")
            {
                MessageBox.Show("Product Name cannot be empty");
                return;
            }

            DataTable dt = (DataTable)dataGridView1.DataSource;
            if(dt == null)
            {
                DataTable newDt = new DataTable();
                newDt.Columns.Add("Code");
                newDt.Columns.Add("Name");
                newDt.Columns.Add("Price");
                newDt.Columns.Add("Quantity");
                newDt.Columns.Add("Promotion");
                newDt.Columns.Add("Type");
                newDt.Columns.Add("Note");

                DataRow dr = newDt.NewRow();
                dr["Code"] = code;
                dr["Name"] = name;
                dr["Price"] = price;
                dr["Quantity"] = quantity;
                dr["Promotion"] = promotion;
                dr["Type"] = type;
                dr["Note"] = note;
                newDt.Rows.Add(dr);

                dt = newDt;
                dataGridView1.DataSource = dt;
            }
            else
            {
                bool found = false;
                foreach (DataRow row in dt.Rows)
                {
                    if(row["Code"].ToString() == code)
                    {
                        row["Name"] = name;
                        row["Price"] = price;
                        row["Quantity"] = quantity;
                        row["Promotion"] = promotion;
                        row["Type"] = type;
                        row["Note"] = note;
                        found = true;
                        break;
                    }
                }
                if(found == false)
                {
                    DataRow dr = dt.NewRow();
                    dr["Code"] = code;
                    dr["Name"] = name;
                    dr["Price"] = price;
                    dr["Quantity"] = quantity;
                    dr["Promotion"] = promotion;
                    dr["Type"] = type;
                    dr["Note"] = note;
                    dt.Rows.Add(dr);
                }

                //dataGridView1.DataSource = dt;
            }

            WriteFile(@"C:\KIET\data.kiet", dt);

        }

        public void WriteFile(string path, DataTable data)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //TypeConverter obj = TypeDescriptor.GetConverter(data.GetType());
            //byte[] bt = (byte[])obj.ConvertTo(data, typeof(byte[]));

            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, data);
                byte[] bt = ms.ToArray();
                fs.Write(bt, 0, bt.Length);
            }

            fs.Close();
        }

        public DataTable ReadFile(string path)
        {
            //FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            byte[] bytes = System.IO.File.ReadAllBytes(path);
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream(bytes))
            {
                DataTable obj = (DataTable)bf.Deserialize(ms);
                //fs.Close();
                return obj;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                dataGridView1.Rows.Remove(dr);
                DataTable dt = (DataTable)dataGridView1.DataSource;
                WriteFile(@"C:\KIET\data.kiet", dt);
            }
            catch
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //DataTable dt = (DataTable)dataGridView1.DataSource;
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                txtPCode.Text = dr.Cells["Code"].Value.ToString();
                txtPName.Text = dr.Cells["Name"].Value.ToString();
                nmrPrice.Value = Convert.ToDecimal(dr.Cells["Price"].Value);
                nmrQuantity.Value = Convert.ToDecimal(dr.Cells["Quantity"].Value);
                cbPromotion.Checked = Convert.ToBoolean(dr.Cells["Promotion"].Value);
                cbbPType.Text = dr.Cells["Type"].Value.ToString();
                txtNote.Text = dr.Cells["Note"].Value.ToString();
            }
            catch
            {

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists(@"C:\KIET\data.kiet"))
                {
                    DataTable dt = ReadFile(@"C:\KIET\data.kiet");
                    dataGridView1.DataSource = dt;
                }
                
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}
