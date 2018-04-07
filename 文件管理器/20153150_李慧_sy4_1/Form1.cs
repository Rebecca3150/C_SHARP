using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    //按要求添加

namespace _20153150_李慧_sy4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TreeNode myComputeNode = new TreeNode("我的电脑");  //表示节点
            treeView1.Nodes.Add(myComputeNode); //为TreeView控件添加节点和子节点。
            listViewShow(myComputeNode);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listViewShow(e.Node);
            DirTreeShow(e.Node);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //编写 ListView 控件的 DoubleClick 事件代码。
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (int listIndex in listView1.SelectedIndices)
            {
                listViewShow(listView1.Items[listIndex].Text);
            }
        }


        //编写 ListView 控件的方法 listViewShow(TreeNode dirNode)。
        private void listViewShow(TreeNode dirNode)
        {
            listView1.Clear();  //整个listview内保存数据的结构就没了。
            //对比：使用了listview.item.clear()后，listview控件中仍然保存着listviewitem项的结构，即listview有多个列，每列可能对应的列标题数据等。
            if (dirNode.Parent == null)
            {
                foreach (string DrvName in Directory.GetLogicalDrives())    //获得硬盘分区名
                {
                    ListViewItem aItem = new ListViewItem(DrvName);
                    listView1.Items.Add(aItem);
                }
            }
            else
            {   //如果当前TreeView的父结点不为空，把点击的结点，做为一个目录文件的总结点
                foreach (string DirName in Directory.GetDirectories((string)dirNode.Tag))   //编历当前分区或文件夹所有目录
                {
                    ListViewItem aItem = new ListViewItem(DirName);
                    listView1.Items.Add(aItem);
                }
                foreach (string fileName in Directory.GetFiles((string)dirNode.Tag))
                {
                    ListViewItem aItem = new ListViewItem(fileName);
                    listView1.Items.Add(aItem);
                }
            }
        }

        //编写 listViewShow 的重载方法。
        private void listViewShow(string dirName)   //获取当有文件夹内的文件和目录
        {
            listView1.Clear();
            try
            {
                foreach (string DirName in Directory.GetDirectories(dirName))
                {
                    ListViewItem aItem = new ListViewItem(DirName);
                    listView1.Items.Add(aItem);
                }
                foreach (string fileName in Directory.GetFiles(dirName))
                {
                    ListViewItem aItem = new ListViewItem(fileName);
                    listView1.Items.Add(aItem);
                }

            }
            catch { }
        }

        //编写 DirTreeShow(TreeNode dirNode)方法
        private void DirTreeShow(TreeNode dirNode)
        {
            try
            {
                if (dirNode.Nodes.Count == 0)
                {
                    if (dirNode.Parent == null)
                    {
                        foreach (string DrvName in Directory.GetLogicalDrives())
                        {
                            TreeNode aNode = new TreeNode(DrvName);
                            aNode.Tag = DrvName;
                            dirNode.Nodes.Add(aNode);
                        }
                    }
                    else
                    {
                        foreach (string DirName in Directory.GetDirectories((string)dirNode.Tag))
                        {
                            TreeNode aNode = new TreeNode(DirName);
                            aNode.Tag = DirName;
                            dirNode.Nodes.Add(aNode);
                        }
                    }
                }
            }
            catch { }
        }
    }
}
