using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            //var list = FileControl.ReadTableFromFile(savePath);


            DriveInfo[] info = System.IO.DriveInfo.GetDrives();
            foreach (DriveInfo drive in info)
            {
                if (drive.Name != "C:\\")
                {
                    string folderPath = drive.Name;

                    TreeNode root = new TreeNode();
                    root.Text = folderPath;
                    GetFolder(folderPath, root);
                    treeView1.Nodes.Add(root);
                }
            }


            ImageList imgList = new ImageList();
            imgList.Images.Add(Image.FromFile(@"E:\Games\folder-icon.png"));
            imgList.Images.Add(Image.FromFile(@"E:\Games\file-icon.png"));
            imgList.Images.Add(Image.FromFile(@"E:\Games\image-file-icon.png"));
            imgList.ImageSize = new Size(64, 64);
            listView1.LargeImageList = imgList;



        }

        TreeNode selectedNode;

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedNode = e.Node;
            string path = e.Node.FullPath.Replace(@"\\", @"\");
            List<string> files = new List<string>(Directory.GetFiles(path));
            List<string> subFolders = Directory.EnumerateDirectories(path).ToList();
            listView1.Items.Clear();

            foreach (string folder in subFolders)
            {
                DirectoryInfo di = new DirectoryInfo(folder);
                ListViewItem item = new ListViewItem();
                item.Text = di.Name;
                item.ImageIndex = 0;
                listView1.Items.Add(item);
            }


            foreach (var file in files)
            {
                FileInfo fi = new FileInfo(file);
                ListViewItem item = new ListViewItem();
                item.Text = fi.Name;
                if (fi.Extension == ".jpg")
                {
                    item.ImageIndex = 2;
                }
                else
                {
                    item.ImageIndex = 1;
                }

                listView1.Items.Add(item);
            }

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem choosen = listView1.SelectedItems[0];
                if(choosen.ImageIndex == 0)
                {
                    //Folder
                    if (selectedNode != null) selectedNode.Expand();
                    
                    foreach (TreeNode node in selectedNode.Nodes)
                    {
                        if (node.Text == choosen.Text)
                        {
                            treeView1.SelectedNode = node;
                            break;
                        }
                    }
                }
                else
                {
                    //File
                    string path = selectedNode.FullPath.Replace(@"\\", @"\");
                    path = path + @"\" + choosen.Text;
                    Process myProcess = new Process();
                    myProcess.StartInfo.FileName = path; //not the full application path
                    myProcess.Start();
                }
            }
               
        }


        public void GetFolder(string folderPath, TreeNode node)
        {
            try
            {
                List<string> subFolders = Directory.EnumerateDirectories(folderPath).ToList();
                //List<string> files = new List<string>(Directory.GetFiles(folderPath));
                foreach (string item in subFolders)
                {
                    DirectoryInfo di = new DirectoryInfo(item);
                    TreeNode child = node.Nodes.Add(di.Name);
                    //foreach (var file in files)
                    //{
                    //   //FileInfo fi = new FileInfo(file);
                    //    //node.Nodes.Add(fi.Name);
                    //}
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

            if (f2.DialogResult == DialogResult.OK)
            {
                Card card = f2.ReturnValue;
                listCard.Add(card);
            }
            FileControl.WriteTableToFile(savePath, listCard.ToList());
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {

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
