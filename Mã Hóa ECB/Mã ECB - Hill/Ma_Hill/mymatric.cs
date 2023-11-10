using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ma_Hill
{
    class mymatric
    {
        
     
        public static int[,] _creat_M(string str,int L)
        {
            int[,] _temp_M=new int[L,L];
            string[] arr = str.Split(',');
            for (int i = 0; i < L; i++)
                for (int j = 0; j < L; j++)
                    _temp_M[i, j] = int.Parse(arr[L * i + j]);
            return _temp_M;
        }
       
        public static int _UCLN(int a, int b)
        {
            while ((a % b) != 0)
            {
                int c = a % b;
                a = b;
                b = c;
            }
            return b;
        }
        public static bool _test_K(int[,] M,int Z)
        {
            int det = mymatric.determinant(M, Z);
            if (_UCLN(Z,det) > 1) return false;
            return true;
        }
        public static int In_ver(int m, int b)
        {
            int a1 = 1;
            int a2 = 0;
            int a3 = m;
            int b1 = 0;
            int b2 = 1;
            int b3 = b;
            while ((b3 != 0) && (b3 != 1))
            {
                int q = a3 / b3;
                int t1 = a1 - q * b1;
                int t2 = a2 - q * b2;
                int t3 = a3 - q * b3;
                a1 = b1;
                a2 = b2;
                a3 = b3;
                b1 = t1;
                b2 = t2;
                b3 = t3;
            }
            if (b3 == 1)
            {
                return b2;
            }
            return 0;
        }
      
        public static int determinant(int[,] array, int Z)
        {
            int det = 0;           
            if (array.GetLength(0) == 2)
            {
                det = (array[0, 0] * array[1, 1] - array[0, 1] * array[1, 0]);
            }

            else
            {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        int[,] tempArr = fillNewArr(array, 0, j);
                        det += array[0, j]*(int)Math.Pow(-1,j)*determinant(tempArr, Z);
                    }
            }
            det = det % Z;
            if(det<0) det=det+Z;
            return det;
        }

        public static int[,] fillNewArr(int[,] originalArr, int row, int col)
        {
            int[,] tempArray = new int[originalArr.GetLength(0) - 1, originalArr.GetLength(1) - 1];

            for (int i = 0, newRow = 0; i < originalArr.GetLength(0); i++)
            {
                if (i == row) continue;
                for (int j = 0, newCol = 0; j < originalArr.GetLength(1); j++)
                {
                    if (j == col) continue;
                    tempArray[newRow, newCol] = originalArr[i, j];
                    newCol++;
                }
                newRow++;
            }
            return tempArray;
        }

        public static int[] m_x_n(int[,] M,int[] Array, int Z)
        {
            int[] temp=new int[Array.Length];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                int total = 0;
                for (int j = 0; j < M.GetLength(1); j++)
                    total += M[i, j] * Array[j];

                total = total % Z;
                temp[i] = total;
            }
            return temp;
        }

        public static int[,] MP(int[,] array, int Z)
        {
            int[,] tempMP = new int[array.GetLength(0), array.GetLength(0)];
            int[,] tempMPO = new int[tempMP.GetLength(0), tempMP.GetLength(1)];
            int det = mymatric.determinant(array, Z);
            int Idet =mymatric.In_ver(Z, det);
            if (Idet < 0) Idet = Idet + Z;
            if (array.GetLength(0) == 2)
            {
                tempMP[0, 0] = (array[1, 1]*Idet)%Z;
                tempMP[0, 1] = ((-array[0, 1]+Z)*Idet)%Z;
                tempMP[1, 0] = ((-array[1, 0]+Z)*Idet)%Z;
                tempMP[1, 1] = (array[0, 0]*Idet)%Z;
                tempMPO = tempMP;
            }
            else
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int[,] tempArr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
                    tempArr = fillNewArr(array, i, j);
                    tempMP[i, j] = (int)Math.Pow(-1, j + i) * determinant(tempArr, Z);
                    tempMP[i, j] = (tempMP[i, j] * Idet) % Z;
                    if (tempMP[i, j] < 0) tempMP[i, j] = tempMP[i, j] + Z;
                    tempMPO[j, i] = tempMP[i, j];
                }
            }
            return tempMPO;
        }

        public static string M_to_string(int[,] arr)
        {
            string str_out="";;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    str_out += arr[i, j] + ",";
            str_out = str_out.Remove(str_out.Length-1, 1);
            return str_out;
        }
    }
}

    

