namespace CodeCamp.SmoDemo._09_GuiDemo.Controls
{
    partial class DatabaseInformationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.detailsGroupBox = new System.Windows.Forms.GroupBox();
            this.detailsPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.databasesGroupBox = new System.Windows.Forms.GroupBox();
            this.databasesListView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.filesGroupBox = new System.Windows.Forms.GroupBox();
            this.filesListView = new System.Windows.Forms.ListView();
            this.logicalNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileTypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileGroupColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pathColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extendedPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.extendedPropertiesListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detailsGroupBox.SuspendLayout();
            this.databasesGroupBox.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.filesGroupBox.SuspendLayout();
            this.extendedPropertiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsGroupBox
            // 
            this.detailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsGroupBox.Controls.Add(this.detailsPropertyGrid);
            this.detailsGroupBox.Location = new System.Drawing.Point(400, 3);
            this.detailsGroupBox.Name = "detailsGroupBox";
            this.detailsGroupBox.Size = new System.Drawing.Size(391, 291);
            this.detailsGroupBox.TabIndex = 6;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Details";
            // 
            // detailsPropertyGrid
            // 
            this.detailsPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsPropertyGrid.Location = new System.Drawing.Point(6, 19);
            this.detailsPropertyGrid.Name = "detailsPropertyGrid";
            this.detailsPropertyGrid.Size = new System.Drawing.Size(379, 266);
            this.detailsPropertyGrid.TabIndex = 0;
            // 
            // databasesGroupBox
            // 
            this.databasesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.databasesGroupBox.Controls.Add(this.databasesListView);
            this.databasesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.databasesGroupBox.Name = "databasesGroupBox";
            this.databasesGroupBox.Size = new System.Drawing.Size(391, 291);
            this.databasesGroupBox.TabIndex = 5;
            this.databasesGroupBox.TabStop = false;
            this.databasesGroupBox.Text = "Databases";
            // 
            // databasesListView
            // 
            this.databasesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.databasesListView.Location = new System.Drawing.Point(6, 19);
            this.databasesListView.MultiSelect = false;
            this.databasesListView.Name = "databasesListView";
            this.databasesListView.Size = new System.Drawing.Size(379, 266);
            this.databasesListView.TabIndex = 0;
            this.databasesListView.UseCompatibleStateImageBehavior = false;
            this.databasesListView.View = System.Windows.Forms.View.SmallIcon;
            this.databasesListView.SelectedIndexChanged += new System.EventHandler(this.databasesListView_SelectedIndexChanged);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.databasesGroupBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.detailsGroupBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.filesGroupBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.extendedPropertiesGroupBox, 1, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(794, 594);
            this.tableLayoutPanel.TabIndex = 7;
            // 
            // filesGroupBox
            // 
            this.filesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesGroupBox.Controls.Add(this.filesListView);
            this.filesGroupBox.Location = new System.Drawing.Point(3, 300);
            this.filesGroupBox.Name = "filesGroupBox";
            this.filesGroupBox.Size = new System.Drawing.Size(391, 291);
            this.filesGroupBox.TabIndex = 7;
            this.filesGroupBox.TabStop = false;
            this.filesGroupBox.Text = "Files";
            // 
            // filesListView
            // 
            this.filesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.logicalNameColumnHeader,
            this.fileTypeColumnHeader,
            this.fileGroupColumnHeader,
            this.fileNameColumnHeader,
            this.pathColumnHeader});
            this.filesListView.FullRowSelect = true;
            this.filesListView.GridLines = true;
            this.filesListView.Location = new System.Drawing.Point(6, 19);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(379, 266);
            this.filesListView.TabIndex = 0;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.View = System.Windows.Forms.View.Details;
            // 
            // logicalNameColumnHeader
            // 
            this.logicalNameColumnHeader.Text = "Logical Name";
            this.logicalNameColumnHeader.Width = 80;
            // 
            // fileTypeColumnHeader
            // 
            this.fileTypeColumnHeader.Text = "File Type";
            // 
            // fileGroupColumnHeader
            // 
            this.fileGroupColumnHeader.Text = "File Group";
            this.fileGroupColumnHeader.Width = 80;
            // 
            // fileNameColumnHeader
            // 
            this.fileNameColumnHeader.Text = "File Name";
            // 
            // pathColumnHeader
            // 
            this.pathColumnHeader.Text = "Path";
            // 
            // extendedPropertiesGroupBox
            // 
            this.extendedPropertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extendedPropertiesGroupBox.Controls.Add(this.extendedPropertiesListView);
            this.extendedPropertiesGroupBox.Location = new System.Drawing.Point(400, 300);
            this.extendedPropertiesGroupBox.Name = "extendedPropertiesGroupBox";
            this.extendedPropertiesGroupBox.Size = new System.Drawing.Size(391, 291);
            this.extendedPropertiesGroupBox.TabIndex = 8;
            this.extendedPropertiesGroupBox.TabStop = false;
            this.extendedPropertiesGroupBox.Text = "Extended Properties";
            // 
            // extendedPropertiesListView
            // 
            this.extendedPropertiesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extendedPropertiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.valueColumnHeader});
            this.extendedPropertiesListView.FullRowSelect = true;
            this.extendedPropertiesListView.GridLines = true;
            this.extendedPropertiesListView.Location = new System.Drawing.Point(6, 19);
            this.extendedPropertiesListView.Name = "extendedPropertiesListView";
            this.extendedPropertiesListView.Size = new System.Drawing.Size(379, 266);
            this.extendedPropertiesListView.TabIndex = 0;
            this.extendedPropertiesListView.UseCompatibleStateImageBehavior = false;
            this.extendedPropertiesListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 160;
            // 
            // valueColumnHeader
            // 
            this.valueColumnHeader.Text = "Value";
            this.valueColumnHeader.Width = 210;
            // 
            // DatabaseInformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "DatabaseInformationControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.detailsGroupBox.ResumeLayout(false);
            this.databasesGroupBox.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.filesGroupBox.ResumeLayout(false);
            this.extendedPropertiesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox detailsGroupBox;
        private System.Windows.Forms.PropertyGrid detailsPropertyGrid;
        private System.Windows.Forms.GroupBox databasesGroupBox;
        private System.Windows.Forms.ListView databasesListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox filesGroupBox;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.ColumnHeader logicalNameColumnHeader;
        private System.Windows.Forms.ColumnHeader fileTypeColumnHeader;
        private System.Windows.Forms.ColumnHeader fileNameColumnHeader;
        private System.Windows.Forms.ColumnHeader pathColumnHeader;
        private System.Windows.Forms.GroupBox extendedPropertiesGroupBox;
        private System.Windows.Forms.ListView extendedPropertiesListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader valueColumnHeader;
        private System.Windows.Forms.ColumnHeader fileGroupColumnHeader;
    }
}
