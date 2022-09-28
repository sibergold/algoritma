using System;

namespace algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümleni gir.");
            string cumle  = Console.ReadLine();
            string cumle2="";
            string[] kelimeler=cumle.Split(',');
            for(int i=0;i<kelimeler.Length;i++)
            {
                cumle2+=kelimeler[0];
                for(int j=1;j<kelimeler.Length;j++)
                {
                    if(kelimeler[j].Contains(Convert.ToString(j)))
                    {
                         kelimeler[j].Remove(j);
                    }
                else
                {
                    continue;
                }
                }
            }
           Console.WriteLine(cumle2);
           
        }
    }
}