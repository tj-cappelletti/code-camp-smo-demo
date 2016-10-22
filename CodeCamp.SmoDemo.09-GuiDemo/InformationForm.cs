using CodeCamp.SmoDemo._09_GuiDemo.Dialogs;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCamp.SmoDemo._09_GuiDemo
{
    public partial class InformationForm : Form
    {
        private const string ServerEditionToolStripText = "Edition: {0}";
        private const string ServerNameToolStripText = "Server: {0}";
        private const string ServerVersionToolStripText = "Version: {0}";

        private Server server;

        public InformationForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlConnectionDialog sqlConnectionDialog = new SqlConnectionDialog();

            if (sqlConnectionDialog.ShowDialog() == DialogResult.OK)
            {
                server = sqlConnectionDialog.Server;

                databaseInformationControl.Server = server;

                serverEditionToolStripStatusLabel.Text = String.Format(ServerEditionToolStripText, server.Edition);
                serverNameToolStripStatusLabel.Text = String.Format(ServerNameToolStripText, server.Name);
                serverVersionToolStripStatusLabel.Text = String.Format(ServerVersionToolStripText, server.Version);
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
