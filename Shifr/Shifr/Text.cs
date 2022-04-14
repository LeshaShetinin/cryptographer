using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Shifr
{
   
    class Text
    {

      public  char[] simvols = new char[10000];
        public  void TextRead()
        {
            try
            {
                string username = Environment.UserName;
                string line;
                string[] str = new string[1000];
                int i = 0;
                int chet =0;
               
                StreamReader sr = new StreamReader(@"C:\Users\" + username + @"\Desktop\123\1\Shifr\ShifrText\Shifr.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    str[i] = line;



                    line = sr.ReadLine();
                    i++;

                }
                Array.Resize<string>(ref str, i);
                sr.Close();

                




                for (int j = 0; j < str.Length; j++)
                    
                {
                    if (str[j] != null)
                    {
                        foreach (char c in str[j])
                        {
                            
                            this.simvols[chet] = c;
                            chet++;
                        }
                        
                    }

                   
                }
                Array.Resize<char>(ref this.simvols, chet );


                
            }
            catch(Exception e)
            {
                
            }
            
        }

    }
}
