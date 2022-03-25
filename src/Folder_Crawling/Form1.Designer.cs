
namespace Folder_Crawling
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.horizontalLine = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.verticalLine = new System.Windows.Forms.Label();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.inputFileName = new System.Windows.Forms.Label();
            this.chooseButton = new System.Windows.Forms.Button();
            this.printStarting = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.findAllCheck = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bfsBox = new System.Windows.Forms.CheckBox();
            this.dfsBox = new System.Windows.Forms.CheckBox();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.PathLink = new System.Windows.Forms.LinkLabel();
            this.PathLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeSpent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(309, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(299, 46);
            this.title.TabIndex = 0;
            this.title.Text = "Folder Crawling";
            // 
            // horizontalLine
            // 
            this.horizontalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.horizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horizontalLine.Location = new System.Drawing.Point(-3, 76);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(2134, 10);
            this.horizontalLine.TabIndex = 1;
            // 
            // inputLabel
            // 
            this.inputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(124, 104);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(82, 36);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Input";
            // 
            // outputLabel
            // 
            this.outputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(695, 104);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(104, 36);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Output";
            // 
            // verticalLine
            // 
            this.verticalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.verticalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalLine.Location = new System.Drawing.Point(396, 86);
            this.verticalLine.Name = "verticalLine";
            this.verticalLine.Size = new System.Drawing.Size(10, 1142);
            this.verticalLine.TabIndex = 4;
            // 
            // directoryLabel
            // 
            this.directoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directoryLabel.Location = new System.Drawing.Point(20, 164);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(287, 29);
            this.directoryLabel.TabIndex = 5;
            this.directoryLabel.Text = "Choose Starting Directory";
            // 
            // inputFileName
            // 
            this.inputFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFileName.AutoSize = true;
            this.inputFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFileName.Location = new System.Drawing.Point(19, 322);
            this.inputFileName.Name = "inputFileName";
            this.inputFileName.Size = new System.Drawing.Size(223, 36);
            this.inputFileName.TabIndex = 6;
            this.inputFileName.Text = "Input File Name";
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(12, 246);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(125, 30);
            this.chooseButton.TabIndex = 7;
            this.chooseButton.Text = "Choose Folder";
            this.chooseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // printStarting
            // 
            this.printStarting.Location = new System.Drawing.Point(156, 250);
            this.printStarting.Name = "printStarting";
            this.printStarting.Size = new System.Drawing.Size(222, 22);
            this.printStarting.TabIndex = 8;
            this.printStarting.Text = "No File Chosen";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(25, 381);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(353, 22);
            this.inputName.TabIndex = 9;
            this.inputName.Text = "No File Name Given";
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // findAllCheck
            // 
            this.findAllCheck.AutoSize = true;
            this.findAllCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.findAllCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAllCheck.Location = new System.Drawing.Point(24, 421);
            this.findAllCheck.Margin = new System.Windows.Forms.Padding(5);
            this.findAllCheck.Name = "findAllCheck";
            this.findAllCheck.Size = new System.Drawing.Size(174, 24);
            this.findAllCheck.TabIndex = 10;
            this.findAllCheck.Text = "Find All Occurence";
            this.findAllCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.findAllCheck.UseVisualStyleBackColor = true;
            this.findAllCheck.CheckedChanged += new System.EventHandler(this.findAllCheck_CheckedChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(99, 709);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(126, 49);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Input Metode Pencarian";
            // 
            // bfsBox
            // 
            this.bfsBox.AutoSize = true;
            this.bfsBox.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bfsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfsBox.Location = new System.Drawing.Point(25, 551);
            this.bfsBox.Margin = new System.Windows.Forms.Padding(5);
            this.bfsBox.Name = "bfsBox";
            this.bfsBox.Size = new System.Drawing.Size(187, 24);
            this.bfsBox.TabIndex = 13;
            this.bfsBox.Text = "Breadth First Search";
            this.bfsBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bfsBox.UseVisualStyleBackColor = true;
            this.bfsBox.CheckedChanged += new System.EventHandler(this.bfsBox_CheckedChanged);
            // 
            // dfsBox
            // 
            this.dfsBox.AutoSize = true;
            this.dfsBox.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dfsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfsBox.Location = new System.Drawing.Point(24, 585);
            this.dfsBox.Margin = new System.Windows.Forms.Padding(5);
            this.dfsBox.Name = "dfsBox";
            this.dfsBox.Size = new System.Drawing.Size(173, 24);
            this.dfsBox.TabIndex = 14;
            this.dfsBox.Text = "Depth First Search";
            this.dfsBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dfsBox.UseVisualStyleBackColor = true;
            this.dfsBox.CheckedChanged += new System.EventHandler(this.dfsBox_CheckedChanged);
            // 
            // graphPanel
            // 
            this.graphPanel.Location = new System.Drawing.Point(425, 144);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(1000, 500);
            this.graphPanel.TabIndex = 15;
            this.graphPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphPanel_Paint);
            // 
            // PathLink
            // 
            this.PathLink.AutoSize = true;
            this.PathLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLink.Location = new System.Drawing.Point(512, 709);
            this.PathLink.Name = "PathLink";
            this.PathLink.Size = new System.Drawing.Size(146, 32);
            this.PathLink.TabIndex = 16;
            this.PathLink.TabStop = true;
            this.PathLink.Text = "linkLabel1";
            this.PathLink.Visible = false;
            this.PathLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PathLabel
            // 
            this.PathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.Location = new System.Drawing.Point(419, 661);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(132, 36);
            this.PathLabel.TabIndex = 17;
            this.PathLabel.Text = "Path File";
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(419, 751);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(165, 36);
            this.TimeLabel.TabIndex = 18;
            this.TimeLabel.Text = "Time Spent";
            // 
            // TimeSpent
            // 
            this.TimeSpent.AutoSize = true;
            this.TimeSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSpent.Location = new System.Drawing.Point(590, 757);
            this.TimeSpent.Name = "TimeSpent";
            this.TimeSpent.Size = new System.Drawing.Size(79, 29);
            this.TimeSpent.TabIndex = 19;
            this.TimeSpent.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 951);
            this.Controls.Add(this.TimeSpent);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PathLink);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.dfsBox);
            this.Controls.Add(this.bfsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.findAllCheck);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.printStarting);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.inputFileName);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.verticalLine);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.horizontalLine);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Folder Crawling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label horizontalLine;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label verticalLine;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Label inputFileName;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.TextBox printStarting;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.CheckBox findAllCheck;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox bfsBox;
        private System.Windows.Forms.CheckBox dfsBox;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.LinkLabel PathLink;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TimeSpent;
    }
}

