using System;
using System.Collections.Generic;

//CLASE MAIN
class Program
{
    static void Main() {
        
        string opcion;
        
        CDispensadora dispensadora = new CDispensadora();
        

        //Console.Write("Sum of x + y = "+ z);
        
        Console.WriteLine("Dispensadora de alimentos");
        
        while(true){
            Console.WriteLine("Elige una opcion");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Modificar producto");
            Console.WriteLine("4. Vender producto");
            opcion = Console.ReadLine();
            
            switch (opcion){
                case "1":
                    CProducto producto = new CProducto();
                    
                    
                    Console.WriteLine("Ingresa codigo");
                    producto.Codigo = Console.ReadLine();
                    Console.WriteLine("Ingresa nombre");
                    producto.Nombre = Console.ReadLine(); 
                    Console.WriteLine("Ingresa categoria");
                    producto.Categoria = Console.ReadLine();
                    Console.WriteLine("Ingresa cantidad");
                    producto.Cantidad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa valor");
                    producto.Valor = Convert.ToDouble(Console.ReadLine());
                    
                    if(dispensadora.agregarProducto(producto)){
                        Console.WriteLine("Producto agregado");
                    }else{
                        Console.WriteLine("Producto ya existe");

                    }
                    
                    
                break;
                
                case "2":
                    string codigo;
                    
                    dispensadora.mostrarProductos();
                    Console.WriteLine("Ingrese codigo a eliminar");
                    codigo = Console.ReadLine();
                    if(dispensadora.eliminarProducto(codigo)){
                        Console.WriteLine("prodocto eliminado");
                    }else{
                        Console.WriteLine("producto no encontrado");
                    }
                    
                break;
                case "3":
                    codigo="";

                    Console.WriteLine("Ingrese codigo a modificar");
                    codigo = Console.ReadLine();

                    if(dispensadora.modificarProducto(codigo)){
                        Console.WriteLine("Producto modificado");
                    }else{
                        Console.WriteLine("Producto no encontrado");

                    }
                    
                    
                break;
                case "4":
                    string pago;
                    codigo="";
                    
                    
                    Console.WriteLine("Ingrese pago");
                    pago=Console.ReadLine();
                    
                    do{
                        if(dispensadora.vender(codigo)!=null){
                            Console.WriteLine("Compra exitosa");
                        }else{
                            Console.WriteLine("codigo no encontrado");
                        }
                    }while(dispensadora.vender(codigo)==null);
                    
                    Console.WriteLine("Ingrese codigo");
                    codigo=Console.ReadLine();
                    
                    dispensadora.Pago = pago;
                    
                    
                    
                    
                    
                
                break;
            }
        }
        
        

        
    }
}
//FIN DE LA CLASE MAIN

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
    
    public bool validarValor(double pValor){
        
        if(Valor <=pValor){
            Cambio = pValor - Valor;
              
            return true;  
        }
        return false;
    }
    
    //METODO DESCONTAR PRODUCTO
    public void restarProducto(){
        Cantidad--;
    }
    
    public override string ToString(){
        return string.Format("Codigo: {0} Nombre: {1} Categoria: {2} Cantidad: {3}, Valor{4} \r\n",Codigo,Nombre,Categoria,Cantidad,Valor);
    }
    
}
//FIN DE LA CLASE PRODUCTO

//CLASE DISPENSADORA
class CDispensadora{
    
    public List<CProducto> Productos {set; get;}
    public string Pago{set; get;}
    
    public CDispensadora(){
        
        Productos = new List<CProducto>();
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
    //VALIDAR MONEDAS
    public double validarMonedas(string[] monedas){
        
        double total=0;
        
        foreach(string moneda in monedas){
            try{
                
                total +=Convert.ToDouble(moneda);
            }catch(Exception e){
                
            }
        }
        return total;
    }
    
    //METODO PARA VENDER PRODUCTO
    public CProducto vender(string pCodigo){
        
        int posicion = validarProducto(pCodigo);
        
        if(posicion>=0){
            
            if(Productos[posicion].validarCantidad()){
                
                string []monedas = Pago.Split('-'); 
                double total = validarMonedas(monedas);
                if(Productos[posicion].validarValor(total)){
                    Productos[posicion].restarProducto();
                    return Productos[posicion];
                }
                
            }
            
        }
        
        return null;
    }
    
    public void mostrarProductos(){
        
        foreach(CProducto product in Productos){
            Console.WriteLine(product);
        }
    }
    
    
    
}