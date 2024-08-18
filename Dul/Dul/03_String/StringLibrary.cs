namespace Dul
{
    public static class StringLibrary
    {
        public static string CutString(
            this string cut,int length,string suffix="...")
        {
            if(cut.Length>(length-3))
            {
                return cut.Substring(0, length - 3) + "" + suffix;
            }
            return cut;
        }

        public static string CutStringUnicode(
            this string str,int length,string suffix="...")
        {
            string result = str;

            var si = new System.Globalization.StringInfo(str);
            var l = si.LengthInTextElements;

            if(l>(length-3))
            {
                result = si.SubstringByTextElements(0, length - 3) + "" + suffix;
            }
            return result;
        }
    }
}