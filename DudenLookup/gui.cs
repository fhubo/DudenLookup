using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DudenLookup
{
    public partial class gui : Form
    {
        private Helper H;
        public List<DudenError> errList;
        public DudenError selectedError = null;
        public string lastInputText = null;
        public DevConsole dc;
        public bool dcIsVisible = false;

        public gui()
        {
            InitializeComponent();
            dc = new DevConsole();
            dc.Log("initialized dev console");
            errList = new List<DudenError>();
            dc.Log("initialized error list");
            H = new Helper(this, dc);
            dc.Log("initialized helper");
        }

        private void gui_Load(object sender, EventArgs e)
        {
            H.UpdateTitle("idle...");
        }

        

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            H.UpdateTitle("sending request(s) to duden");
            errList.Clear();
            dc.Log("sending request(s) to duden");

            try
            {
                errList.AddRange(Duden.GetFull(rtbInput.Text));
            }
            catch (Exception ex)
            {
                dc.Log(ex.Message);
            }

            dc.Log("received errors from duden");
            dc.Log("error count: " + errList.Count.ToString());
            H.HighlightErrors(errList, rtbInput.SelectionStart);
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
                dc.Log(ex.Message);
            }
        }

        private void rtbInput_TextChanged(object sender, EventArgs ea)
        {
            if (lastInputText == null)
                return;

            if (rtbInput.TextLength < lastInputText.Length)
            {
                var cInd = rtbInput.SelectionStart;
                foreach (var e in errList)
                {
                    if (cInd >= e.offset && cInd <= e.offset + e.length)
                    {
                        var len = e.offset + e.length - cInd;
                        e.length -= len;
                    }
                    else if (e.offset > cInd)
                    {
                        var change = lastInputText.Length - rtbInput.TextLength;
                        e.offset -= change;
                    }
                }
            }
            else if (rtbInput.TextLength > lastInputText.Length)
            {
                var cInd = rtbInput.SelectionStart;
                foreach (var e in errList)
                {
                    if (cInd < e.offset)
                    {
                        var change = rtbInput.TextLength - lastInputText.Length;
                        e.offset += change;
                    }
                    else if (cInd > e.offset && cInd < e.offset + e.length)
                    {
                        var change = rtbInput.TextLength - lastInputText.Length;
                        e.length += change;
                    }
                }
            }

            lastInputText = rtbInput.Text;
        }

        private void CorrectError(DudenError e)
        {
            if (e.proposals == "" || e.original == "" || errList.Count < 1)
                return;

            var sb = new StringBuilder(rtbInput.Text);
            sb.Remove(e.offset, e.length);
            sb.Insert(e.offset, e.proposals);
            rtbInput.Text = sb.ToString();

            var eInd = errList.IndexOf(e);
            errList.Remove(e);
            H.UpdateErrorList();
            H.UnselectAll(0);
            H.HighlightErrors(errList, 0);

            try
            {
                selectedError = errList[eInd] ?? errList.LastOrDefault();
                H.SelectError(selectedError, selectedError.offset);
                H.SetCurrentError(selectedError, selectedError.offset);
                listErrors.SelectedIndex = errList.IndexOf(selectedError);
            }
            catch (Exception ex)
            {
                H.SetCurrentError(new DudenError("", "", "", "", 0, 0), rtbInput.SelectionStart);
                dc.Log(ex.Message);
            }
        }

        private void CorrectSelectedError()
        {
            if (selectedError == null)
                return;
            if (selectedError.proposals == "")
                return;

            CorrectError(selectedError);
        }

        private void CorrectAllErrors()
        {
            var res = MessageBox.Show("Do you realy want to correct all correctable errors?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;

            foreach (var e in errList.ToList())
            {
                CorrectError(e);
            }
        }

        private void SelectNextError()
        {
            try
            {
                listErrors.SelectedIndex++;
                H.SetCurrentError(errList[listErrors.SelectedIndex], rtbInput.SelectionStart);
                H.SelectError(errList[listErrors.SelectedIndex], rtbInput.SelectionStart);
            }
            catch (Exception ex)
            {
                dc.Log(ex.Message);
            }
        }

        private void SelectPreviousError()
        {
            try
            {
                listErrors.SelectedIndex--;
                H.SetCurrentError(errList[listErrors.SelectedIndex], rtbInput.SelectionStart);
                H.SelectError(errList[listErrors.SelectedIndex], rtbInput.SelectionStart);
            }
            catch (Exception ex)
            {
                dc.Log(ex.Message);
            }
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            CorrectSelectedError();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SelectNextError();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            SelectPreviousError();
        }

        private void correctSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorrectSelectedError();
        }

        private void correctAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorrectAllErrors();
        }

        private void selectNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectNextError();
        }

        private void selectPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectPreviousError();
        }

        private void devConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dcIsVisible = !dcIsVisible;
            if (dcIsVisible)
                dc.Show();
            else
                dc.Hide();
        }
    }
}
