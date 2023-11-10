using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ma_Hill
{
    class Hill
    {
        public static Dictionary<string, string> dic1, dic2;
         public static string[] text_to_arr(string text)
        {
            char[] arr = text.ToCharArray();
            string[] arr1 = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                arr1[i] = Convert.ToString(arr[i]);
            return arr1;
        }
        private string arr_to_string(string[] arr)
        {
            string text = "";
            for (int i = 0; i < arr.Length; i++)
                text += arr[i];
            return text;
        }
        public static string Encrypto(string str_in, int[,] k)
        {
            string[] arrp = text_to_arr(str_in);
            List<int[]> dicp = new List<int[]>();
            int[] arr_l_p = new int[k.GetLength(0)];
            for (int i = 0; i < arrp.Length; i++)
            {
                arr_l_p[i % k.GetLength(0)] = int.Parse(dic1[arrp[i]]);
                if (((i + 1) % k.GetLength(0)) == 0)
                {
                    dicp.Add(arr_l_p);
                    arr_l_p = new int[k.GetLength(0)];
                }
            }
            List<int[]> dicc = new List<int[]>();
            foreach (int[] item in dicp)
            {
                dicc.Add(mymatric.m_x_n(k, item, dic1.Count));
            }
            string str_out = "";
            foreach (int[] item in dicc)
            {
                for (int i = 0; i < item.Length; i++)
                    str_out += dic2[Convert.ToString(item[i])];
            }
            return str_out;
        }
        public static string decrypto(string str_in, int[,] ik)
        {
            string[] arrp = text_to_arr(str_in);
            List<int[]> dicp = new List<int[]>();
            int[] arr_l_p = new int[ik.GetLength(0)];
            for (int i = 0; i < arrp.Length; i++)
            {
                arr_l_p[i % ik.GetLength(0)] = int.Parse(dic1[arrp[i]]);
                if (((i + 1) % ik.GetLength(0)) == 0)
                {
                    dicp.Add(arr_l_p);
                    arr_l_p = new int[ik.GetLength(0)];
                }
            }
            List<int[]> dicc = new List<int[]>();
            foreach (int[] item in dicp)
            {
                dicc.Add(mymatric.m_x_n(ik, item, dic1.Count));
            }
            string str_out = "";
            foreach (int[] item in dicc)
            {
                for (int i = 0; i < item.Length; i++)
                    str_out += dic2[Convert.ToString(item[i])];
            }
            return str_out;
        }
        public static void intit()
        {
             dic1 = new Dictionary<string, string>();
             dic2 = new Dictionary<string, string>();
            string[] str = new string[]{"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v"
            ,"w","x","y","z","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y"
            ,"Z"," ","~","'","!","@","#","$","%","^","&","*","(",")","-","_","+","=","|","\\","\"","\n","\t","{","}","[","]",":"
            ,";","`","<",">",",",".","?","/","0","1","2","3","4","5","6","7","8","9"};
            for (int i = 0; i < str.Length; i++)
                dic1.Add(str[i], i.ToString());
            foreach (KeyValuePair<string, string> k in dic1)
            {
                dic2.Add(k.Value, k.Key);
            }
        }
    }
}
