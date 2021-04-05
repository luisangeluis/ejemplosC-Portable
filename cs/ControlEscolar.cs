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
    
    public int validarAlumno(string pCodigo){
        int posicion=-1;
       
        for(int i =0; i<Alumnos.Count; i++){
            if(Alumnos[i].Codigo == pCodigo){
                posicion = i;
            }
        }  
        
        return posicion;
    }
    
    public int validarMaestro(string pCodigo){
        int posicion=-1;
       
        for(int i =0; i<Maestros.Count; i++){
            if(Maestros[i].Codigo == pCodigo){
                posicion = i;
            }
        }  
        
        return posicion;
    }
    
    public bool AgregarPersona(CPersona pPersona){
        
        int encontrado =-1;
        
        if(pPersona!=null){
            //Si es alumno
            if(pPersona is CAlumno){
                
                encontrado=validarAlumno(pPersona.Codigo);
                
                if(encontrado>=0){
                   return false; 
                }else{
                    Alumnos.Add((CAlumno)pPersona);

                }
                return true;
            }
            //Si es Maestro
            if(pPersona is CMaestro){
                
                encontrado=validarMaestro(pPersona.Codigo);
                if(encontrado >=0){
                    return false; 

                }else{
                    Maestros.Add((CMaestro)pPersona);
                }
                return true;
            }
        }
        return false;
        
    }
    
    
    public bool EliminarPersona(string pCodigo){
        int encontro=-1;
        int opcion=0;
        
        Console.WriteLine("¿Es alumno o maestro?");
        Console.WriteLine("1.- Uno para alumno");
        Console.WriteLine("2.- Dos para Maestro");
        
        opcion = Convert.ToInt32(Console.ReadLine());
        
        if(opcion == 1){
           encontro=validarAlumno(pCodigo); 
           
           if(encontro>=0){
                Alumnos.RemoveAt(encontro);
                return true;
           }else{
               return false;
           }
           
        } 
        if(opcion ==2){
            encontro=validarMaestro(pCodigo); 
            
            if(encontro>=0){
                Maestros.RemoveAt(encontro);
                return true;
           }else{
               return false;
           }
 
        }
        return false;
        
    }
    
    public void Controlar(){
        
       
    }
    
}