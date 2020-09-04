using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txt_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void StartRead_Click(object sender, EventArgs e)
        {
            TxtData.Clear();
            if (FileList.SelectedNode != null && FileList.SelectedNode != FileList.Nodes[0])
            {
                TreeNode nowNode = FileList.SelectedNode;
                String DirPath = Path.Combine(directory_.Text, nowNode.Text);

                if (nowNode.Text.Contains(".txt"))
                {
                    try
                    {
                        FileStream file = new FileStream(DirPath, FileMode.Open, FileAccess.Read);
                        byte[] byData = new byte[file.Length];
                        file.Seek(0, SeekOrigin.Begin);
                        int readbyte = file.Read(byData, 0, byData.Length);
                        TxtData.AppendText(new string(Encoding.ASCII.GetChars(byData, 0, readbyte)));

                        file.Close();
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void select_dir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog() { SelectedPath = Directory.GetCurrentDirectory() };
            if (f.ShowDialog() == DialogResult.OK)
            {
                String DirPath = f.SelectedPath;

                this.directory_.Text = DirPath;

                FileList.Nodes[0].Nodes.Clear();
                TreeNode rootNode = FileList.Nodes[0];

                DirectoryInfo root = new DirectoryInfo(DirPath);
                if (root.Exists)
                {
                    foreach (FileInfo file in root.GetFiles("*.txt"))
                    {
                        rootNode.Nodes.Add(file.Name);
                    }
                    rootNode.ExpandAll();
                    if (rootNode.GetNodeCount(true) == 0)
                    {
                        MessageBox.Show("此文件夹无文件");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("文件夹不存在");
                }

                StartRead.Enabled = true;
            }
        }
    }
}
