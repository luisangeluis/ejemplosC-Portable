using System;

class Program
{
    static void Main() {
        
        int opcion;
        COperacion operacion=null;
        int num1=0,num2;
        bool salir= false;
        
        while(salir==false){
            
        Console.WriteLine("***OPERACIONES***");
        Console.WriteLine("1.-SUMA");
        Console.WriteLine("2.-RESTA");
        Console.WriteLine("3.-MULTIPLICACION");
        Console.WriteLine("4.-DIVISION");
        Console.WriteLine("presiona s para salir");
        Console.WriteLine("***ELIGE UNA OPCION***");
        
        
        try{
            opcion = Convert.ToInt32(Console.ReadLine());
            
         Console.WriteLine("ingresa el primer numero");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("ingresa el segundo numero");
        num2 = Convert.ToInt32(Console.ReadLine());
                

        switch(opcion){
            case 1:
            operacion = new CSuma(num1,num2);
            break;
            case 2:
            operacion = new CResta(num1,num2);

            break;
            case 3:
            operacion = new CMultiplicacion(num1,num2);

            break;
            case 4:
            operacion = new CDivision(num1,num2);

            break;
            case 5:
            
            salir=true;
            break;
        }
        
        operacion.CalcularOperacion();
        Console.WriteLine(operacion.ToString());
        
        }catch(Exception e){
            Console.WriteLine("NO VALIDO");
        }
        
        }
    }
}

class COperacion{
    
    private int resultado;
    private int num1;
    private int num2;
    
    public int Resultado{set{resultado=value;}}
    public int Num1{get{return num1;}}
    public int Num2{get{return num2;}}
    
    public COperacion(int pNum1, int pNum2){
        num1=pNum1;
        num2=pNum2;
    }
    
    public override string ToString(){
        string mensaje;
        mensaje = string.Format("el resultado de la operacion es: {0}", resultado);
        return mensaje;
    }
    
    public virtual void CalcularOperacion(){
        resultado=num1+num2;
        
    }
    
}

class CSuma: COperacion{
    
    
    public CSuma(int pNum1, int pNum2) 
    :base(pNum1,pNum2){
        
    }

    
}

class CResta: COperacion{
    
    
    public CResta(int pNum1, int pNum2) 
    :base(pNum1,pNum2){
        
    }
    
    public override void CalcularOperacion(){
             Resultado = Num1-Num2;

    }
    
}
class CMultiplicacion: COperacion{
    
    
    public CMultiplicacion(int pNum1, int pNum2) 
    :base(pNum1,pNum2){
        
    }
    
    public override void CalcularOperacion(){
             Resultado = Num1*Num2;

    }
    
}

class CDivision: COperacion{
    
    
    public CDivision(int pNum1, int pNum2) 
    :base(pNum1,pNum2){
        
    }
    
    public override void CalcularOperacion(){
             Resultado = Num1/Num2;

    }
    
}