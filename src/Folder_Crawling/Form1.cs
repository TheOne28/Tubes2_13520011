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

        public Form1()
        {
            InitializeComponent();
        }

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

        private void inputName_TextChanged(object sender, EventArgs e)
        {   
            this.nameFile = inputName.Text;
        }

        private void findAllCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.findAll = findAllCheck.Checked;
        }


    }
}
