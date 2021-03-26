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
        //TreeNode lastNode;
        TreeNode selectedNode;
        List<TreeNode> lastNode = new List<TreeNode>();
        List<TreeNode> nextNode = new List<TreeNode>();

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
                    string folderPath = drive.Name.Replace("\\", "");

                    TreeNode root = new TreeNode();
                    root.Text = folderPath;
                    //root.Name = folderPath;
                    root.Name = drive.Name;
                    GetFolder(folderPath, root);
                    treeView1.Nodes.Add(root);
                }
            }


            ImageList imgList = new ImageList();
            imgList.Images.Add(Image.FromFile(@".\Resources\Icon\folder-icon.png"));
            imgList.Images.Add(Image.FromFile(@".\Resources\Icon\file-icon.png"));
            imgList.Images.Add(Image.FromFile(@".\Resources\Icon\image-file-icon.png"));
            imgList.ImageSize = new Size(64, 64);
            listView1.LargeImageList = imgList;

            treeView1.SelectedNode = treeView1.Nodes[0];
            lastNode.Add(treeView1.SelectedNode);
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if(selectedNode != null && lastNode.Count > 0 && selectedNode != lastNode.Last())
            {
                lastNode.Add(selectedNode);
                nextNode.Clear();
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(lastNode.Count > 0)
            {
                nextNode.Add(selectedNode);
                selectedNode = null;

                treeView1.Focus();
                treeView1.SelectedNode = lastNode.Last();

                if(lastNode.Count > 1)
                {
                    lastNode.Remove(lastNode.Last());
                }
                
            }
            

        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            
            treeView1.Focus();
            treeView1.SelectedNode = treeView1.SelectedNode.Parent;

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if(nextNode.Count > 0)
            {
                lastNode.Add(selectedNode);
                selectedNode = null;

                treeView1.Focus();
                treeView1.SelectedNode = nextNode.Last();

                nextNode.Remove(nextNode.Last());
            }
            
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedNode = e.Node;
            string path = e.Node.FullPath.Replace(@"\\", @"\");
            txtPath.Text = path;
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
                            //treeView1.Focus();
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

                    TreeNode child = new TreeNode();
                    child.Text = di.Name;
                    //child.Name = di.Name;
                    child.Name = di.FullName;

                    node.Nodes.Add(child);

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

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Changed");
        }

        private void txtPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox txt = (TextBox)sender;
                string path = txt.Text;

                if(path.Last() == '\\')
                {
                    path = path.Remove(path.Length - 1, 1);
                }

                //char c = '\\';
                //string[] test = path.Split(c);
                //List<string> searchNames = new List<string>();
                //foreach (var item in test)
                //{
                //    if(item != "")
                //    {
                //        searchNames.Add(item);
                //    }
                //}

                //TreeNode node = FindNode(treeView1.Nodes, searchNames);
                TreeNode[] node = treeView1.Nodes.Find(path, true);

                if (node.Length == 0)
                {
                    MessageBox.Show("Path not found!");
                }
                else
                {
                    treeView1.Focus();
                    treeView1.SelectedNode = node[0];
                }
                
            }
        }

        private TreeNode FindNode(TreeNodeCollection nodes, List<string> names)
        {
            var nodeFound = nodes.Find(names[0], false);
            if(nodeFound.Length > 0)
            {
                names.RemoveAt(0);
                if (names.Count > 0 && nodeFound[0].Nodes.Count > 0)
                {
                    return FindNode(nodeFound[0].Nodes, names);
                }
                else if (names.Count == 0)
                {
                    return nodeFound[0];
                }
            }

            return null;
        }
    }
}
