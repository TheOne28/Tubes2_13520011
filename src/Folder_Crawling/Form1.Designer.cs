
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
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
            this.horizontalLine.Size = new System.Drawing.Size(1927, 10);
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
            this.outputLabel.Location = new System.Drawing.Point(715, 104);
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
            this.verticalLine.Size = new System.Drawing.Size(10, 866);
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
            this.inputFileName.Location = new System.Drawing.Point(19, 336);
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
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
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
            this.inputName.Location = new System.Drawing.Point(25, 397);
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
            this.findAllCheck.Location = new System.Drawing.Point(25, 438);
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
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Input Metode Pencarian";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(25, 572);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(187, 24);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Breadth First Search";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(25, 620);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(173, 24);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Depth First Search";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

