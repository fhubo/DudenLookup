using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DudenLookup
{
    public partial class gui : Form
    {
        List<DudenError> errList;
        DudenError lastError = null;

        public gui()
        {
            InitializeComponent();
            errList = new List<DudenError>();
        }

        private void UpdateTitle(string input)
        {
            Text = "Duden Lookup | " + input;
        }

        private void gui_Load(object sender, EventArgs e)
        {
            UpdateTitle("idle...");
        }

        private void SetCurrentError(DudenError e)
        {
            txtErrCode.Text = e.errorCode;
            txtErrMessage.Text = e.shortMessage;
            txtErrProposal.Text = e.proposals;
            if (lastError != null)
            {
                rtbInput.Select(lastError.offset, lastError.length);
                rtbInput.SelectionBackColor = Color.White;
            }
            if (e.offset > 0 || e.length > 0)
            {
                lastError = e;
                rtbInput.Select(e.offset, e.length);
                rtbInput.SelectionBackColor = Color.LightGray;
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTitle("sending request(s) to duden");
            errList.Clear();
            errList.AddRange(Duden.GetFull(rtbInput.Text));
            foreach (var v in errList)
            {
                rtbInput.Select(v.offset, v.length);
                rtbInput.SelectionColor = v.GetHighlightColor();
            }
            UpdateTitle("idle...");
        }

        private void rtbInput_Click(object sender, EventArgs e)
        {
            /*int i = rtbMain.SelectionStart;
            dudenError selectedError = errorList.Where(x => i >= x.offset && i < x.offset + x.length).FirstOrDefault();
            if (selectedError != null)
            {
                rtbOut.Text = i + "\n\n" + selectedError.ToString() + "\n";
            }*/
            int cInd = rtbInput.SelectionStart;
            DudenError selectedError = errList.Where(x => cInd >= x.offset && cInd < x.offset + x.length).FirstOrDefault();
            if (selectedError != null) SetCurrentError(selectedError); 
        }
    }
}
