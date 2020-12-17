using System;
using System.Collections;



class Program
{
    static void Main() {
        
        string nombre;
        int calificacion;
        int opcionP;
        int opcion;

        bool otro;
        bool menu;
        
        COrdAlumnos listaAlumnos = new COrdAlumnos();

        do{
             otro=true;
             menu=true;
        
            Console.WriteLine("ordenar calificaciones de alumnos");
            Console.WriteLine("1.-ingresar alumnos");
            Console.WriteLine("2.-salir");
            opcionP=Convert.ToInt32(Console.ReadLine());
            
            if(opcionP==1){
                while(otro==true){
                    
                Console.WriteLine("ingresa el nombre");
                nombre=Console.ReadLine();
                Console.WriteLine("ingresa la calificacion");
                calificacion = Convert.ToInt32(Console.ReadLine());
                
                listaAlumnos.AgregarAlumno(nombre,calificacion);
                
                Console.WriteLine("otro alumno?");
                Console.WriteLine("1 para si");
                Console.WriteLine("2 para no?");

                opcion = Convert.ToInt32(Console.ReadLine());
                
                    if(opcion==2){
                    otro=false;
                    }
                }
                
                listaAlumnos.ImprimirOrdenado();
            }
            if(opcionP==2){
                menu=false;
            }
                
        }while(menu==true);
       
       
       
    }
}

class CAlumno: IComparable{
    
    private string nombre;
    private int calificacion;
    
public int Calificacion{
        
        get{return calificacion;}set{calificacion=value;}
        
    }
        
    
    public CAlumno(string pNombre, int pCalificacion){
        
        nombre= pNombre;
        calificacion = pCalificacion;
    }
    
    public override string ToString(){
        
        string mensaje;
        
        mensaje=string.Format("nombre: {0} calificacion: {1}", nombre, calificacion);
        return mensaje;
        
    }
    
    
    public int CompareTo(object alumno){
        CAlumno temp = (CAlumno)alumno;
        
        if(calificacion<temp.Calificacion)
        return -1;
        if(calificacion>temp.Calificacion)
        return 1;
        
        return 0;
        
    }
    
    
    
}

class COrdAlumnos{
    
    private ArrayList alumnos = new ArrayList();
    private CAlumno alumno;
    

    public void AgregarAlumno(String pNombre, int pCalificacion){
        
        alumno = new CAlumno(pNombre, pCalificacion);
        alumnos.Add(alumno);
    }
    
    public void ImprimirOrdenado(){
        alumnos.Sort();
        
        foreach(CAlumno a in alumnos){
            
            Console.WriteLine(a);
        }
        
        
    }
    
    
}