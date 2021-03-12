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
        DataTable myDt;


        public Form3()
        {
            InitializeComponent();
        }

        public void AddProduct()
        {
            string code = txtPCode.Text;
            string name = txtPName.Text;
            int price = Convert.ToInt32(nmrPrice.Value);
            int quantity = Convert.ToInt32(nmrQuantity.Value);
            string note = txtNote.Text;
            bool promotion = cbPromotion.Checked;
            string type = cbbPType.Text;

            Product prd = new Product();
            prd.Code = code;
            prd.Name = name;
            prd.Price = price;
            prd.Quantity = quantity;
            prd.Note = note;

            List<Product> prdList = new List<Product>();
            prdList.Add(prd);

            Product find = prdList.Find(x => x.Code == code);
            prdList.Sort(delegate (Product x, Product y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.Name.CompareTo(y.Name);
            });
            List<Product> newList = prdList.Where(x => x.Code == code).ToList();
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

            if (code == "")
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

            DataTable newDt2 = new DataTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //int j = i + 1;
                //if (dt.Rows[i]["Code"].ToString() == "" && dt.Rows[j]["Code"].ToString() == "")
                //{

                //}
                //else if (dt.Rows[i]["Code"].ToString() == null)
                //{
                //    newDt2.Rows.Add(dt.Rows[i]["Code"].ToString());
                //}
                //else if (dt.Rows[j]["Code"].ToString() == null)
                //{
                //    newDt2.Rows.Add(dt.Rows[j]["Code"].ToString());
                //}
                //else
                //{
                //    if(dt.Rows[i]["Code"].ToString().CompareTo(dt.Rows[j]["Code"].ToString()) < 0)
                //    {
                //        newDt2.Rows.Add(dt.Rows[i]["Code"].ToString());
                //    }
                //    else
                //    {
                //        newDt2.Rows.Add(dt.Rows[j]["Code"].ToString());
                //    }
                //}
                //else if (y.Name == null) return 1;


                if (dt == null)
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
                        if (row["Code"].ToString() == code)
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
                    if (found == false)
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
                if (File.Exists(@"C:\KIET\data.kiet"))
                {
                    DataTable dt = ReadFile(@"C:\KIET\data.kiet");
                    dataGridView1.DataSource = dt;
                }

                myDt = (DataTable)dataGridView1.DataSource;
                //cbbSearchPromo.DataSource = myDt;
                //cbbSearchPromo.DisplayMember = "Name";
                //cbbSearchPromo.ValueMember = "Code";
                cbbSearchPromo.SelectedIndex = 0;
                //cbbSearchPromo.SelectedValue
            }
            catch (Exception ex)
            {

            }

        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            string search = txtSearchCode.Text;
            DataTable dt = (DataTable)dataGridView1.DataSource;
            //DataTable newDt = dt.Clone();
            List<DataRow> deleteRow = new List<DataRow>();
            foreach (DataRow row in dt.Rows)
            {
                if (row["Name"].ToString() == search)
                {
                    deleteRow.Add(row);
                    //deleteRow = row;
                    //DataRow newRow = newDt.NewRow();
                    //newRow.ItemArray = row.ItemArray;
                    //newDt.Rows.Add(newRow);
                }
            }

            foreach (var item in deleteRow)
            {
                dt.Rows.Remove(item);
            }



            //dataGridView1.DataSource = newDt;
        }

        private void btnMassUpdate_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            List<DataRow> updateRow = new List<DataRow>();

            foreach (DataRow row in dt.Rows)
            {
                if (row["Name"].ToString().Contains("Áo") == true)
                {
                    row["Type"] = "Áo";
                }
            }

            foreach (DataRow item in updateRow)
            {
                item["Type"] = "Áo";
            }

            int a = 0;
            int b = 1;



        }


        private void txtSearchAll_TextChanged(object sender, EventArgs e)
        {
            string searchCode = txtSearchCode.Text.ToString();
            string searchName = txtSearchName.Text.ToString();
            int searchPriceFrom;
            if (txtSearchPriceFrom.Text == "")
            {
                searchPriceFrom = 0;
            }
            else
            {
                searchPriceFrom = Convert.ToInt32(txtSearchPriceFrom.Text);
            }
                

            int searchPriceTo;
            if (txtSearchPriceTo.Text == "")
            {
                searchPriceTo = 999999999;
            }
            else
            {
                searchPriceTo  = Convert.ToInt32(txtSearchPriceTo.Text);
            }
             
            string searchPromo = cbbSearchPromo.SelectedItem.ToString();

            DataTable newDt = myDt.Clone();

            foreach (DataRow row in myDt.Rows)
            {
                if (row["Code"].ToString().Contains(searchCode)
                    && row["Name"].ToString().Contains(searchName)
                    && Convert.ToInt32(row["Price"]) >= searchPriceFrom 
                    && Convert.ToInt32(row["Price"]) <= searchPriceTo
                    )
                {
                    if (searchPromo == "All")
                    {
                        DataRow newRow = newDt.NewRow();
                        newRow.ItemArray = row.ItemArray;
                        newDt.Rows.Add(newRow);
                    }
                    else if(row["Promotion"].ToString() == searchPromo)
                    {
                        DataRow newRow = newDt.NewRow();
                        newRow.ItemArray = row.ItemArray;
                        newDt.Rows.Add(newRow);
                    }
                }
            }
            dataGridView1.DataSource = newDt;
        }
    }
}
