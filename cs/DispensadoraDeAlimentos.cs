using System;
using System.Collections.Generic;

//CLASE MAIN
class Program
{
    static void Main() {
        int x = 10;
        int y = 25;
        int z = x + y;

        Console.Write("Sum of x + y = "+ z);
    }
}
//CLASE PRODUCTO
public class CProducto{
    
    public string Codigo {set; get;}
    public string Nombre{set; get;}
    public string Categoria{set; get;}
    public int Cantidad {set; get;}
    public double Valor{set; get;}
    
    public double Cambio{set; get;}
    
    public void sumarCantidad(int pCantidad){
        Cantidad +=pCantidad;
    }
    
    public void modificarNombre(string pNombre){
        Nombre = pNombre;
    }
    
    public void modificarCategoria(string pCategoria){
        Categoria = pCategoria;
    }
    
    public void modificarValor(double pValor){
        Valor = pValor;
    }
    
    //METODO PARA VALIDAR CANTIDAD
    
    public bool validarCantidad(){
        if(Cantidad>0){
            return true;
        }
        return false;
    }
    
    
    
}
//FIN DE LA CLASE PRODUCTO

//CLASE DISPENSADORA
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
    
    //METODO PARA VALIDAR PRODUCTO
    public int validarProducto(string pCodigo){
        int posicion=-1;
        
        for(int x=0; x<Productos.Count;x++){
            if(Productos[x].Codigo==pCodigo){
                posicion = x;
            }
        }
        
        return posicion;
        
        
    }
    
    //METODO PARA AGREGAR PRODUCTO
    public bool agregarProducto(CProducto pProducto){
        
        int posicion =-1; 
        posicion = validarProducto(pProducto.Codigo);
        
        if(posicion>=0){
            
             //Productos[posicion].Cantidad +=1;
            
            Productos[posicion].sumarCantidad(pProducto.Cantidad);
        }else{
            Productos.Add(pProducto);

        }
        
        return true;
    }
    
    //METODO PARA ELIMINAR PRODUCTO
    public bool eliminarProducto(string pCodigo){
        
        int posicion = validarProducto(pCodigo);
        
        if(posicion>=0){
            Productos.RemoveAt(posicion);
            return true;
        }
        
        return false;
    }
    
    //METODO PARA MODIFICAR PRODUCTO
    //PROPIEDADES A MODIFICAR (NOMBRE,CATEGORIA,VALOR)
    public bool modificarProducto(string pCodigo){
        
        int posicion=validarProducto(pCodigo);
        string valor;
        int opcion=0;
        
        if(posicion>=0){
            
            Console.WriteLine("Que valor quieres modificar");
            Console.WriteLine("1.-NOMBRE");
            Console.WriteLine("2.-CATEGORIA");
            Console.WriteLine("3.-VALOR");
            valor=Console.ReadLine();
            opcion = Convert.ToInt32(valor);
            
            switch(opcion){
                case 1:
                    string nombre;
                    Console.WriteLine("Ingresa nombre");
                    nombre = Console.ReadLine();
                    Productos[posicion].modificarNombre(nombre);

                break;
                
                case 2:
                    string categoria;
                    Console.WriteLine("Ingresa categoria");
                    categoria = Console.ReadLine();
                    Productos[posicion].modificarCategoria(categoria);
                break;
                
                case 3:
                    double val;
                    Console.WriteLine("Ingresa valor");
                    val = Convert.ToDouble(Console.ReadLine());
                    Productos[posicion].modificarValor(val);
                break;
            }
            
            //Productos[posicion]
            return true;
        }
                    return false;

    }
    
    
    public CProducto vender(string pCodigo){
        
        posicion = validarProducto(pCodigo);
        
        if(posicion>=0){
            
            if(Productos[posicion].validarCantidad()){
                
            }
            
        }
        
        return null;
    }
    
    
    
}