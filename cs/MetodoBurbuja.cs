using System;

class Program
{
    static void Main() {
        List<int> numeros = new List<int>();
        numeros.Add(8);
        numeros.Add(15);
        numeros.Add(9);
        numeros.Add(2);
        numeros.Add(0);
        numeros.Add(55);
        numeros.Add(120);

        for(int i=0; i<numeros.Count;i++){
        
            for(int j=0; j<numeros.Count-1;j++){
                
                if(numeros[j] > numeros[j+1]){
                    int aux = numeros[j];
                
                    numeros[j] = numeros[j+1];
                    numeros[j+1]=aux;
                }
         
            
            }
        
        }
    
    
    
        for(int i =0; i<numeros.Count;i++){
          Console.Write(" {0}",numeros[i]);
        }
    }
}