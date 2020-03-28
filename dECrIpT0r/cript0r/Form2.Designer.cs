namespace cript0r
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Deleted Files");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Recources");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Encripted Files", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.DeCript = new System.Windows.Forms.Button();
            this.DeCriptor = new System.Windows.Forms.Label();
            this.FR = new System.Windows.Forms.Button();
            this.DecriptFiles = new System.ComponentModel.BackgroundWorker();
            this.RestartTimer = new System.Windows.Forms.Timer(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // DeCript
            // 
            this.DeCript.Location = new System.Drawing.Point(13, 268);
            this.DeCript.Name = "DeCript";
            this.DeCript.Size = new System.Drawing.Size(411, 23);
            this.DeCript.TabIndex = 0;
            this.DeCript.Text = "decript everything";
            this.DeCript.UseVisualStyleBackColor = true;
            this.DeCript.Click += new System.EventHandler(this.DeCript_Click);
            // 
            // DeCriptor
            // 
            this.DeCriptor.AutoSize = true;
            this.DeCriptor.Location = new System.Drawing.Point(13, 13);
            this.DeCriptor.Name = "DeCriptor";
            this.DeCriptor.Size = new System.Drawing.Size(115, 13);
            this.DeCriptor.TabIndex = 1;
            this.DeCriptor.Text = "this is the decript0r.exe";
            // 
            // FR
            // 
            this.FR.Location = new System.Drawing.Point(349, 13);
            this.FR.Name = "FR";
            this.FR.Size = new System.Drawing.Size(75, 23);
            this.FR.TabIndex = 2;
            this.FR.Text = "force restart";
            this.FR.UseVisualStyleBackColor = true;
            this.FR.Click += new System.EventHandler(this.FR_Click);
            // 
            // RestartTimer
            // 
            this.RestartTimer.Tick += new System.EventHandler(this.RestartTimer_Tick);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 42);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Files2";
            treeNode1.Text = "Deleted Files";
            treeNode2.Name = "Files3";
            treeNode2.Text = "Recources";
            treeNode3.Name = "Files4";
            treeNode3.Text = "";
            treeNode4.Name = "Files1";
            treeNode4.Text = "Encripted Files";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(412, 207);
            this.treeView1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 303);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.FR);
            this.Controls.Add(this.DeCriptor);
            this.Controls.Add(this.DeCript);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "decrip0r";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeCript;
        private System.Windows.Forms.Label DeCriptor;
        private System.Windows.Forms.Button FR;
        private System.ComponentModel.BackgroundWorker DecriptFiles;
        private System.Windows.Forms.Timer RestartTimer;
        private System.Windows.Forms.TreeView treeView1;
    }
}