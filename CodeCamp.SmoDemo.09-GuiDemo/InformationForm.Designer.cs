namespace CodeCamp.SmoDemo._09_GuiDemo
{
    partial class InformationForm
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.serverNameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.serverVersionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.serverEditionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.databaseInformationControl = new CodeCamp.SmoDemo._09_GuiDemo.Controls.DatabaseInformationControl();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverNameToolStripStatusLabel,
            this.serverVersionToolStripStatusLabel,
            this.serverEditionToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 537);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 24);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "Status Strip";
            // 
            // serverNameToolStripStatusLabel
            // 
            this.serverNameToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.serverNameToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.serverNameToolStripStatusLabel.Name = "serverNameToolStripStatusLabel";
            this.serverNameToolStripStatusLabel.Size = new System.Drawing.Size(117, 19);
            this.serverNameToolStripStatusLabel.Text = "Server: LOCALHOST";
            // 
            // serverVersionToolStripStatusLabel
            // 
            this.serverVersionToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.serverVersionToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.serverVersionToolStripStatusLabel.Name = "serverVersionToolStripStatusLabel";
            this.serverVersionToolStripStatusLabel.Size = new System.Drawing.Size(113, 19);
            this.serverVersionToolStripStatusLabel.Text = "Version: 99.99.99.99";
            // 
            // serverEditionToolStripStatusLabel
            // 
            this.serverEditionToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.serverEditionToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.serverEditionToolStripStatusLabel.Name = "serverEditionToolStripStatusLabel";
            this.serverEditionToolStripStatusLabel.Size = new System.Drawing.Size(137, 19);
            this.serverEditionToolStripStatusLabel.Text = "Server Edition: Enteprise";
            // 
            // databaseInformationControl
            // 
            this.databaseInformationControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.databaseInformationControl.Location = new System.Drawing.Point(12, 12);
            this.databaseInformationControl.Name = "databaseInformationControl";
            this.databaseInformationControl.Server = null;
            this.databaseInformationControl.Size = new System.Drawing.Size(760, 522);
            this.databaseInformationControl.TabIndex = 2;
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.databaseInformationControl);
            this.Controls.Add(this.statusStrip);
            this.Name = "InformationForm";
            this.Text = "Zoniac Database Tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel serverNameToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel serverVersionToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel serverEditionToolStripStatusLabel;
        private Controls.DatabaseInformationControl databaseInformationControl;
    }
}

