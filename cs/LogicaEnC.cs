using System;

class Program
{
    static void Main() {
        
        int mayor=0;
       
       /*
       CMultiplicacion multi = new CMultiplicacion(4,5);
       Console.WriteLine(multi.Calcular());
       */
       
      int[] numeros = new int[10]{22,22,1,4,6,40,60,62,90,0};
      
      for(int i=0;i<numeros.Length; i++){
          if(numeros[i]>mayor){
              mayor=numeros[i];
          }
      }
      
      Console.WriteLine(mayor);
      
    }
}

class CMultiplicacion{
    private double num1;
    private double num2;
    private double result=0;
    

    
    public CMultiplicacion(double pNum1,double pNum2){
        num1 = pNum1;
        num2 = pNum2;
        
    }
    
    public double Calcular(){
        
        bool positivo;
        
        positivo = Math.Abs(num2)==num2;
        
        for(int i=0;i<Math.Abs(num2);i++){
            result= positivo ? result+num1 : result-num1;
        }
        
        return result;
        
        
        
        
    }
  
    
    
    
   

}