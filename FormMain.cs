using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSplitter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialogMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxFilename.Text = openFileDialogMain.FileName;
            }
        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {
            var originalFilename = Path.GetFileNameWithoutExtension(textBoxFilename.Text);
            
            // destination
            var destinationFolder = Path.GetDirectoryName(textBoxFilename.Text);
            var destinationFilename = String.Concat(originalFilename, ".Part[{0:00}]", Path.GetExtension(textBoxFilename.Text));
            destinationFilename = Path.Combine(destinationFolder, destinationFilename);

            using (var sourceFile = new StreamReader(textBoxFilename.Text, Encoding.Default))
            {
                var fileCounter = 0;
                var destinationFile = new StreamWriter(
                    string.Format(destinationFilename, fileCounter + 1), false, sourceFile.CurrentEncoding);

                try
                {
                    textBoxMessage.Text = "started ..";
                    textBoxMessage.Refresh(); // Refresh the textbox

                    var lineCounter = 0;

                    string line;
                    while ((line = sourceFile.ReadLine()) != null)
                    {
                        // Did we reach the maximum number of lines for the file?
                        if (lineCounter >= numericUpDownLineNo.Value)
                        {
                            // Yep... Time to close this one and 
                            // switch to another file
                            // use progressive approach to prevent memory saturation in case big file
                            lineCounter = 0;
                            fileCounter++;

                            destinationFile.Dispose();
                            destinationFile = new StreamWriter(
                                string.Format(destinationFilename, fileCounter + 1), false, sourceFile.CurrentEncoding);

                            textBoxMessage.Text = textBoxMessage.Text + Environment.NewLine + "Finished : " + fileCounter;
                            textBoxMessage.Refresh(); // Refresh the textbox
                        }

                        destinationFile.WriteLine(line);
                        lineCounter++;
                    }
                    
                    sourceFile.Dispose();
                }
                finally
                {
                    destinationFile.Dispose();
                }

                textBoxMessage.Text = textBoxMessage.Text + Environment.NewLine + "ended ..";
                textBoxMessage.Refresh(); // Refresh the textbox
            }
        }

    }
}
