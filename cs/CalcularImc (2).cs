using System;
 

class Program
{
     
   
    static void Main() {
        
    string nombre="";
     int edad=0;
     char sexo='h';
     double peso=0.0;
     double altura=0.0;
        
        Console.WriteLine("Escribre el nombre");
        nombre = Console.ReadLine();
        
        Console.WriteLine("Escribre la edad");
        edad = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Escribre el sexo");
        sexo = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine("Escribre el peso");
        peso = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Escribre la altura");
        altura = Convert.ToDouble(Console.ReadLine());
        
        CPersona person1 = new CPersona(nombre,edad,sexo,peso,altura);
        
        Console.WriteLine( "IMC: {0}", person1.calcularImc());
        Console.WriteLine("es mayor de edad: {0}", person1.esMayorDeEdad());
        
        Console.WriteLine(person1);
        
        

        
    }
    
   /* public static void mostrarMensajes(){
        Console.WriteLine("Escribre el nombre");
        nombre = Console.ReadLine();
        
        Console.WriteLine("Escribre la edad");
        edad = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Escribre el sexo");
        sexo = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine("Escribre el peso");
        peso = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Escribre la altura");
        altura = Convert.ToDouble(Console.ReadLine());
        
    }*/
    
}

class CPersona{
    
    private string nombre;
    private int edad;
    private string DNI;
    private char sexo='h';
    private double peso;
    private double altura;
    private Random rnd;
    
    public string Nombre{get{return nombre;}set{nombre=value;}}
    public int Edad{get{return edad;}set{edad=value;}}
    public string Propiedaddni{get{return DNI;}}
    public char Sexo{get{return sexo;}}
    public double Peso{get{return peso;}set{peso=value;}}
    public double Altura{get{return altura;}set{altura=value;}}

    public CPersona(){
        nombre="";
        edad=0;
        
        
        peso=0.0;
        altura=0.0;
        
    }
    
    public CPersona(string pNombre, int pEdad, char pSexo){
        nombre=pNombre;
        edad = pEdad;
        
        
        peso=0.0;
        altura=0.0;
    }
    
    public CPersona(string pNombre, int pEdad, char pSexo,double pPeso, double pAltura){
     
        nombre=pNombre;
        edad=pEdad;
        DNICompleto();
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
        
        if( pSexo!= 'h' || pSexo!= 'm'){
            
            sexo='h';
            
        }else{
            sexo =pSexo;
        }
    }
    
    public string toString(){
        
        string datos= string.Format("nombre: {0} edad: {1} DNI: {2} sexo: {3} peso: {4} altura: {5}",nombre,edad, DNI, sexo,peso,altura);
        return datos;
    }
    
    public int generaDNI(){
        
        int numAleatorio;
        rnd= new Random();
        
        numAleatorio=rnd.Next(10000000, 99999999);
        return numAleatorio;
        
    }
    
    public void DNICompleto(){
        
       char []letras = new char[5] {'a','b','c','d','e'}; 
       
       char letra=letras[rnd.Next(0,4)];
       
        DNI = Convert.ToString(letra + generaDNI());
        
    }
    
}



