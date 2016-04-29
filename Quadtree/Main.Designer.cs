namespace Quadtree
{
    partial class Main
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
            this.buttonHomogenous = new System.Windows.Forms.Button();
            this.buttonHeterogenousLevel1 = new System.Windows.Forms.Button();
            this.buttonHeterogenousLevel2 = new System.Windows.Forms.Button();
            this.buttonCreateTree = new System.Windows.Forms.Button();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeViewSquares = new System.Windows.Forms.TreeView();
            this.buttonFillTreeView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHomogenous
            // 
            this.buttonHomogenous.Location = new System.Drawing.Point(36, 241);
            this.buttonHomogenous.Name = "buttonHomogenous";
            this.buttonHomogenous.Size = new System.Drawing.Size(125, 23);
            this.buttonHomogenous.TabIndex = 2;
            this.buttonHomogenous.Text = "Homogenous";
            this.buttonHomogenous.UseVisualStyleBackColor = true;
            this.buttonHomogenous.Click += new System.EventHandler(this.OnButtonHomogenousClick);
            // 
            // buttonHeterogenousLevel1
            // 
            this.buttonHeterogenousLevel1.Location = new System.Drawing.Point(36, 270);
            this.buttonHeterogenousLevel1.Name = "buttonHeterogenousLevel1";
            this.buttonHeterogenousLevel1.Size = new System.Drawing.Size(125, 23);
            this.buttonHeterogenousLevel1.TabIndex = 3;
            this.buttonHeterogenousLevel1.Text = "Heterogenous Level 1";
            this.buttonHeterogenousLevel1.UseVisualStyleBackColor = true;
            this.buttonHeterogenousLevel1.Click += new System.EventHandler(this.OnButtonHeterogenousLevel1Click);
            // 
            // buttonHeterogenousLevel2
            // 
            this.buttonHeterogenousLevel2.Location = new System.Drawing.Point(36, 299);
            this.buttonHeterogenousLevel2.Name = "buttonHeterogenousLevel2";
            this.buttonHeterogenousLevel2.Size = new System.Drawing.Size(125, 23);
            this.buttonHeterogenousLevel2.TabIndex = 4;
            this.buttonHeterogenousLevel2.Text = "Heterogenous Level 2";
            this.buttonHeterogenousLevel2.UseVisualStyleBackColor = true;
            this.buttonHeterogenousLevel2.Click += new System.EventHandler(this.OnButtonHeterogenousLevel2Click);
            // 
            // buttonCreateTree
            // 
            this.buttonCreateTree.Location = new System.Drawing.Point(36, 328);
            this.buttonCreateTree.Name = "buttonCreateTree";
            this.buttonCreateTree.Size = new System.Drawing.Size(125, 23);
            this.buttonCreateTree.TabIndex = 5;
            this.buttonCreateTree.Text = "Create Quadtree";
            this.buttonCreateTree.UseVisualStyleBackColor = true;
            this.buttonCreateTree.Click += new System.EventHandler(this.OnButtonCreateTreeClick);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(36, 183);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(125, 23);
            this.buttonSelectFile.TabIndex = 6;
            this.buttonSelectFile.Text = "Select Image";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.OnButtonSelectFileClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(493, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quadtree.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(21, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // treeViewSquares
            // 
            this.treeViewSquares.Location = new System.Drawing.Point(188, 183);
            this.treeViewSquares.Name = "treeViewSquares";
            this.treeViewSquares.Size = new System.Drawing.Size(455, 226);
            this.treeViewSquares.TabIndex = 7;
            // 
            // buttonFillTreeView
            // 
            this.buttonFillTreeView.Location = new System.Drawing.Point(36, 212);
            this.buttonFillTreeView.Name = "buttonFillTreeView";
            this.buttonFillTreeView.Size = new System.Drawing.Size(125, 23);
            this.buttonFillTreeView.TabIndex = 8;
            this.buttonFillTreeView.Text = "Print";
            this.buttonFillTreeView.UseVisualStyleBackColor = true;
            this.buttonFillTreeView.Click += new System.EventHandler(this.OnButtonFillTreeViewClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 431);
            this.Controls.Add(this.buttonFillTreeView);
            this.Controls.Add(this.treeViewSquares);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.buttonCreateTree);
            this.Controls.Add(this.buttonHeterogenousLevel2);
            this.Controls.Add(this.buttonHeterogenousLevel1);
            this.Controls.Add(this.buttonHomogenous);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonHomogenous;
        private System.Windows.Forms.Button buttonHeterogenousLevel1;
        private System.Windows.Forms.Button buttonHeterogenousLevel2;
        private System.Windows.Forms.Button buttonCreateTree;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.TreeView treeViewSquares;
        private System.Windows.Forms.Button buttonFillTreeView;
    }
}

