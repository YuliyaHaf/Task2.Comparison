using System;
using System.Collections;
using System.IO;

namespace Comparison
{
    public class ArrayListCollection                                                      
    {
        public static ArrayList ArrayListCreation(int i)                                  
        {
            ArrayList NewArrayList = new ArrayList();                                     
            Random ranNum = new Random();                                                
            for (int j = 0; j < i; j++)                                                   
            {
                NewArrayList.Add(ranNum.Next(1, 10000));                                  
            }
            return NewArrayList;                                                        
        }       

        public static void AddToArrayList(int i, ref ArrayList NewArrayList)
        {
            NewArrayList.Add(i);
        }

        public static void SearchArrayList(int i, ref ArrayList NewArrayList)
        {
            NewArrayList.Contains(i);
        }

		public static void ReadingFromTxt(ref ArrayList NewArrayList)
		{
			StreamReader txtReader = new StreamReader("C:\\Users\\Yuliya_Hafiyatulina\\source\\repos\\Comparison_v3_initial\\text.txt");
			string sLine = "";
			while (sLine != null)
			{
				sLine = txtReader.ReadLine();
				if (sLine != null)
					NewArrayList.Add(sLine);
			}
			txtReader.Close();
			foreach (int sOutput in NewArrayList)
				Console.WriteLine(sOutput);
			Console.ReadLine();
		}

		public static void DeleteArrayList(int i, ref ArrayList NewArrayList)
        {
            NewArrayList.RemoveAt(i);
        }
    }
}