using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Shifr
{
    class Shivrovanie
    {

        public char[] simvols1 = new char[10000];


        public void Shifr1()
        { int key = 1;
            /* string[] Alfavit =
             {   "А", "а","Б" , "б","В", "в","Г", "г",
                 "Д", "д","Е", "е","Ё", "ё",
                 "Ж", "ж","З", "з","И", "и","Й", "й",
                 "К","к","Л", "л","М", "м","Н", "н",
                 "О", "о","П", "п","Р", "р","С", "с",
                 "Т", "т","У", "у","Ф", "ф",
                 "Х","х","Ц", "ц","Ч", "ч","Ш", "ш",
                 "Щ", "щ","Ъ", "ъ","Ы", "ы",
                 "ь", "ь","Э", "э","Ю", "ю","Я", "я"
             };*/
            string Alfa = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя";
            char[] TempAlf = new char[66];
            int chet;

            TempAlf = Alfa.ToCharArray();
            //for (int l = 0; l <TempAlf.Length; l++) {
            //
              //  Console.WriteLine(TempAlf[l]);
           // }
            Text te = new Text();
            te.TextRead();
            try {
               
                for (int i = 0; i < te.simvols.Length; i++)
                {
                    for (int j = 0; j < TempAlf.Length; j++)
                    {
                        if (te.simvols[i].ToString() != " ")
                        {
                            if (te.simvols[i] == TempAlf[j])
                            {
                                if (j == 66 || j==65)
                                {
                                    if (j%2 == 1) {

                                        te.simvols[i] = TempAlf[1];
                                        break;
                                    }
                                    else
                                    {
                                        te.simvols[i] = TempAlf[0];
                                        break;
                                    }
                                }
                                else
                                {   if (j % 2 == 1)
                                    {
                                        te.simvols[i] = TempAlf[j + key];

                                        break;
                                    }else
                                    {
                                        te.simvols[i] = TempAlf[j + key+1];

                                        break;
                                    }
                                }

                               
                            }
                            
                        }
                    }
                   
                }
                
            }
            catch (Exception e)
            {

            }


            simvols1 = te.simvols;
            for (chet =0; chet < simvols1.Length; chet++) { }
            Array.Resize<char>(ref this.simvols1, chet);

        }

    }
}
