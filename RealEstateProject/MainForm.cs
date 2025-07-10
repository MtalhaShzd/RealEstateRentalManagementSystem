using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateProject
{
    public partial class MDIMainForm : Form
    {
        private int childFormNumber = 0;

        public MDIMainForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuAddClient_Click(object sender, EventArgs e)
        {
            // Check if already open (optional, to prevent multiple instances)
            foreach (Form child in this.MdiChildren)
            {
                if (child is AddClientForm)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            AddClientForm addClientForm = new AddClientForm();
            addClientForm.MdiParent = this;      //  Set parent
            addClientForm.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addClientForm.Show();                // Show inside MDI container
        }
        private void menuAddOwner_Click(object sender, EventArgs e)
        {
            // Check if already open (optional, to prevent multiple instances)
            foreach (Form child in this.MdiChildren)
            {
                if (child is AddOwnerForm)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            AddOwnerForm addOwnerForm = new AddOwnerForm();
            addOwnerForm.MdiParent = this;      //  Set parent
            addOwnerForm.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addOwnerForm.Show();                // Show inside MDI container
        }
        private void menuAddProperty_Click(object sender, EventArgs e)
        {
            // Check if already open (optional, to prevent multiple instances)
            foreach (Form child in this.MdiChildren)
            {
                if (child is AddPropertyForm)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            AddPropertyForm addPropertyForm = new AddPropertyForm();
            addPropertyForm.MdiParent = this;      //  Set parent
            addPropertyForm.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addPropertyForm.Show();                // Show inside MDI container
        }

        private void menuAddRental_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is AddClientRental)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            AddClientRental addClientRental = new AddClientRental();
            addClientRental.MdiParent = this;      //  Set parent
            addClientRental.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addClientRental.Show();
        }

        private void menuSearchProperty_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is SearchPropertyForm)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            SearchPropertyForm addSearchProperty = new SearchPropertyForm();
            addSearchProperty.MdiParent = this;      //  Set parent
            addSearchProperty.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addSearchProperty.Show();
        }

        private void menuSearchClient_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is SearchClientForm)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            SearchClientForm addSearchClient = new SearchClientForm();
            addSearchClient.MdiParent = this;      //  Set parent
            addSearchClient.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addSearchClient.Show();
        }

        private void menuSearchOwner_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is SearchOwnerForm)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            SearchOwnerForm addSearchOwner = new SearchOwnerForm();
            addSearchOwner.MdiParent = this;      //  Set parent
            addSearchOwner.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addSearchOwner.Show();
        }

        private void menuSearchRental_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is SearchClientRentalForm)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            SearchClientRentalForm addSearchClientRental = new SearchClientRentalForm();
            addSearchClientRental.MdiParent = this;      //  Set parent
            addSearchClientRental.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addSearchClientRental.Show();
        }

        private void menuDeleteProperty_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is DeletePropertyForm)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            DeletePropertyForm addDeleteProperty = new DeletePropertyForm();
            addDeleteProperty.MdiParent = this;      //  Set parent
            addDeleteProperty.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addDeleteProperty.Show();
        }

        private void menuDeleteClient_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is DeleteClientForm)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            DeleteClientForm addDeleteClient = new DeleteClientForm();
            addDeleteClient.MdiParent = this;      //  Set parent
            addDeleteClient.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addDeleteClient.Show();
        }

        private void menuDeleteOwner_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is DeleteOwnerForm)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            DeleteOwnerForm addDeleteOwner = new DeleteOwnerForm();
            addDeleteOwner.MdiParent = this;      //  Set parent
            addDeleteOwner.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addDeleteOwner.Show();
        }

        private void menuDeleteRental_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is DeleteClientRentalForm)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            DeleteClientRentalForm addDeleteClientRental = new DeleteClientRentalForm();
            addDeleteClientRental.MdiParent = this;      //  Set parent
            addDeleteClientRental.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addDeleteClientRental.Show();
        }

        private void menuUpdateClient_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is UpdateClientForm)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            UpdateClientForm addUpdateClient = new UpdateClientForm();
            addUpdateClient.MdiParent = this;      //  Set parent
            addUpdateClient.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addUpdateClient.Show();
        }

        private void menuUpdateOwner_Click(object sender, EventArgs e)
        {

            foreach (Form child in this.MdiChildren)
            {
                if (child is UpdateOwnerForm)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            UpdateOwnerForm addUpdateOwner = new UpdateOwnerForm();
            addUpdateOwner.MdiParent = this;      //  Set parent
            addUpdateOwner.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addUpdateOwner.Show();

        }

        private void menuUpdateProperty_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is UpdatePropertyForm)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            UpdatePropertyForm addUpdateProperty = new UpdatePropertyForm();
            addUpdateProperty.MdiParent = this;      //  Set parent
            addUpdateProperty.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addUpdateProperty.Show();
        }

        private void menuUpdateRental_Click(object sender, EventArgs e)
        {
            foreach(Form child in this.MdiChildren)
            {
                if (child is UpdateClientRental)
                {
                    child.Activate(); // Bring to front if already open
                    return;
                }
            }

            UpdateClientRental addUpdateClientRental = new UpdateClientRental();
            addUpdateClientRental.MdiParent = this;      //  Set parent
            addUpdateClientRental.WindowState = FormWindowState.Maximized; // Optional: open maximized
            addUpdateClientRental.Show();
        }
    }
}
