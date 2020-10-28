using System;
using System.Windows.Forms;

namespace DudenLookup
{
    public partial class DevConsole : Form
    {
        public DevConsole()
        {
            InitializeComponent();
        }

        public void Log(string s)
        {
            rtbDevLog.Text += "[" + DateTime.Now.ToLongTimeString() + "] " + s + "\n";
            rtbDevLog.Select(rtbDevLog.TextLength - 1, 0);
            rtbDevLog.ScrollToCaret();
        }
    }
}
