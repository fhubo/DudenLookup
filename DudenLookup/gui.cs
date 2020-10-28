using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DudenLookup
{
    public partial class gui : Form
    {
        private Helper H;
        public List<DudenError> errList;
        public DudenError selectedError = null;
        public string lastInputText = null;

        public gui()
        {
            InitializeComponent();
            errList = new List<DudenError>();
            H = new Helper(this);
        }

        private void gui_Load(object sender, EventArgs e)
        {
            H.UpdateTitle("idle...");
        }

        

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            H.UpdateTitle("sending request(s) to duden");
            errList.Clear();
            errList.AddRange(Duden.GetFull(rtbInput.Text));
            H.SelectError(errList, rtbInput.SelectionStart);
            H.UpdateErrorList();
            lastInputText = rtbInput.Text;
            H.UpdateTitle("idle...");
        }

        private void rtbInput_Click(object sender, EventArgs e)
        {
            int cInd = rtbInput.SelectionStart;
            DudenError newSelectedError = errList.Where(x => cInd >= x.offset && cInd <= x.offset + x.length).FirstOrDefault();
            var errInd = errList.IndexOf(newSelectedError);
            if (newSelectedError != null && newSelectedError != selectedError)
            {
                H.SetCurrentError(newSelectedError, rtbInput.SelectionStart);
                listErrors.SelectedIndex = errInd;
            }
        }

        private void listErrors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                H.SetCurrentError(errList[listErrors.SelectedIndex], rtbInput.SelectionStart);
            }
            catch (Exception ex)
            {

            }
        }

        private void rtbInput_TextChanged(object sender, EventArgs ea)
        {
            if (lastInputText == null)
                return;

            if (rtbInput.TextLength < lastInputText.Length)
            {
                var cInd = rtbInput.SelectionStart;
                var change = lastInputText.Length - rtbInput.TextLength;
                foreach (var e in errList)
                {
                    if (cInd >= e.offset && cInd <= e.offset + e.length)
                    {
                        var len = e.offset + e.length - cInd;
                        e.length -= len;
                    }
                    else if (e.offset > cInd)
                    {
                        e.offset -= change;
                    }
                }
            }

            lastInputText = rtbInput.Text;
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            if (selectedError == null)
                return;
            if (selectedError.proposals == "")
                return;

            var sb = new StringBuilder(rtbInput.Text);
            sb.Remove(selectedError.offset, selectedError.length);
            sb.Insert(selectedError.offset, selectedError.proposals);
            lastInputText = sb.ToString();
            rtbInput.Text = lastInputText;

            var eInd = errList.IndexOf(selectedError);
            errList.Remove(selectedError);
            H.UpdateErrorList();
            selectedError = errList[eInd];
            H.SelectError(selectedError, selectedError.offset);
        }
    }
}
