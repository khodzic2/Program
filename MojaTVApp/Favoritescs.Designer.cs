namespace MojaTVApp
{
    partial class Favoritescs
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("BHT");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Hayat");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("FederalnaTV");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("RTRS");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("TVSA");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("ArenaSport");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Sportklub");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Eurosport");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("FOX");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("MTV");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Other");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Programs", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "BHT";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Hayat";
            treeNode3.Name = "Node3";
            treeNode3.Text = "FederalnaTV";
            treeNode4.Name = "Node4";
            treeNode4.Text = "RTRS";
            treeNode5.Name = "Node5";
            treeNode5.Text = "TVSA";
            treeNode6.Name = "Node6";
            treeNode6.Text = "ArenaSport";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Sportklub";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Eurosport";
            treeNode9.Name = "Node9";
            treeNode9.Text = "FOX";
            treeNode10.Name = "Node10";
            treeNode10.Text = "MTV";
            treeNode11.Name = "Node11";
            treeNode11.Text = "Other";
            treeNode12.Name = "Node0";
            treeNode12.Text = "Programs";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(227, 212);
            this.treeView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Favoritescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Favoritescs";
            this.Text = "Favourite channels";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}