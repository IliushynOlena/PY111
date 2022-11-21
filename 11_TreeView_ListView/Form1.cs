using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_TreeView_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadImageList();
            LoadDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),dirTree.Nodes);
        }
        void LoadImageList()
        {
            ImageList list = new ImageList();
            list.Images.Add(new Bitmap("Images/folder1.png"));
            list.Images.Add(new Bitmap("Images/folder2.png"));
            list.Images.Add(new Bitmap("Images/1.png"));

            dirTree.ImageList = list;
            dirTree.ImageList.ImageSize = new Size(50, 40);
            
        }
        public void LoadDirectory(string path, TreeNodeCollection nodes)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (var subDir in dir.GetDirectories())
            {
                TreeNode newNode = new TreeNode(subDir.Name, 0,1);
                newNode.Tag = subDir.FullName;
                nodes.Add(newNode);
                //dirTree.Nodes.Add(subDir.Name);
                if( subDir.GetDirectories().Length > 0)
                    LoadDirectory(subDir.FullName, newNode.Nodes);
            }
            
        }

        private void dirTree_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 2;
        }

        private void dirTree_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex =0;
        }

        private void dirTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

            DirectoryInfo dir = new DirectoryInfo(e.Node.Tag.ToString());
            fileList.Clear();
            foreach (var file in dir.GetFiles())
            {
                ListViewItem list = new ListViewItem(file.Name);
                list.SubItems.Add(file.Extension);
                list.SubItems.Add(file.CreationTime.ToShortDateString());
                fileList.Items.Add(list);
            }
            
        }
    }
}
