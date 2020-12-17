using System;
 

class Program
{
    static void Main() {
        int x = 10;
        int y = 25;
        int z = x + y;

        Console.Write("Sum of x + y = "+ z);
    }
}

class CPersona{
    
    private string nombre;
    private int edad;
    private int DNI;
    private const char sexo='h';
    private double peso;
    private double altura;
    
    public string Nombre{get{return nombre;}set{nombre=value;}}
    public int Edad{get{return edad;}set{edad=value;}}
    public int Propiedaddni{get{return DNI;}}
    public char Sexo{
        get{
            return sexo;
            
        }
        
        
    }
    public double Peso{get{return peso;}set{peso=value;}}
    public double Altura{get{return altura;}set{altura=value;}}

    public CPersona(){
        nombre="";
        edad=0;
        DNI=0;
        
        peso=0.0;
        altura=0.0;
        
    }
    
    public CPersona(string pNombre, int pEdad, char pSexo){
        nombre=pNombre;
        edad = pEdad;
        
        DNI=0;
        peso=0.0;
        altura=0.0;
    }
    
    public CPersona(string pNombre, int pEdad, char pSexo,int pDNI, int pPeso, int pAltura){
     
        nombre=pNombre;
        edad=pEdad;
        
        DNI=pDNI;
        peso=pPeso;
        altura=pAltura;
    }
    
    public int calcularImc(){
        double imc= peso/Math.Pow(altura,2);
        if(imc<20)
        return -1;
        if(imc>=20 && imc<=25)
        return 0;
        
        return 1;
    }
    
    public bool esMayorDeEdad(){
        if(edad>=18)
        return true;
        else
        return false;
        
    }
    
    private void comprobarSexo(char pSexo){
        
        
        
        //if(if pSexo== h)
    }
    
    
    
    
    
}

