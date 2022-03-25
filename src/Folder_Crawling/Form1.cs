using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
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
        private void ChooseButton_Click(object sender, EventArgs e)
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
            bfsBox.Checked = false;
            this.isBFS = false;
        }

        //Handling BFS Check Box
        private void bfsBox_CheckedChanged(object sender, EventArgs e)
        {
            this.isBFS = bfsBox.Checked;
            dfsBox.Checked = false;
            this.isDFS = false;
        }

        //Handling searchButton
        private void searchButton_Click(object sender, EventArgs e)
        {
            ClearGraph();

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
            }else if (this.isBFS)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                BFS bfs = new BFS(nameFile, pathFolder, findAll);
                string result = bfs.Run();

                stopwatch.Stop();

                long time = stopwatch.ElapsedMilliseconds;
                PosProcessing(result, time);
            }
            else
            {
                DFS dfs = new DFS(0,nameFile, pathFolder, findAll);
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                string result = dfs.run();

                stopwatch.Stop();
                long time = stopwatch.ElapsedMilliseconds;

                PosProcessing(result, time);
            }
            Form1.viewer.Graph = Form1.graph;
        }


        private void graphPanel_Paint(object sender, PaintEventArgs e)
        {
            Form1.viewer.Graph = Form1.graph;
            Form1.viewer.Dock = DockStyle.Fill;
            Form1.viewer.ToolBarIsVisible = false;
            this.graphPanel.Controls.Add(viewer);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(PathLink.Text);
        }

        private void PosProcessing(string result, long time)
        {   
            if(result != "")
            {
                if (this.findAll)
                {
                    char[] delims = new[] { '\r', '\n' };
                    string[] allFound = result.Split(delims, StringSplitOptions.RemoveEmptyEntries);


                    string thisPath = allFound[allFound.Length - 1];

                    string[] splitted = thisPath.Split('\\');

                    string final = "";

                    for(int i = 0; i < splitted.Length - 1; i++)
                    {
                        final += splitted[i];
                        if(i != splitted.Length - 2)
                        {
                            final += '\\';
                        }
                    }

                    PathLink.Text = final;
                    PathLink.Visible = true;

                }
                else
                {
                    string[] splitted = result.Split('\\');

                    string final = "";

                    for (int i = 0; i < splitted.Length - 1; i++)
                    {
                        final += splitted[i];
                        if (i != splitted.Length - 2)
                        {
                            final += '\\';
                        }
                    }
                    PathLink.Text = final;
                    PathLink.Visible = true;
                }
            }
            else
            {   
                LabelNotFound.Text = "File tidak ditemukan!!";
                LabelNotFound.Visible = true;
            }

            TimeSpent.Text = time.ToString() + "ms";
            TimeSpent.Visible = true;
        }

        private void ClearGraph()
        {
            foreach (Edge edge in Form1.graph.Edges.ToArray())
            {
                Form1.graph.RemoveEdge(edge);
            }

            foreach (Node node in Form1.graph.Nodes.ToArray())
            {
                Form1.graph.RemoveNode(node);
            }
            PathLink.Visible = false;
            LabelNotFound.Visible = false;
            TimeSpent.Visible = false;
        }
    }
}
