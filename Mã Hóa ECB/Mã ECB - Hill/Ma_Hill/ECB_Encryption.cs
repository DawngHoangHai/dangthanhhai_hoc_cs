using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ma_Hill
{
    class ECB_Encryption
    {
        public static List<string> tachChuoi(string str, int len)
        {
            List<string> s = new List<string>();
            int d = str.Length / len;
            if (str.Length >= len)
            {
                int j = 0;
                for (int i = 0; i < d; i++)
                {
                    s.Add(str.Substring(j, len));
                    j += len;
                }
                int m = str.Length % len;
                if (m != 0)
                {
                    s.Add(str.Substring((str.Length - m), m));
                }

            }
            else s.Add(str);
            return s;
        }

        public static string ecb(string Text, int len, List<string> splitString, string txtk)
        {
            string temp = "";
            if (Text.Length % len == 0)
            {
                for (int i = 0; i < splitString.Count; i++)
                {
                    temp += Hill.Encrypto(splitString[i].ToString(), mymatric._creat_M(txtk, len));
                }
               return temp;
            }
            else
            {
                for (int i = 0; i < splitString.Count - 1; i++)
                {
                    temp += Hill.Encrypto(splitString[i], mymatric._creat_M(txtk, len));
                }
                return (temp + (splitString[splitString.Count - 1]).ToString());
            }
        }
    }
}
