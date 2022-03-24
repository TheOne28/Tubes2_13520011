using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;

namespace Folder_Crawling
{
    public partial class Form1 : Form
    {
        private String nameFile;
        private String pathFolder;
        private bool findAll;
        private bool isBFS;
        private bool isDFS;
        public static Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        public static Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

        public Form1()
        {
            InitializeComponent();
            this.nameFile = "";
            this.pathFolder = "";
        }


        //Handling Choose Folder Path
        private void chooseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select starting Directory";
            folderBrowser.ShowNewFolderButton = true;

            DialogResult result = folderBrowser.ShowDialog(); 
            
            if(result == DialogResult.OK)
            {
                printStarting.Text = folderBrowser.SelectedPath;
                this.pathFolder = folderBrowser.SelectedPath;
                Environment.SpecialFolder root = folderBrowser.RootFolder;
            }else if(result == DialogResult.Cancel)
            {
                return;
            }
        }
        
        //Handling Name File
        private void inputName_TextChanged(object sender, EventArgs e)
        {   
            this.nameFile = inputName.Text;
        }

        //Handling FindAll Check Box
        private void findAllCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.findAll = findAllCheck.Checked;
        }

        //Handling DFS Check Box
        private void dfsBox_CheckedChanged(object sender, EventArgs e)
        {
            this.isDFS = dfsBox.Checked;
        }

        //Handling BFS Check Box
        private void bfsBox_CheckedChanged(object sender, EventArgs e)
        {
            this.isBFS = bfsBox.Checked;
        }

        //Handling searchButton
        private void searchButton_Click(object sender, EventArgs e)
        {   
            foreach(Edge edge in Form1.graph.Edges.ToArray()){
                Form1.graph.RemoveEdge(edge);
            }

            foreach(Node node in Form1.graph.Nodes.ToArray())
            {
                Form1.graph.RemoveNode(node);
            }

            if(this.nameFile == "")
            {
                MessageBox.Show("Please input File Name");
                return;
            }

            if(this.pathFolder == "")
            {
                MessageBox.Show("Please input Starting Directory");
                return;
            }

            if (!this.isBFS && !this.isDFS)
            {
                MessageBox.Show("Please choose searching method");
                return;
            }else if(this.isBFS && this.isDFS)
            {
                MessageBox.Show("Please choose only one searching method ");
                return;
            }else if (this.isBFS)
            {
                BFS bfs = new BFS(nameFile, pathFolder, findAll);
                bfs.run(viewer, graph);
            }
            else
            {
                DFS dfs = new DFS(0,nameFile, pathFolder, findAll);
                string result = dfs.run();
                linkLabel1.Text = result;
            }
            Form1.viewer.Graph = Form1.graph;
        }


        private void graphPanel_Paint(object sender, PaintEventArgs e)
        {
            Form1.viewer.Graph = Form1.graph;
            Form1.viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            Form1.viewer.ToolBarIsVisible = false;
            this.graphPanel.Controls.Add(viewer);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }
    }
}
