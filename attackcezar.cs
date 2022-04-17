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

    
      static string Dekriptimi(string ciphertext)   

        ciphertext = ciphertext.ToUpper();  
        char[] alfabeti = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };  

        char[] mesazhiEch = ciphertext.ToCharArray(); 
        string[] tekstiKontrollues = new string[] { "EDHE", "ESHTE" };  

        string[] Split_Mesazhi = ciphertext.Split(' ');   

        List<string> list = new List<string>();    

        for (int i = 0; i < Split_Mesazhi.Length; i++)   
            for (int j = 0; j < tekstiKontrollues.Length; j++)   
                if (Split_Mesazhi[i].Length == tekstiKontrollues[j].Length)  
                    list.Add(Split_Mesazhi[i]);   
        string[] vargu = list.ToArray(); 


        int celesi = 0;   
            for (int i = 0; i < vargu.Length; i++)  
            {
                celesi = kontrollo(tekstiKontrollues, vargu[i].ToString()); 
                if (celesi != -1)    
                {
                    sms += Mesazhi(ciphertext, celesi);    
                    break;  

                }
            }
        return sms;  

}


public static string Mesazhi(string tekstiKoduar, int celsi)    
{
    StringBuilder tekstiDekoduar = new StringBuilder(tekstiKoduar);   
    for (int i = 0; i < tekstiKoduar.Length; i++) 
    {
        if (tekstiKoduar[i] != ' ')  
            tekstiDekoduar[i] = ((char)((tekstiKoduar[i] - 'A' - celsi + 26) % 26 + 'A')); 
    }
    return tekstiDekoduar.ToString(); 
}
public static int kontrollo(string[] _tekstiKontrollues, string fjala)
{
    int celesi_final = 0;
    for (int i = 0; i < _tekstiKontrollues.Length; i++)
        if (_tekstiKontrollues[i].Length == fjala.Length)
        {
            celesi_final = fjala[0] - _tekstiKontrollues[i][0];
            if (_tekstiKontrollues[i].Equals(Mesazhi(fjala, celesi_final)))

                return celesi_final; // kthehet celesi final
        }
    return -1;

}
    }

}