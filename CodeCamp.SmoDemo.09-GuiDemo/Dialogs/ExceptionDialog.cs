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
    public partial class ExceptionDialog : Form
    {
        private Exception exception;
        private string message;
        private string title;

        private ExceptionDialog()
        {
            InitializeComponent();
        }

        public ExceptionDialog(Exception exception)
            : this()
        {
            this.exception = exception;
        }

        public ExceptionDialog(Exception exception, string message)
            : this(exception)
        {
            this.message = message;
        }

        public ExceptionDialog(Exception exception, string message, string title)
            : this(exception, message)
        {
            this.title = title;
        }

        private void ExceptionDialog_Load(object sender, EventArgs e)
        {
            if (this.title != null)
                this.Text = title;
            else
                this.Text = "Error";

            List<string> exceptionMessages = new List<string>();

            var loopException = exception;

            while (loopException != null)
            {
                exceptionMessages.Add(loopException.Message);

                loopException = loopException.InnerException;
            }

            for (int index = 0; index < exceptionMessages.Count; index++)
            {
                if (index != 0)
                {
                    tableLayoutPanel.ColumnStyles[index].SizeType = SizeType.Absolute;
                    tableLayoutPanel.ColumnStyles[index].Width = 22;
                    tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    tableLayoutPanel.ColumnCount = index + 2;

                    tableLayoutPanel.RowCount = index + 1;
                    tableLayoutPanel.RowStyles[index].SizeType = SizeType.AutoSize;
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                PictureBox pictureBox = new PictureBox();
                pictureBox.Anchor = AnchorStyles.None;
                pictureBox.Image = Resource.HierarchyIcon;
                pictureBox.Name = "hierarchyIconPictureBox" + index;
                pictureBox.Size = new System.Drawing.Size(21, 21);
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

                tableLayoutPanel.Controls.Add(pictureBox, index, index);

                Label label = new Label();
                label.Anchor = AnchorStyles.Left;
                label.AutoSize = true;
                label.Name = "exceptionLabel" + index;
                label.Padding = new Padding(0, 5, 0, 0);
                label.Text = exceptionMessages[index];

                tableLayoutPanel.Controls.Add(label, index + 1, index);

                int span = exceptionMessages.Count - index;

                tableLayoutPanel.SetColumnSpan(label, span);
            }

            tableLayoutPanel.RowCount = exceptionMessages.Count + 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
