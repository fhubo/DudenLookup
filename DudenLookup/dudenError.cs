namespace DudenLookup
{
    using clr = System.Drawing.Color;
    public class DudenError
    {
        public string errorCode { get; }
        public string shortMessage { get; }
        public string original { get; }
        public string proposals { get; }

        public int offset { get; }
        public int length { get; }

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
            string rval = "";
            rval += errorCode + "\n";
            rval += shortMessage + "\n";
            rval += original + "\n";
            rval += proposals + "\n";
            rval += offset.ToString() + "\n";
            rval += length.ToString() + "\n";
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
