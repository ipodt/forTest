using System;
using System.IO;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        struct UserInfo
        {
            public int summa_kolva_zaprosov_v_chas;
            public int summa_kolva_chasov;
            public int obshaya_summa_kolva_zaprosov;
            public string dop_info;
        }

        static void Main(string[] args)
        {
            System.IO.StreamReader file_r = new System.IO.StreamReader("D:\\input.txt");
            System.IO.StreamWriter file_w = new System.IO.StreamWriter("D:\\output.txt");

            Dictionary<string, UserInfo> user = new Dictionary<string, UserInfo>();

            string line;

            UserInfo temp_user_info;

            while ((line = file_r.ReadLine()) != null)
            {
                string[] arr_temp = line.Split(' ');

                temp_user_info.summa_kolva_zaprosov_v_chas = int.Parse(arr_temp[1]);
                temp_user_info.summa_kolva_chasov = int.Parse(arr_temp[2]);


                Console.WriteLine(user[arr_temp[0]].summa_kolva_zaprosov_v_chas);
            }

            



            file_w.WriteLine("Ехуууу");

            file_r.Close();
            file_w.Close();
        }
    }
}
