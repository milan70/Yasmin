namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.groupBoxAVVer = new System.Windows.Forms.GroupBox();
            this.buttonTestRun = new System.Windows.Forms.Button();
            this.buttonDirBrowse = new System.Windows.Forms.Button();
            this.textBoxAVVer = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogAVVer = new System.Windows.Forms.FolderBrowserDialog();
            this.treeViewAV = new System.Windows.Forms.TreeView();
            this.textBoxGeneratedString = new System.Windows.Forms.TextBox();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.labelReplace = new System.Windows.Forms.Label();
            this.labelReplaceWith = new System.Windows.Forms.Label();
            this.textBoxReplaceWith = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxAVVer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAVVer
            // 
            this.groupBoxAVVer.Controls.Add(this.buttonTestRun);
            this.groupBoxAVVer.Controls.Add(this.buttonDirBrowse);
            this.groupBoxAVVer.Controls.Add(this.textBoxAVVer);
            this.groupBoxAVVer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAVVer.Name = "groupBoxAVVer";
            this.groupBoxAVVer.Size = new System.Drawing.Size(769, 75);
            this.groupBoxAVVer.TabIndex = 0;
            this.groupBoxAVVer.TabStop = false;
            this.groupBoxAVVer.Text = "AV Vesion";
            // 
            // buttonTestRun
            // 
            this.buttonTestRun.Location = new System.Drawing.Point(15, 45);
            this.buttonTestRun.Name = "buttonTestRun";
            this.buttonTestRun.Size = new System.Drawing.Size(175, 23);
            this.buttonTestRun.TabIndex = 2;
            this.buttonTestRun.Text = "HarvestFiles";
            this.buttonTestRun.UseVisualStyleBackColor = true;
            this.buttonTestRun.Click += new System.EventHandler(this.buttonTestRun_Click);
            // 
            // buttonDirBrowse
            // 
            this.buttonDirBrowse.Location = new System.Drawing.Point(724, 17);
            this.buttonDirBrowse.Name = "buttonDirBrowse";
            this.buttonDirBrowse.Size = new System.Drawing.Size(29, 23);
            this.buttonDirBrowse.TabIndex = 1;
            this.buttonDirBrowse.Text = "...";
            this.buttonDirBrowse.UseVisualStyleBackColor = true;
            this.buttonDirBrowse.Click += new System.EventHandler(this.buttonDirBrowse_Click);
            // 
            // textBoxAVVer
            // 
            this.textBoxAVVer.Location = new System.Drawing.Point(15, 19);
            this.textBoxAVVer.Name = "textBoxAVVer";
            this.textBoxAVVer.Size = new System.Drawing.Size(703, 20);
            this.textBoxAVVer.TabIndex = 0;
            // 
            // treeViewAV
            // 
            this.treeViewAV.Location = new System.Drawing.Point(787, 17);
            this.treeViewAV.Name = "treeViewAV";
            this.treeViewAV.Size = new System.Drawing.Size(200, 650);
            this.treeViewAV.TabIndex = 1;
            // 
            // textBoxGeneratedString
            // 
            this.textBoxGeneratedString.Location = new System.Drawing.Point(12, 158);
            this.textBoxGeneratedString.Multiline = true;
            this.textBoxGeneratedString.Name = "textBoxGeneratedString";
            this.textBoxGeneratedString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxGeneratedString.Size = new System.Drawing.Size(755, 509);
            this.textBoxGeneratedString.TabIndex = 2;
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(102, 93);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(663, 20);
            this.textBoxReplace.TabIndex = 3;
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Location = new System.Drawing.Point(24, 96);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(47, 13);
            this.labelReplace.TabIndex = 4;
            this.labelReplace.Text = "Replace";
            // 
            // labelReplaceWith
            // 
            this.labelReplaceWith.AutoSize = true;
            this.labelReplaceWith.Location = new System.Drawing.Point(24, 122);
            this.labelReplaceWith.Name = "labelReplaceWith";
            this.labelReplaceWith.Size = new System.Drawing.Size(69, 13);
            this.labelReplaceWith.TabIndex = 6;
            this.labelReplaceWith.Text = "Replace with";
            // 
            // textBoxReplaceWith
            // 
            this.textBoxReplaceWith.Location = new System.Drawing.Point(102, 119);
            this.textBoxReplaceWith.Name = "textBoxReplaceWith";
            this.textBoxReplaceWith.Size = new System.Drawing.Size(663, 20);
            this.textBoxReplaceWith.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(673, 673);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 703);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelReplaceWith);
            this.Controls.Add(this.textBoxReplaceWith);
            this.Controls.Add(this.labelReplace);
            this.Controls.Add(this.textBoxReplace);
            this.Controls.Add(this.textBoxGeneratedString);
            this.Controls.Add(this.treeViewAV);
            this.Controls.Add(this.groupBoxAVVer);
            this.Name = "MainForm";
            this.Text = "AV Test";
            this.groupBoxAVVer.ResumeLayout(false);
            this.groupBoxAVVer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAVVer;
        private System.Windows.Forms.Button buttonTestRun;
        private System.Windows.Forms.Button buttonDirBrowse;
        private System.Windows.Forms.TextBox textBoxAVVer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogAVVer;
        private System.Windows.Forms.TreeView treeViewAV;
        private System.Windows.Forms.TextBox textBoxGeneratedString;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.Label labelReplace;
        private System.Windows.Forms.Label labelReplaceWith;
        private System.Windows.Forms.TextBox textBoxReplaceWith;
        private System.Windows.Forms.Button buttonSave;
    }
}

