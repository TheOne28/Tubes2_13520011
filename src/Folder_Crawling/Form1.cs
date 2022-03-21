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
                Console.WriteLine(folderBrowser.RootFolder);
            }else if(result == DialogResult.Cancel)
            {
                return;
            }


        }
    }
}
