using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int min = 1;
            int max = 6;
            byte bir = 0, iki = 0, uc = 0, dort = 0, bes = 0, alti = 0 ;
            for(int i=1;i<=1000;i++)
            { 
            byte[] rastgele = new byte[6];

                RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            
                rngCsp.GetBytes(rastgele);
            

            int rastgelesayi = BitConverter.ToInt32(rastgele, 0);
            rastgelesayi = Math.Abs(rastgelesayi % (max - min + 1)) + min;

                Console.WriteLine("{0}", rastgelesayi);
                if (rastgelesayi == 1)
                    bir++;
                else if (rastgelesayi == 2)
                    iki++;
                else if (rastgelesayi == 3)
                    uc++;
                else if (rastgelesayi == 4)
                    dort++;
                else if (rastgelesayi == 5)
                    bes++;
                else
                    alti++;
                
            }

            Console.WriteLine("Bir:{0}\nİki:{1}\nÜç:{2}\nDört:{3}\nBeş:{4}\nAlti:{5}",bir,iki,uc,dort,bes,alti);
            Console.ReadLine();
        }
    }
}
