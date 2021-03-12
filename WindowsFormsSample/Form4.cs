using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        //List<Card> listCard;
        BindingList<Card> listCard = new BindingList<Card>();
        const string savePath = @"C:\KIET\data2.kiet";


        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            var list = FileControl.ReadTableFromFile(savePath);

            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.Columns.Clear();
            
            if (list != null)
            {
                listCard = new BindingList<Card>(list);
                dataGridView1.DataSource = listCard;

            }
            else
            {
                //listCard = new List<Card>();
                dataGridView1.DataSource = listCard;
            }
            //dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

            if(f2.DialogResult == DialogResult.OK)
            {
                Card card = f2.ReturnValue;
                listCard.Add(card);
            }
            FileControl.WriteTableToFile(savePath, listCard.ToList());
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            //DataGridViewRow dr = dataGridView1.se[0];
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
            FileControl.WriteTableToFile(savePath, listCard.ToList());
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow dr = dataGridView1.Rows[index];
            string id = dr.Cells["Id"].Value.ToString();
            Card card = listCard.Where(x => x.Id == id).FirstOrDefault();

            Form2 f2 = new Form2();
            f2.InitValue = card;
            f2.ShowDialog();

            if (f2.DialogResult == DialogResult.OK)
            {
                Card newCard = f2.ReturnValue;

                PropertyInfo[] properties = typeof(Card).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    property.SetValue(card, property.GetValue(newCard));
                }
            }
            FileControl.WriteTableToFile(savePath, listCard.ToList());
        }
    }
}
