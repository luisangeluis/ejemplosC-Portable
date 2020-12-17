using System;
using System.Collections;


class Program
{
    static void Main() {
        
        string nombre;
        int calificacion;
        string valor;
        bool otro=true;
        bool menu=true;
        int opcion;
        CAlumno alumno=null;
        COrdCalif ordenar = new COrdCalif();
        
       do{
            Console.WriteLine("ordenar calificaciones de alumnos");
            Console.WriteLine("1.-ingresar alumnos");
            Console.WriteLine("2.-salir");
            opcion=Convert.ToInt32(Console.ReadLine());
       
            
            if(opcion==1){
                while(otro==true){
           
                    Console.WriteLine("ingresa nombre");
                    nombre = Console.ReadLine();
                    Console.WriteLine("ingresa calificacion");
                    valor = Console.ReadLine();
                    calificacion = Convert.ToInt32(valor);
            
                    alumno = new CAlumno(nombre,calificacion);
                    ordenar.AgregarAlumnos(alumno);
            
                    Console.WriteLine("otro alumno??");
                    Console.WriteLine("1 para si");
                    Console.WriteLine("2 para no");
                    opcion=Convert.ToInt32(Console.ReadLine());
                    if(opcion==2){
                        otro=false;                        
                        
                    }

                }
                
                ordenar.OrdAlumn();
                ordenar.ImprimirOrdenado();
                ordenar.ImprimirMayor();
                
            }
            
            if(opcion==2){
                menu =false;
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
    
    int IComparable.CompareTo(object alumno){
        
        
            CAlumno temp = (CAlumno)alumno;
            
            if(calificacion< temp.Calificacion)
            return -1;
            if(Calificacion>temp.Calificacion)
            return 1;
            
            return 0;
        
    }
    
    
    
}

class COrdCalif{
    
    private  ArrayList alumnos = new ArrayList();
    
    public  void AgregarAlumnos(CAlumno pAlumno){
        if(pAlumno!=null && pAlumno is CAlumno){
            
            alumnos.Add(pAlumno);
        }
        
    }
    
    public  void OrdAlumn(){
        
        alumnos.Sort();

    }
    
    public  void ImprimirOrdenado(){
       
       foreach(CAlumno alu in alumnos){
           
           Console.WriteLine(alu);
       }
       
    }
    
    public void ImprimirMayor(){
        
       Console.WriteLine("el mayor es: {0}", alumnos[alumnos.Count-1]);
    }
    
    
}