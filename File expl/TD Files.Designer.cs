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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.labelTreeView = new System.Windows.Forms.Label();
            this.labelListView = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelPictureBox = new System.Windows.Forms.Label();
            this.labelTextBox = new System.Windows.Forms.Label();
            this.labelPropertyGrid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(16, 34);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(207, 523);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(232, 34);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(284, 523);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(232, 566);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(284, 22);
            this.textBoxFilter.TabIndex = 2;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(525, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(525, 304);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(524, 254);
            this.textBox1.TabIndex = 4;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(1059, 34);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(267, 524);
            this.propertyGrid1.TabIndex = 5;
            // 
            // labelTreeView
            // 
            this.labelTreeView.AutoSize = true;
            this.labelTreeView.Location = new System.Drawing.Point(16, 11);
            this.labelTreeView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTreeView.Name = "labelTreeView";
            this.labelTreeView.Size = new System.Drawing.Size(41, 16);
            this.labelTreeView.TabIndex = 6;
            this.labelTreeView.Text = "Disks";
            // 
            // labelListView
            // 
            this.labelListView.AutoSize = true;
            this.labelListView.Location = new System.Drawing.Point(232, 11);
            this.labelListView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListView.Name = "labelListView";
            this.labelListView.Size = new System.Drawing.Size(101, 16);
            this.labelListView.TabIndex = 7;
            this.labelListView.Text = "Folder Contents";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(232, 546);
            this.labelFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(36, 16);
            this.labelFilter.TabIndex = 8;
            this.labelFilter.Text = "Filter";
            // 
            // labelPictureBox
            // 
            this.labelPictureBox.AutoSize = true;
            this.labelPictureBox.Location = new System.Drawing.Point(525, 11);
            this.labelPictureBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPictureBox.Name = "labelPictureBox";
            this.labelPictureBox.Size = new System.Drawing.Size(45, 16);
            this.labelPictureBox.TabIndex = 9;
            this.labelPictureBox.Text = "Image";
            // 
            // labelTextBox
            // 
            this.labelTextBox.AutoSize = true;
            this.labelTextBox.Location = new System.Drawing.Point(525, 284);
            this.labelTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextBox.Name = "labelTextBox";
            this.labelTextBox.Size = new System.Drawing.Size(58, 16);
            this.labelTextBox.TabIndex = 10;
            this.labelTextBox.Text = "Text File";
            // 
            // labelPropertyGrid
            // 
            this.labelPropertyGrid.AutoSize = true;
            this.labelPropertyGrid.Location = new System.Drawing.Point(1059, 11);
            this.labelPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPropertyGrid.Name = "labelPropertyGrid";
            this.labelPropertyGrid.Size = new System.Drawing.Size(69, 16);
            this.labelPropertyGrid.TabIndex = 11;
            this.labelPropertyGrid.Text = "Properties";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "©2024 Tolia Driapak";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPropertyGrid);
            this.Controls.Add(this.labelTextBox);
            this.Controls.Add(this.labelPictureBox);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelListView);
            this.Controls.Add(this.labelTreeView);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    // Form components
    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.TextBox textBoxFilter;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.PropertyGrid propertyGrid1;
    private System.Windows.Forms.Label labelTreeView;
    private System.Windows.Forms.Label labelListView;
    private System.Windows.Forms.Label labelFilter;
    private System.Windows.Forms.Label labelPictureBox;
    private System.Windows.Forms.Label labelTextBox;
    private System.Windows.Forms.Label labelPropertyGrid;
    private System.Windows.Forms.Label label1;
}
