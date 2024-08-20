using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CI.ATFX.Reader.Demo
{
    public partial class ProgressBarForm : Form
    {
        public ProgressBarForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        public void ProgressBarUpdate(int progressStep, string message)
        {
            progressBar1.Value = progressStep;
            progressBar1.Update();
            label1.Text = message;
            label1.Update();
            this.Refresh();
        }
    }
}
