using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._12._22çarşambaçalışma
{
    internal class insan
    {
        private static void Main(string[] args)
        {
            clsinsan insan = new clsinsan("Melek","Balcı",31,1.56f);

            insan.tanis();

        
        }

        class clsinsan
        {


            public clsinsan(string i, string s, int y, float b)
            {

                isim = i;
                soyad = s;
                yas = y;
                boy = b;



            }



            public string isim { get; set; }
            public string soyad { get; set; }
            public int yas { get; set; }
            public float boy { get; set; }


            public void tanis()
            {


                Console.WriteLine("Benim adım {0}  {1}, yaşım {2}, boyum {3}'dır.", isim, soyad, yas,boy);

            }

        }


    }

    
}
