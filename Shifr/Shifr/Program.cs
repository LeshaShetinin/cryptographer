using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Shifr
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Environment.UserName;
            Shivrovanie sf = new Shivrovanie();
            sf.Shifr1();

            StreamWriter fl = new StreamWriter(@"C:\Users\" + username + @"\Desktop\123\1\Shifr\ShifrText\ZaShifr.txt");
          
            for (int i = 0; i < sf.simvols1.Length; i++)
            {
               
                fl.Write(sf.simvols1[i]);
            }
            fl.Close();

            

           
        }
    }
}
