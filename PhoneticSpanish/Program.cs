using System;

namespace PhoneticSpanish
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba una palabra para saber el codigo que la representa, para comparar dos o mas palabras separelas con \"=\". Para salir oprima Ctrl+C.");
            while (true)
            {
                var line = Console.ReadLine();
                if (line != null && line.Contains("="))
                {
                    Console.WriteLine(ComparePhoneticSpanish(line) ? "Si" : "No");
                } else if (string.IsNullOrEmpty(line))
                {   
                }
                else
                    Console.WriteLine(PhoneticSpanish(line));
            }
        }

        public static bool ComparePhoneticSpanish(string line)
        {
            var strings = line.Split(Convert.ToChar("="));
            for (var i = 0; i < strings.Length - 1; i++)
            {
                if (PhoneticSpanish(strings[i].Trim()) != PhoneticSpanish(strings[i + 1].Trim()))
                {
                    return false;
                }
            }
            return true;
        }

        public static string PhoneticSpanish(string word)
        {
            var temp = word.ToUpperInvariant();
            temp = temp.Replace("A", "");
            temp = temp.Replace("E", "");
            temp = temp.Replace("I", "");
            temp = temp.Replace("O", "");
            temp = temp.Replace("U", "");
            //Ini Variante
            temp = temp.Replace("Á", "");
            temp = temp.Replace("É", "");
            temp = temp.Replace("Í", "");
            temp = temp.Replace("Ó", "");
            temp = temp.Replace("Ú", "");
            temp = temp.Replace("Ü", "");
            //Fin Variante
            temp = temp.Replace("H", "");
            temp = temp.Replace("W", "");
            temp = temp.Replace("P", "0");
            temp = temp.Replace("B", "1");
            temp = temp.Replace("V", "1");
            temp = temp.Replace("F", "2");
            temp = temp.Replace("H", "2");
            temp = temp.Replace("T", "3");
            temp = temp.Replace("D", "3");
            temp = temp.Replace("S", "4");
            temp = temp.Replace("Z", "4");
            temp = temp.Replace("C", "4");
            temp = temp.Replace("X", "4");
            temp = temp.Replace("LL", "5");
            temp = temp.Replace("L", "5");
            temp = temp.Replace("Y", "5");
            temp = temp.Replace("N", "6");
            temp = temp.Replace("Ñ", "6");
            temp = temp.Replace("M", "6");
            temp = temp.Replace("Q", "7");
            temp = temp.Replace("K", "7");
            temp = temp.Replace("G", "8");
            temp = temp.Replace("J", "8");
            temp = temp.Replace("RR", "9");
            temp = temp.Replace("R", "9");
            return temp;
        }
    }
}
