using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folder_Crawling
{
    public partial class Form1 : Form
    {
        private String nameFile;
        private String pathFolder;
        private bool findAll;
        private bool isBFS;
        private bool isDFS;

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
                bfs.run();
            }
            else
            {
                DFS dfs = new DFS(0,nameFile, pathFolder, findAll);
                dfs.run();
            }


        }


    }
}
