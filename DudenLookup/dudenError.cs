namespace DudenLookup
{
    using clr = System.Drawing.Color;
    public class DudenError
    {
        public string errorCode { get; }
        public string shortMessage { get; }
        public string original { get; }
        public string proposals { get; }

        public int offset { get; set; }
        public int length { get; set; }

        public DudenError(string errorCode, string shortMessage, string original, string proposals, int offset, int length)
        {
            this.errorCode = errorCode;
            this.shortMessage = shortMessage;
            this.original = original;
            this.proposals = proposals;
            this.offset = offset;
            this.length = length;
        }

        public override string ToString()
        {
            string rval = "{ ";
            rval += errorCode + "; ";
            rval += shortMessage + "; ";
            rval += original + "; ";
            rval += proposals + "; ";
            rval += offset.ToString() + "; ";
            rval += length.ToString() + "; }";
            return rval;
        }

        public clr GetHighlightColor()
        {
            clr c = clr.BlueViolet;
            if (errorCode == "21")
            {
                c = clr.Red;
            }
            else if (errorCode == "902")
            {
                c = clr.SteelBlue;
            }
            return c;
        }
    }
}
