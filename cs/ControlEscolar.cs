using System;
using System.Collections;
using System.Collections.Generic;


class Program
{
    static void Main() {
       
        CControl control = new CControl();
        CMateria materia = new CMateria("matematicas","lunes",6);
        
        control.GetMaterias();
        control.AddMateriaToList(materia);
        control.GetMaterias();

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

//CLASE PERSONA
//************
//************
class CPersona{
    private string nombre;
    private string codigo;
    
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
    
    List <CMateria>materias = new List<CMateria>();
    ArrayList alumnos = new ArrayList();
    ArrayList maestros = new ArrayList();
    
    //Constructor de la clase CControl
    public CControl(){
        CMateria espanol = new CMateria("español","lunes",5);
        materias.Add(espanol);
        
        CAlumno alumno0 = new CAlumno("luis","0000");
        alumnos.Add(alumno0);
        
        CMaestro maestro0 = new CMaestro("pablo","0000");
        maestros.Add(maestro0);
        
        
    }
    //Mostrar materias
    public void GetMaterias(){
       foreach(CMateria materia in materias){
            Console.WriteLine(materia.ToString());
        } 
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
    
    //Agregar materia
    
    public bool AddMateriaToList(CMateria pMateria){
        
        if(pMateria is CMateria && pMateria!=null){
           materias.Add(pMateria);
           return true;
        }
        
        return false;
        
    }
    /*
    public bool RemoveMateriToList(){
        
    }
    */

       
    
}