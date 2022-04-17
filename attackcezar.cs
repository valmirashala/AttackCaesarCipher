using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace detyra  
{
    class Program // klas
    {
        static void Main(string[] args)  
        {
            string ciphertext = File.ReadAllText(@"C:\Users\User\Desktop\valmira\fiek\semestri4\Siguri e te dhenave\Projekti2\ciphertext.txt");

            string plaintext = Dekriptimi(ciphertext);  
            Console.WriteLine("Teksti i dekriptuar:  " + plaintext);   

            Console.ReadKey();  
        }
        public static string sms;   

    }

}

