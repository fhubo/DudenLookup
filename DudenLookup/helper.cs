using System.Collections.Generic;
using System.Drawing;

namespace DudenLookup
{
    public class Helper
    {
        private gui m;
        private DevConsole dc;

        public Helper(gui sender, DevConsole dc)
        {
            m = sender;
            this.dc = dc;
        }

        public void UpdateTitle(string input)
        {
            m.Text = "Duden Lookup | " + input;
        }

        public void SetCurrentError(DudenError e, int cursorPos)
        {
            m.txtErrCode.Text = e.errorCode;
            m.txtErrMessage.Text = e.shortMessage;
            m.txtErrProposal.Text = e.proposals;
            if (m.selectedError != null)
            {
                m.rtbInput.Select(m.selectedError.offset, m.selectedError.length);
                m.rtbInput.SelectionBackColor = Color.White;
                m.rtbInput.Select(cursorPos, 0);
            }
            if (e.offset > 0 || e.length > 0)
            {
                m.selectedError = e;
                m.rtbInput.Select(e.offset, e.length);
                m.rtbInput.SelectionBackColor = Color.LightGray;
                m.rtbInput.Select(cursorPos, 0);
            }
            dc.Log("SetCurrentError: " + e.ToString());
        }

        public void SelectError(DudenError e, int c)
        {
            m.rtbInput.Select(e.offset, e.length);
            m.rtbInput.SelectionBackColor = Color.LightGray;
            m.rtbInput.Select(c, 0);
            dc.Log("SelectError: " + e.ToString());
        }

        public void HighlightErrors(List<DudenError> es, int c)
        {
            foreach (var e in es)
            {
                dc.Log("HightlightError: " + e.ToString());
                m.rtbInput.Select(e.offset, e.length);
                m.rtbInput.SelectionColor = e.GetHighlightColor();
                m.rtbInput.SelectionBackColor = Color.White;
            }
            m.rtbInput.Select(c, 0);
        }

        public void UnselectAll(int c)
        {
            m.rtbInput.Select(0, m.rtbInput.Text.Length);
            m.rtbInput.SelectionColor = Color.Black;
            m.rtbInput.SelectionBackColor = Color.White;
            m.rtbInput.Select(c, 0);
            dc.Log("UnselectAll");
        }

        public void UpdateErrorList()
        {
            m.listErrors.Items.Clear();
            foreach (var e in m.errList)
            {
                m.listErrors.Items.Add(e.original);
            }
            dc.Log("UpdateErrorList");
        }
    }
}
