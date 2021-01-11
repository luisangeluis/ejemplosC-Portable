using System;
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

public class CProducto{
    
    public string Codigo {set; get;}
    public string Nombre{set; get;}
    public string Categoria{set; get;}
    public int Cantidad {set; get;}
    public double Valor{set; get;}
    
    
}

class CDispensadora{
    
    public List<CProducto> Productos {set; get;}
    public string Pago{set; get;}
    
    public CDispensadora(){
        CProducto coca = new CProducto();
        coca.Codigo="01";
        coca.Nombre="coca Cola";
        coca.Categoria = "B";
        coca.Cantidad = 5;
        coca.Valor = 2000;
        
        CProducto papas = new CProducto();
        papas.Codigo="02";
        papas.Nombre="papas";
        papas.Categoria = "M";
        papas.Cantidad = 2;

        papas.Valor = 1500;
        
        Productos.Add(coca);
        Productos.Add(papas);

        
    }
    
    public int validarProducto(string pCodigo){
        int posicion=-1;
        
        for(int x=0; x<Productos.Count;x++){
            if(Productos[x].Codigo==pCodigo){
                posicion = x;
            }
        }
        
        return posicion;
        
        
    }
    
    public bool agregarProducto(CProducto pProducto){
        
        int posicion =-1; 
        posicion = validarProducto(pProducto.Codigo);
        
        if(posicion>=0){
            
            //Revisar el metodo que usaron en el curso
            /*****************************************/
            /*****************************************/
            Productos[posicion].Cantidad +=1;
        }else{
            Productos.Add(pProducto);

        }
        
        return true;
    }
    
    
}