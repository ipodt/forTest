using System;
using System.IO;
using System.Collections.Generic;

namespace Task2
{
    class UserInfo
    {
        public int summa_kolva_zaprosov_v_chas = 0;
        public int summa_kolva_chasov = 0;
        public int obshaya_summa_kolva_zaprosov = 0;
        public string dop_info;

        public UserInfo(int summa_kolva_zaprosov_v_chas, int summa_kolva_chasov, string dop_info)
        {
            this.summa_kolva_zaprosov_v_chas = summa_kolva_zaprosov_v_chas;
            this.summa_kolva_chasov = summa_kolva_chasov;
            this.obshaya_summa_kolva_zaprosov = (summa_kolva_zaprosov_v_chas * summa_kolva_chasov);
            this.dop_info = dop_info;
        }

        public void set_sum(int summa_kolva_zaprosov_v_chas, int summa_kolva_chasov, string dop_info)
        {
            this.summa_kolva_zaprosov_v_chas += summa_kolva_zaprosov_v_chas;
            this.summa_kolva_chasov += summa_kolva_chasov;
            this.obshaya_summa_kolva_zaprosov += (summa_kolva_zaprosov_v_chas * summa_kolva_chasov);
            this.dop_info = dop_info;
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
             System.IO.StreamReader file_r = new System.IO.StreamReader("D:\\input.txt");
             System.IO.StreamWriter file_w = new System.IO.StreamWriter("D:\\output.txt");

             Dictionary<string, UserInfo> users = new Dictionary<string, UserInfo>();

             string line;

             while ((line = file_r.ReadLine()) != null)
             {
                 string[] arr_temp = line.Split(' ');

                 if (users.ContainsKey(arr_temp[0]) == true)
                 {
                     users[arr_temp[0]].set_sum(int.Parse(arr_temp[1]), int.Parse(arr_temp[2]), arr_temp[3]);               
                 } else
                 {
                     users[arr_temp[0]] = new UserInfo(int.Parse(arr_temp[1]), int.Parse(arr_temp[2]), arr_temp[3]);
                 }

             }

             foreach (KeyValuePair<string, UserInfo> keyValue in users)
             {
                 file_w.WriteLine(keyValue.Key + " " + keyValue.Value.summa_kolva_zaprosov_v_chas + " " + keyValue.Value.summa_kolva_chasov + " " + keyValue.Value.obshaya_summa_kolva_zaprosov + " " + keyValue.Value.dop_info); ;
             }

             file_r.Close();
             file_w.Close();
        }
    }
}
