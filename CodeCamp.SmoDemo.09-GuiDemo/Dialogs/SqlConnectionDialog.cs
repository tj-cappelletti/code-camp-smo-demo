using Microsoft.SqlServer.Management.Common;
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

namespace CodeCamp.SmoDemo._09_GuiDemo.Dialogs
{
    public partial class SqlConnectionDialog : Form
    {
        private Server server;

        public Server Server
        {
            get { return server; }
        }

        public SqlConnectionDialog()
        {
            InitializeComponent();
        }

        private void authenticationTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (authenticationTypeComboBox.SelectedIndex == 0)
            {
                userNameTextBox.Enabled = false;
                userNameTextBox.Text = Environment.UserName;

                passwordTextBox.Enabled = false;
                passwordTextBox.Clear();
            }
            else
            {
                userNameTextBox.Enabled = true;
                userNameTextBox.Clear();

                passwordTextBox.Enabled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (TestConnection())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SqlConnectionForm_Load(object sender, EventArgs e)
        {
            authenticationTypeComboBox.SelectedIndex = 0;
        }

        private bool TestConnection()
        {
            ServerConnection serverConnection;

            if (authenticationTypeComboBox.SelectedIndex == 0)
            {
                serverConnection = new ServerConnection(serverNameTextBox.Text);
            }
            else
            {
                serverConnection = new ServerConnection(serverNameTextBox.Text, userNameTextBox.Text, passwordTextBox.Text);
            }

            server = new Server(serverConnection);

            bool successful = false;

            try
            {
                System.Diagnostics.Debug.WriteLine(server.Version.ToString());

                successful = true;
            }
            catch (Exception ex)
            {
                var message = "Unable to connect to " + serverNameTextBox.Text;
                ExceptionDialog exceptionDialog = new ExceptionDialog(ex, message, "Connect to Server");
                exceptionDialog.ShowDialog();
            }

            return successful;
        }
    }
}