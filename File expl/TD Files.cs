using System;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Load drives into the TreeView during form load
        foreach (var drive in DriveInfo.GetDrives())
        {
            TreeNode node = new TreeNode(drive.Name);
            node.Tag = drive;
            treeView1.Nodes.Add(node);
        }
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
        // Event handler for TreeView node selection
        TreeNode selectedNode = e.Node;
        propertyGrid1.SelectedObject = selectedNode.Tag;

        // Check the type of selected node
        if (selectedNode.Tag is DriveInfo driveInfo)
        {
            // Load directories and files for drives
            LoadDirectoriesAndFiles(selectedNode, driveInfo.RootDirectory);
        }
        else if (selectedNode.Tag is DirectoryInfo dirInfo)
        {
            // Load directories and files for directories
            LoadDirectoriesAndFiles(selectedNode, dirInfo);
        }
        else if (selectedNode.Tag is FileInfo fileInfo)
        {
            // Display file contents for text, image files, and show security attributes
            if (fileInfo.Extension == ".txt")
            {
                textBox1.Text = File.ReadAllText(fileInfo.FullName);
            }
            else if (fileInfo.Extension == ".jpg" || fileInfo.Extension == ".png" || fileInfo.Extension == ".bmp")
            {
                pictureBox1.Image = Image.FromFile(fileInfo.FullName);
            }

            ShowSecurityAttributes(fileInfo);
        }
    }

    private void LoadDirectoriesAndFiles(TreeNode node, DirectoryInfo directory)
    {
        // Load directories and files into the TreeView node
        node.Nodes.Clear();

        try
        {
            foreach (var dir in directory.GetDirectories())
            {
                TreeNode dirNode = new TreeNode(dir.Name);
                dirNode.Tag = dir;
                node.Nodes.Add(dirNode);
            }

            foreach (var file in directory.GetFiles())
            {
                TreeNode fileNode = new TreeNode(file.Name);
                fileNode.Tag = file;
                node.Nodes.Add(fileNode);
            }
        }
        catch (UnauthorizedAccessException) { }
    }

    private void textBoxFilter_TextChanged(object sender, EventArgs e)
    {
        // Filter files and directories based on the text in the filter TextBox
        string filter = textBoxFilter.Text.ToLower();
        TreeNode selectedNode = treeView1.SelectedNode;

        if (selectedNode != null && selectedNode.Tag is DirectoryInfo dirInfo)
        {
            listView1.Items.Clear();
            foreach (var dir in dirInfo.GetDirectories())
            {
                if (dir.Name.ToLower().Contains(filter))
                {
                    listView1.Items.Add(new ListViewItem(dir.Name) { Tag = dir });
                }
            }

            foreach (var file in dirInfo.GetFiles())
            {
                if (file.Name.ToLower().Contains(filter))
                {
                    listView1.Items.Add(new ListViewItem(file.Name) { Tag = file });
                }
            }
        }
    }

    private void ShowSecurityAttributes(FileSystemInfo fileSystemInfo)
    {
        // Show security attributes for files and directories
        if (fileSystemInfo is FileInfo fileInfo)
        {
            var security = fileInfo.GetAccessControl();
            var rules = security.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));
            foreach (FileSystemAccessRule rule in rules)
            {
                Console.WriteLine($"Identity: {rule.IdentityReference}, Access Control Type: {rule.AccessControlType}, Rights: {rule.FileSystemRights}");
            }
        }
        else if (fileSystemInfo is DirectoryInfo dirInfo)
        {
            var security = dirInfo.GetAccessControl();
            var rules = security.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));
            foreach (FileSystemAccessRule rule in rules)
            {
                Console.WriteLine($"Identity: {rule.IdentityReference}, Access Control Type: {rule.AccessControlType}, Rights: {rule.FileSystemRights}");
            }
        }
    }
}
