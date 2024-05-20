using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDZ
{
    public partial class HTMLSuccessForm : Form
    {
        public string path = "";

        public HTMLSuccessForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenHTML();
        }

        private void OpenHTML()
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(path) { UseShellExecute = true };
            process.Start();
        }
    }
}
