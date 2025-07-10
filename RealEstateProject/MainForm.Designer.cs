using System.Drawing;
using System.Windows.Forms;
namespace RealEstateProject
{
    partial class MDIMainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIMainForm));
            Menustrip = new MenuStrip();
            menuClient = new ToolStripMenuItem();
            menuAddClient = new ToolStripMenuItem();
            menuDeleteClient = new ToolStripMenuItem();
            menuSearchClient = new ToolStripMenuItem();
            menuUpdateClient = new ToolStripMenuItem();
            menuOwner = new ToolStripMenuItem();
            menuAddOwner = new ToolStripMenuItem();
            menuDeleteOwner = new ToolStripMenuItem();
            menuSearchOwner = new ToolStripMenuItem();
            menuUpdateOwner = new ToolStripMenuItem();
            menuProperty = new ToolStripMenuItem();
            menuAddProperty = new ToolStripMenuItem();
            menuDeleteProperty = new ToolStripMenuItem();
            menuSearchProperty = new ToolStripMenuItem();
            menuUpdateProperty = new ToolStripMenuItem();
            menuRental = new ToolStripMenuItem();
            menuAddRental = new ToolStripMenuItem();
            menuDeleteRental = new ToolStripMenuItem();
            menuSearchRental = new ToolStripMenuItem();
            menuUpdateRental = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            newWindowToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            toolBarToolStripMenuItem = new ToolStripMenuItem();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            printSetupToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            Menustrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // Menustrip
            // 
            Menustrip.Items.AddRange(new ToolStripItem[] { menuClient, menuOwner, menuProperty, menuRental, menuExit });
            Menustrip.Location = new Point(0, 0);
            Menustrip.Name = "Menustrip";
            Menustrip.Padding = new Padding(7, 2, 0, 2);
            Menustrip.Size = new Size(737, 24);
            Menustrip.TabIndex = 0;
            Menustrip.Text = "MenuStrip";
            // 
            // menuClient
            // 
            menuClient.BackColor = Color.FromArgb(128, 128, 255);
            menuClient.DropDownItems.AddRange(new ToolStripItem[] { menuAddClient, menuDeleteClient, menuSearchClient, menuUpdateClient });
            menuClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuClient.Name = "menuClient";
            menuClient.Size = new Size(51, 20);
            menuClient.Text = "Client";
            // 
            // menuAddClient
            // 
            menuAddClient.Name = "menuAddClient";
            menuAddClient.Size = new Size(115, 22);
            menuAddClient.Text = "Add";
            menuAddClient.Click += menuAddClient_Click;
            // 
            // menuDeleteClient
            // 
            menuDeleteClient.Name = "menuDeleteClient";
            menuDeleteClient.Size = new Size(115, 22);
            menuDeleteClient.Text = "Delete";
            menuDeleteClient.Click += menuDeleteClient_Click;
            // 
            // menuSearchClient
            // 
            menuSearchClient.Name = "menuSearchClient";
            menuSearchClient.Size = new Size(115, 22);
            menuSearchClient.Text = "Search ";
            menuSearchClient.Click += menuSearchClient_Click;
            // 
            // menuUpdateClient
            // 
            menuUpdateClient.Name = "menuUpdateClient";
            menuUpdateClient.Size = new Size(115, 22);
            menuUpdateClient.Text = "Update";
            menuUpdateClient.Click += menuUpdateClient_Click;
            // 
            // menuOwner
            // 
            menuOwner.BackColor = Color.Lime;
            menuOwner.DropDownItems.AddRange(new ToolStripItem[] { menuAddOwner, menuDeleteOwner, menuSearchOwner, menuUpdateOwner });
            menuOwner.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuOwner.Name = "menuOwner";
            menuOwner.Size = new Size(109, 20);
            menuOwner.Text = "Property Owner";
            // 
            // menuAddOwner
            // 
            menuAddOwner.Name = "menuAddOwner";
            menuAddOwner.Size = new Size(115, 22);
            menuAddOwner.Text = "Add";
            menuAddOwner.Click += menuAddOwner_Click;
            // 
            // menuDeleteOwner
            // 
            menuDeleteOwner.Name = "menuDeleteOwner";
            menuDeleteOwner.Size = new Size(115, 22);
            menuDeleteOwner.Text = "Delete";
            menuDeleteOwner.Click += menuDeleteOwner_Click;
            // 
            // menuSearchOwner
            // 
            menuSearchOwner.Name = "menuSearchOwner";
            menuSearchOwner.Size = new Size(115, 22);
            menuSearchOwner.Text = "Search";
            menuSearchOwner.Click += menuSearchOwner_Click;
            // 
            // menuUpdateOwner
            // 
            menuUpdateOwner.Name = "menuUpdateOwner";
            menuUpdateOwner.Size = new Size(115, 22);
            menuUpdateOwner.Text = "Update";
            menuUpdateOwner.Click += menuUpdateOwner_Click;
            // 
            // menuProperty
            // 
            menuProperty.BackColor = Color.Cyan;
            menuProperty.DropDownItems.AddRange(new ToolStripItem[] { menuAddProperty, menuDeleteProperty, menuSearchProperty, menuUpdateProperty });
            menuProperty.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuProperty.Name = "menuProperty";
            menuProperty.Size = new Size(71, 20);
            menuProperty.Text = " Property";
            // 
            // menuAddProperty
            // 
            menuAddProperty.Name = "menuAddProperty";
            menuAddProperty.Size = new Size(180, 22);
            menuAddProperty.Text = "Add";
            menuAddProperty.Click += menuAddProperty_Click;
            // 
            // menuDeleteProperty
            // 
            menuDeleteProperty.Name = "menuDeleteProperty";
            menuDeleteProperty.Size = new Size(180, 22);
            menuDeleteProperty.Text = "Delete";
            menuDeleteProperty.Click += menuDeleteProperty_Click;
            // 
            // menuSearchProperty
            // 
            menuSearchProperty.Name = "menuSearchProperty";
            menuSearchProperty.Size = new Size(180, 22);
            menuSearchProperty.Text = "Search";
            menuSearchProperty.Click += menuSearchProperty_Click;
            // 
            // menuUpdateProperty
            // 
            menuUpdateProperty.Name = "menuUpdateProperty";
            menuUpdateProperty.Size = new Size(180, 22);
            menuUpdateProperty.Text = "Update";
            menuUpdateProperty.Click += menuUpdateProperty_Click;
            // 
            // menuRental
            // 
            menuRental.BackColor = Color.Yellow;
            menuRental.DropDownItems.AddRange(new ToolStripItem[] { menuAddRental, menuDeleteRental, menuSearchRental, menuUpdateRental });
            menuRental.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuRental.Name = "menuRental";
            menuRental.Size = new Size(107, 20);
            menuRental.Text = "Rent a Property";
            // 
            // menuAddRental
            // 
            menuAddRental.Name = "menuAddRental";
            menuAddRental.Size = new Size(195, 22);
            menuAddRental.Text = "Add Rental Details";
            menuAddRental.Click += menuAddRental_Click;
            // 
            // menuDeleteRental
            // 
            menuDeleteRental.Name = "menuDeleteRental";
            menuDeleteRental.Size = new Size(195, 22);
            menuDeleteRental.Text = "Delete Rental Details";
            menuDeleteRental.Click += menuDeleteRental_Click;
            // 
            // menuSearchRental
            // 
            menuSearchRental.Name = "menuSearchRental";
            menuSearchRental.Size = new Size(195, 22);
            menuSearchRental.Text = "Search Rental Details";
            menuSearchRental.Click += menuSearchRental_Click;
            // 
            // menuUpdateRental
            // 
            menuUpdateRental.Name = "menuUpdateRental";
            menuUpdateRental.Size = new Size(195, 22);
            menuUpdateRental.Text = "Update Rental Details";
            menuUpdateRental.Click += menuUpdateRental_Click;
            // 
            // menuExit
            // 
            menuExit.BackColor = Color.Red;
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(38, 20);
            menuExit.Text = "Exit";
            // 
            // toolStrip
            // 
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(737, 25);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 501);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(737, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F1;
            contentsToolStripMenuItem.Size = new Size(168, 22);
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Image = (Image)resources.GetObject("indexToolStripMenuItem.Image");
            indexToolStripMenuItem.ImageTransparentColor = Color.Black;
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(168, 22);
            indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Image = (Image)resources.GetObject("searchToolStripMenuItem.Image");
            searchToolStripMenuItem.ImageTransparentColor = Color.Black;
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(168, 22);
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(165, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(168, 22);
            aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.Size = new Size(150, 22);
            newWindowToolStripMenuItem.Text = "&New Window";
            newWindowToolStripMenuItem.Click += ShowNewForm;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(150, 22);
            cascadeToolStripMenuItem.Text = "&Cascade";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(150, 22);
            tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            tileVerticalToolStripMenuItem.Click += TileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(150, 22);
            tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            tileHorizontalToolStripMenuItem.Click += TileHorizontalToolStripMenuItem_Click;
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(150, 22);
            closeAllToolStripMenuItem.Text = "C&lose All";
            closeAllToolStripMenuItem.Click += CloseAllToolStripMenuItem_Click;
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(150, 22);
            arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            arrangeIconsToolStripMenuItem.Click += ArrangeIconsToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(180, 22);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // toolBarToolStripMenuItem
            // 
            toolBarToolStripMenuItem.Checked = true;
            toolBarToolStripMenuItem.CheckOnClick = true;
            toolBarToolStripMenuItem.CheckState = CheckState.Checked;
            toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            toolBarToolStripMenuItem.Size = new Size(126, 22);
            toolBarToolStripMenuItem.Text = "&Toolbar";
            toolBarToolStripMenuItem.Click += ToolBarToolStripMenuItem_Click;
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.CheckOnClick = true;
            statusBarToolStripMenuItem.CheckState = CheckState.Checked;
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new Size(126, 22);
            statusBarToolStripMenuItem.Text = "&Status Bar";
            statusBarToolStripMenuItem.Click += StatusBarToolStripMenuItem_Click;
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Image = (Image)resources.GetObject("undoToolStripMenuItem.Image");
            undoToolStripMenuItem.ImageTransparentColor = Color.Black;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(164, 22);
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Image = (Image)resources.GetObject("redoToolStripMenuItem.Image");
            redoToolStripMenuItem.ImageTransparentColor = Color.Black;
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(164, 22);
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(161, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = Color.Black;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(164, 22);
            cutToolStripMenuItem.Text = "Cu&t";
            cutToolStripMenuItem.Click += CutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = Color.Black;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(164, 22);
            copyToolStripMenuItem.Text = "&Copy";
            copyToolStripMenuItem.Click += CopyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = Color.Black;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(164, 22);
            pasteToolStripMenuItem.Text = "&Paste";
            pasteToolStripMenuItem.Click += PasteToolStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(161, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(164, 22);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Black;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += ShowNewForm;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Black;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += OpenFile;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Black;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save &As";
            saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.ImageTransparentColor = Color.Black;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(180, 22);
            printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
            printPreviewToolStripMenuItem.ImageTransparentColor = Color.Black;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(180, 22);
            printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // printSetupToolStripMenuItem
            // 
            printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
            printSetupToolStripMenuItem.Size = new Size(180, 22);
            printSetupToolStripMenuItem.Text = "Print Setup";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += ExitToolsStripMenuItem_Click;
            // 
            // MDIMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 523);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(Menustrip);
            IsMdiContainer = true;
            MainMenuStrip = Menustrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MDIMainForm";
            Text = "Real Estate Rental Management System";
            WindowState = FormWindowState.Maximized;
            Menustrip.ResumeLayout(false);
            Menustrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip Menustrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem newWindowToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileVerticalToolStripMenuItem;
        private ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private ToolStripMenuItem closeAllToolStripMenuItem;
        private ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem toolBarToolStripMenuItem;
        private ToolStripMenuItem statusBarToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripMenuItem printSetupToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem menuClient;
        private ToolStripMenuItem menuOwner;
        private ToolStripMenuItem menuProperty;
        private ToolStripMenuItem menuRental;
        private ToolStripMenuItem menuAddClient;
        private ToolStripMenuItem menuDeleteClient;
        private ToolStripMenuItem menuSearchClient;
        private ToolStripMenuItem menuUpdateClient;
        private ToolStripMenuItem menuAddOwner;
        private ToolStripMenuItem menuDeleteOwner;
        private ToolStripMenuItem menuSearchOwner;
        private ToolStripMenuItem menuUpdateOwner;
        private ToolStripMenuItem menuAddProperty;
        private ToolStripMenuItem menuDeleteProperty;
        private ToolStripMenuItem menuSearchProperty;
        private ToolStripMenuItem menuUpdateProperty;
        private ToolStripMenuItem menuAddRental;
        private ToolStripMenuItem menuDeleteRental;
        private ToolStripMenuItem menuSearchRental;
        private ToolStripMenuItem menuUpdateRental;
        private ToolStripMenuItem menuExit;
    }
}



