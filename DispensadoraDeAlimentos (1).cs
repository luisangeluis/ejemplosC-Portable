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
    
    pubcli CDispensadora(){
        CProducto cocaCola = new CProducto();
        coca.Codigo="01";
        
    }
    
    
}