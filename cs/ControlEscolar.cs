using System;
using System.Collections;

class Program
{
    static void Main() {
        /*
        int x = 10;
        int y = 25;
        int z = x + y;

        Console.Write("Sum of x + y = "+ z);
        */
        
        CControl control = new CControl();
        
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
    
    public CMateria(string pNombre, string pDia, int pHora){
        nombre = pNombre;
        dia = pDia;
        hora = pHora;
    }
    
    public override string ToString(){
        return string.Format("Nombre: {0}\r Dia: {1}\r Hora: {2}",nombre,dia,hora);
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
    
    ArrayList materias = new ArrayList();
    ArrayList alumnos = new ArrayList();
    ArrayList maestros = new ArrayList();
    
    public CControl(){
        CMateria espanol = new CMateria("español","lunes",5);
        materias.Add(espanol);
        
    }
    
    public void GetMaterias(){
       foreach(CMateria materia in materias){
            Console.WriteLine(materia.ToString());
        } 
    }
    

       
    
}