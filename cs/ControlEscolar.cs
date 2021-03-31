using System;
using System.Collections;
using System.Collections.Generic;


class Program
{
    static void Main() {
       
        CControl control = new CControl();
        
        control.Controlar();
        
        
        
        

    }
}

//CONTROL ESCOLAR

/*
.-materias:10  nombre dia y hora y maestro y numero de alumnos
1-que los alumnos puedan elegir sus materias, alta y baja de materias 
2-que los maestros puedan elegir sus materias alta y baja de materias
3-que los horarios de las materias no se cruzen
4-que los alumnos y maestros no puedan elegir mas de 8 materias
*/


//CLASE MATERIAS
//************
//************
class CMateria{
    
    private string nombre;
    private string dia;
    private int hora;
    
    
    public string Nombre{
        get{
            return nombre;
        }
    }
    
    private const int cupo =10;
    
    public CMateria(string pNombre, string pDia, int pHora){
        nombre = pNombre;
        dia = pDia;
        hora = pHora;
    }
    
    public override string ToString(){
        return string.Format("Nombre: {0}\r Dia: {1}\r Hora: {2}",Nombre,dia,hora);
    }

}
//CLASE PARA GUARDAR LAS MATERIAS
//************
//************
class CMaterias{
    
    List <CMateria>materias = null;
    
    public CMaterias(){
        CMateria espanol = new CMateria("español","lunes",5);
        
        materias.Add(espanol);
    }
    
    //Agregar materia
    public bool AddMateriaToList(CMateria pMateria){
        
        if(pMateria is CMateria && pMateria!=null){
           
           
           
           if(ValidarMateria(pMateria.Nombre)>=0){
             return false;
           }else{
               materias.Add(pMateria);
           }
           
        }
        
        return true;
    } 
    //Validar materia
    public int ValidarMateria(string pNombre){
        
        int posicion =-1;
        
        for(int i = 0; i<materias.Count; i++){
            if(materias[i].Nombre==pNombre){
                posicion=i;
            }  
        }
        
        return posicion;
    }
    //Mostrar materias
    public void GetMaterias(){
       foreach(CMateria materia in materias){
            Console.WriteLine(materia.ToString());
        } 
    }
    //Remover materia
     public bool RemoveMateriToList(string pNombre){
        
        int materiaEncontrada = ValidarMateria(pNombre);
        
        if(materiaEncontrada>=0){
            materias.RemoveAt(materiaEncontrada);
            return true;
        }
        
        return false;
    }
     

}

//CLASE PERSONA
//************
//************
class CPersona{
    private string nombre;
    private string codigo;
    
    CMaterias materias = new CMaterias(); 
    
    public string Nombre{set{nombre = value;}get{return nombre;}}
    public string Codigo{set{codigo=value;}get{return codigo;}}
    
    public CPersona(string pNombre, string pCodigo){
        nombre = pNombre;
        codigo = pCodigo;
    }
    
    public override string ToString(){
        return string.Format("Nombre: {0}\r\n Codigo: {1}",nombre,codigo);
    }
}

//CLASE ALUMNO
//************
//************
class CAlumno: CPersona{
    
    public CAlumno(string pNombre, string pCodigo)
                :base(pNombre, pCodigo){
        
    }
    
}

//CLASE MAESTRO
//************
//************
class CMaestro: CPersona{
    
    public CMaestro(string pNombre, string pCodigo)
                :base(pNombre, pCodigo){
        
    }
    
}
//CLASE CONTROL ESCOLAR
//************
//************
class CControl{
    
    //CMaterias materias = new CMaterias();
    
    List<CAlumno>Alumnos= new List<CAlumno>();
    List<CMaestro>Maestros= new List<CMaestro>();

    
   
    public CControl(){
       
        
    }
    
    public void AgregarPersona(CPersona pPersona){
        if(pPersona!=null){
            if(pPersona is CAlumno){
                Alumnos.Add((CAlumno)pPersona);
            }
            
            if(pPersona is CMaestro){
                Maestros.Add((CMaestro)pPersona);
            }
        }
    }
    
    public void Controlar(){
        
       /* 
        
        int opcion=0;
        string nombre;
        string dia;
        int hora;
        
            Console.WriteLine("Agregar materia");
            Console.WriteLine("1.-Uno para agregar materia");
            
            opcion=Convert.ToInt32(Console.ReadLine());
            

            if(opcion ==1){
                Console.WriteLine("Ingresa nombre");
                nombre = Console.ReadLine();
            
                Console.WriteLine("Ingresa dia");
                dia = Console.ReadLine();
            
                Console.WriteLine("Ingresa hora");
                hora = Convert.ToInt32(Console.ReadLine());
                
                CMateria nuevaMateria = new CMateria(nombre,dia,hora);
                
                if(materias.AddMateriaToList(nuevaMateria))
                Console.WriteLine("materia agregada");
                else
                Console.WriteLine("materia no agregada");

                
            }
            
            materias.GetMaterias();
            
            */
    }
    
}