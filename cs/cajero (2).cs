using System;
using System.Collections;
using System.Collections.Generic;


class Program
{
    static void Main() {
        int x = 10;
        int y = 25;
        int z = x + y;

        Console.Write("Sum of x + y = "+ z);
    }
}

//CLASE CAJERO
class CCajero{
    
    
    
    
    
}

//CLASE CUENTA

class CCuenta{
    
    
    public int Nip {set; get;}
    public double Saldo {get; set;}
    
    public CCuenta(int pNip, double pSaldo){
        Nip = pNip;
        Saldo=pSaldo;
        
    }
    
    public CCuenta(int pNip){
        Nip = pNip;
        Saldo=0.0;
        
    }
    
    public CCuenta(){
        Nip=12345;
        Saldo=0.0;
    }
    
    public string ToString(){
        
        string datos;
        
        datos = string.Format("El nip del usuario es {0} y su saldo es{1} ",Nip, Saldo);
        return datos;
    }
    
    public void editarNip(int pNip){
        
        if(pNip is int){
            Nip=pNip;
        }
    }
    public void editarSaldo(double pSaldo){
        if(pSaldo is double){
            
            Saldo=pSaldo;
        }
        
    }
        
}
// CLASE ADMINISTRADORA DE CUENTAS**************
class AdminDeCuentas{
    
    List<CCuenta> cuentas = new List<CCuenta>();
    
    public AdminDeCuentas(){
        
        CCuenta cuenta1 = new CCuenta(54321, 500);
        CCuenta cuenta2 = new CCuenta(10100, 3000);
        
        cuentas.Add(cuenta1);
        cuentas.Add(cuenta2);

    }
//METODO VALIDAR CUENTA    
    public int validarCuenta(int pNip){
        int posicion=-1;
        for(int x=0; x<cuentas.Count; x++){
            if(cuentas[x].Nip==pNip){
                posicion=x;
            }
            
        }
        
        return posicion;
    }
    
  //METODO CREAR CUENTA  
    public bool crearCuenta(int pNip){
        
        int encontro=-1;
        encontro=validarCuenta(pNip);
        
        if(encontro>=0){
            return false;
        }
        CCuenta cuenta = new CCuenta(pNip);
        
        cuentas.Add(cuenta);
        
        return true;
    }
//METODO EDITAR CUENTA
    public bool editarCuenta(CCuenta cuenta){
        
        int encontro=-1;
        int opcion=0;
        string valor;
        int nip=0;
        double saldo=0;
        
        encontro=validarCuenta(cuenta.Nip);
        
        if(encontro>=0){
            
            Console.WriteLine("ELIGE EL DATO A EDITAR");
            Console.WriteLine("1 para editar Nip");
            Console.WriteLine("2 para editar saldo");
            
            valor = Console.ReadLine();
            
            opcion=Convert.ToInt32(valor);
            
                switch(opcion){
                 case 1:
                    Console.WriteLine("Ingresa el nuevo nip");
                    nip = Convert.ToInt32(Console.ReadLine());
                 break;
                 case 2:
                    Console.WriteLine("Ingresa el nuevo saldo");
                    saldo = Convert.ToDouble(Console.ReadLine());
                 break;
                 default:Console.WriteLine("Opcion no valida");
                 break;
                }
                cuentas[encontro].editarNip(nip);
                cuentas[encontro].editarSaldo(saldo);
                return true;
        }
        
        return false;
    }
//METODO BORRAR CUENTA

    public bool borrarCuenta(int pNip){
        int encontro=-1;
        
        encontro=validarCuenta(pNip);
        
        if(encontro>=0){
            
            cuentas.RemoveAt(encontro);
            return true;
        }
        return false;
    }
    
    
}