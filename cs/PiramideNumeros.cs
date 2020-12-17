using System;

class Program
{
    static void Main() {
        int filas;
        string valor;
        
        CNumeros numero = new CNumeros();
        
        Console.WriteLine("ingresa numero");
        valor = Console.ReadLine();
        filas = Convert.ToInt32(valor);
        
        numero.Filas = filas;
        numero.llenarFila();
        
        
        
    }
}

class CNumeros{
    
    private int filas;
    
    public int Filas{ get {return filas;} set{filas=value;} }
    
    public void llenarFila(){
        
    for(int x=0; x<filas; x++){
            
            int aux=x+1;
            
            Console.WriteLine();
            
            for(int a=filas-1; a>=aux-1; a--){
                
                Console.Write(" ");
            }
            
             for(int y=1; y<=aux;y++){
                
                
                Console.Write(y);
                
            }
            
            for(int z=aux-1; z>0; z--){
             
             Console.Write(z);
                
            }
            
        }
        
    }
    
}