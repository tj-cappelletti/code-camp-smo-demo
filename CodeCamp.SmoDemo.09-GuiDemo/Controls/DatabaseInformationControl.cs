using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CodeCamp.SmoDemo._09_GuiDemo.Properties;
using Microsoft.SqlServer.Management.Smo;
using CodeCamp.SmoDemo._09_GuiDemo.Information;

namespace CodeCamp.SmoDemo._09_GuiDemo.Controls
{
    public partial class DatabaseInformationControl : UserControl
    {
        private ImageList databaseObjectIconsImageList;

        private Server server;

        public Server Server
        {
            get { return this.server; }
            set
            {
                server = value;

                if (value != null)
                    BindDatabases();
            }
        }

        public DatabaseInformationControl()
        {
            InitializeComponent();

            databaseObjectIconsImageList = new ImageList();
            databaseObjectIconsImageList.Images.Add((Image)Resource.DatabaseIcon);

            databasesListView.SmallImageList = databaseObjectIconsImageList;
        }

        private void BindDatabases()
        {
            foreach (Database database in server.Databases)
            {
                databasesListView.Items.Add(database.Name, database.Name, 0);
            }
        }

        private void databasesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database selectedDatabase = null;

            if (databasesListView.SelectedIndices.Count == 1)
            {
                selectedDatabase = server.Databases[databasesListView.SelectedItems[0].Name];
            }

            BindDatabaseDetails(selectedDatabase);
            BindDatabaseExtendedProperties(selectedDatabase);
            BindDatabaseFiles(selectedDatabase);
        }

        private void BindDatabaseDetails(Database selectedDatabase)
        {
            if (selectedDatabase == null)
            {
                detailsPropertyGrid.SelectedObject = null;
            }
            else
            {
                DatabaseInformation databaseInformation = new DatabaseInformation(selectedDatabase);
                detailsPropertyGrid.SelectedObject = databaseInformation;
            }
        }

        private void BindDatabaseExtendedProperties(Database selectedDatabase)
        {
            if (selectedDatabase == null)
            {
                extendedPropertiesListView.Items.Clear();
            }
            else
            {
                foreach (ExtendedProperty extendedProperty in selectedDatabase.ExtendedProperties)
                {
                    ListViewItem listViewItem = new ListViewItem(extendedProperty.Name);
                    listViewItem.SubItems.Add(extendedProperty.Value.ToString());
                    extendedPropertiesListView.Items.Add(listViewItem);
                }
            }
        }

        private void BindDatabaseFiles(Database selectedDatabase)
        {
            if (selectedDatabase == null)
            {
                filesListView.Items.Clear();
            }
            else
            {
                foreach (FileGroup fileGroup in selectedDatabase.FileGroups)
                {
                    foreach (DataFile dataFile in fileGroup.Files)
                    {
                        ListViewItem listViewItem = new ListViewItem(dataFile.Name);
                        listViewItem.SubItems.Add("Data");
                        listViewItem.SubItems.Add(fileGroup.Name);
                        listViewItem.SubItems.Add(Path.GetFileName(dataFile.FileName));
                        listViewItem.SubItems.Add(Path.GetDirectoryName(dataFile.FileName));

                        filesListView.Items.Add(listViewItem);
                    }
                }

                foreach (LogFile logFile in selectedDatabase.LogFiles)
                {
                    ListViewItem listViewItem = new ListViewItem(logFile.Name);
                    listViewItem.SubItems.Add("Log");
                    listViewItem.SubItems.Add(String.Empty);
                    listViewItem.SubItems.Add(Path.GetFileName(logFile.FileName));
                    listViewItem.SubItems.Add(Path.GetDirectoryName(logFile.FileName));

                    filesListView.Items.Add(listViewItem);
                }

                filesListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
                filesListView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }
    }
}