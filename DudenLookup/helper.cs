using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DudenLookup
{
    public class Helper
    {
        private gui m;

        public Helper(gui sender)
        {
            m = sender;
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
        }

        public void SelectError(DudenError e, int c)
        {
            m.rtbInput.Select(e.offset, e.length);
            m.rtbInput.SelectionColor = e.GetHighlightColor();
            m.rtbInput.Select(c, 0);
        }

        public void SelectError(List<DudenError> es, int c)
        {
            foreach (var e in es)
            {
                m.rtbInput.Select(e.offset, e.length);
                m.rtbInput.SelectionColor = e.GetHighlightColor();
            }
            m.rtbInput.Select(c, 0);
        }

        public void UnSelectError(DudenError e, int c)
        {
            m.rtbInput.Select(e.offset, e.length);
            m.rtbInput.SelectionColor = Color.White;
            m.rtbInput.Select(c, 0);
        }

        public void UnSelectError(List<DudenError> es, int c)
        {
            foreach (var e in es)
            {
                m.rtbInput.Select(e.offset, e.length);
                m.rtbInput.SelectionColor = Color.White;
            }
            m.rtbInput.Select(c, 0);
        }

        public void UpdateErrorList()
        {
            m.listErrors.Items.Clear();
            foreach (var e in m.errList)
            {
                m.listErrors.Items.Add(e.original);
            }
        }
    }
}
