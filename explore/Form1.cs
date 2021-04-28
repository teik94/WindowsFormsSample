using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace explore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadAllDrive();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(new ThreadStart(LoadAllDrive));
                thread.Start();
            }
            
        }
       
        private void LoadAllDrive()
        {
            System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();
            time.Tick += Time_Tick;
            time.Interval = 10000;
            time.Start();
            while (true)
            {

                ////asdsadsadasd


                Thread.Sleep(1000000);
            }
            DriveInfo[] info = System.IO.DriveInfo.GetDrives();
            

            //progressBar1.Maximum = subFolders.Count;
            //progressBar1.Value = 0;
            int max = 0;
            
            foreach (DriveInfo drive in info)
            {
                //int fCount = Directory.GetDirectories(drive.Name, "*", SearchOption.AllDirectories).Length;
                GetProgressMax(drive.Name, ref max);
                //max += fCount;
            }

            this.Invoke(new Action(() =>
            {
                progressBar1.Maximum = max;
                progressBar1.Step = 1;
                progressBar1.Value = 0;
            }));
            

            foreach (DriveInfo drive in info)
            {
                string folderPath = drive.Name;
                TreeNode root = new TreeNode();
                root.Text = folderPath;
                GetFolder(folderPath, root);
                //treeView1.Nodes.Add(root);
                Action action = new Action(test);
                this.Invoke(new Action(() =>
                {
                    treeView1.Nodes.Add(root);
                }));
            }
            ImageList imgList = new ImageList();
            imgList.Images.Add(Image.FromFile(@"icon\72.jpg"));
            imgList.Images.Add(Image.FromFile(@"icon\73.png"));
            imgList.ImageSize = new Size(64, 64);
            this.Invoke(new Action(() =>
            {
                listView1.LargeImageList = imgList;
                listView1.SmallImageList = imgList;
            }));
            //listView1.LargeImageList = imgList;
            //listView1.SmallImageList = imgList;

        }

        private void Time_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }

        void test()
        {

        }

        public void GetFolder(String folderPath, TreeNode node)
        {
            try
            {
                List<string> subFolders = Directory.EnumerateDirectories(folderPath).ToList();
               
                for (int i = 0; i < subFolders.Count; i++)
                {
                    DirectoryInfo di = new DirectoryInfo(subFolders[i]);
                    TreeNode child = node.Nodes.Add(di.Name);
                    GetFolder(subFolders[i],  child);
                    this.Invoke(new Action(() =>
                    {
                        progressBar1.PerformStep();
                    }));
                }
            }
            catch (Exception e)
            {


            }

        }

        public void GetProgressMax(String folderPath, ref int max)
        {
            try
            {
                List<string> subFolders = Directory.EnumerateDirectories(folderPath).ToList();

                for (int i = 0; i < subFolders.Count; i++)
                {
                    //DirectoryInfo di = new DirectoryInfo(subFolders[i]);
                    max++;
                    GetProgressMax(subFolders[i], ref max);
                }
            }
            catch (Exception e)
            {


            }

        }

        TreeNode selectedNode;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                selectedNode = e.Node;
                string path = e.Node.FullPath.Replace(@"\\", @"\");
                List<string> files = new List<string>(Directory.GetFiles(path));
                List<string> subfolder = Directory.EnumerateDirectories(path).ToList();
                listView1.Items.Clear();
                foreach (string folder in subfolder)
                {
                    DirectoryInfo di = new DirectoryInfo(folder);
                    ListViewItem item = new ListViewItem();
                    item.Text = di.Name;
                    listView1.Items.Add(item);
                    item.ImageIndex = 0;
                }
                foreach (var file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    ListViewItem item = new ListViewItem();
                    item.Text = fi.Name;
                    if (fi.Extension == "jpg")
                    {
                        item.ImageIndex = 1;

                    }
                    else
                    {
                        item.ImageIndex = 1;
                    }
                    listView1.Items.Add(item);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access Denied!!!");
            }
            
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 100)
            {
                progressBar1.Value = 0;
            }
            else
            {
                progressBar1.Step = 40;
                progressBar1.PerformStep();
            }

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem choosen = listView1.SelectedItems[0];
                if (choosen.ImageIndex == 0)
                {
                    if (selectedNode != null) selectedNode.Expand();
                    foreach (TreeNode node in selectedNode.Nodes)
                    {
                        if (node.Text == choosen.Text)
                        {
                            treeView1.SelectedNode = node;
                            if (progressBar1.Value >= 100)
                            {
                                progressBar1.Value = 0;
                            }
                            else
                            {
                                progressBar1.Step = 10;
                                progressBar1.PerformStep();
                                
                            }
                            break;

                        }
                        
                    }

                }
                else
                {
                    string path = selectedNode.FullPath.Replace(@"\\", @"\");
                    path = path + @"\" + choosen.Text;
                    Process myProcess = new Process();
                    myProcess.StartInfo.FileName = path;
                    myProcess.Start();
                }
            }
        }

       
    }
}

