using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            DriveInfo[] info = System.IO.DriveInfo.GetDrives();
            foreach (DriveInfo drive in info)
            {
                if(drive.Name != "C:\\")
                {
                    string folderPath = drive.Name;

                    TreeNode root = new TreeNode();
                    root.Text = folderPath;
                    GetFolder(folderPath, root);
                    treeView1.Nodes.Add(root);
                }
            }
            
        }

       

        public void GetFolder(string folderPath, TreeNode node)
        {
            try
            {
                List<string> subFolders = Directory.EnumerateDirectories(folderPath).ToList();
                List<string> files = new List<string>(Directory.GetFiles(folderPath));
                foreach (string item in subFolders)
                {
                    DirectoryInfo di = new DirectoryInfo(item);
                    TreeNode child = node.Nodes.Add(di.Name);
                    foreach (var file in files)
                    {
                       FileInfo fi = new FileInfo(file);
                        node.Nodes.Add(fi.Name);
                    }
                    GetFolder(item, child);
                }
            }
            catch
            {

            }
            
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

        //Timer time;

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 33;
            //time = new Timer();
            //time.Tick += new EventHandler(timer1_Tick);
            //time.Interval = 500;
            timer1.Start();

            //progressBar1.Step = progressBar1.Maximum / x;
            //int missingStep = progressBar1.Maximum - (progressBar1.Step * x);
            //for (int i = 0; i < x; i++)
            //{
            //    progressBar1.PerformStep();
            //}
            //progressBar1.Value = progressBar1.Value + missingStep;
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
            }
        }
    }
}
