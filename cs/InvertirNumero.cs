using System;

class Program
{
    static void Main() {
        int x = 15000;
        string numeroToCadena = Convert.ToString(x);
        
        char[] caracteres = numeroToCadena.ToCharArray();
        

        
        Array.Reverse(caracteres);
        
        foreach(char c in caracteres){
            

            Console.Write(c);
            
        }
        Console.WriteLine();
        Console.WriteLine(Int32.Parse(caracteres)+1);

    }
}