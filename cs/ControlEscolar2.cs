//Rextester.Program.Main is the entry point for your code. Don't change it.
//Microsoft (R) Visual C# Compiler version 2.9.0.63208 (958f2354)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Hello, world!");
        }
    }
    
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
    //CLASE PERSONA
    //************
    //************
    class CPersona{
        private string nombre;
        private string codigo;
        private List<CMateria> materias = new List<CMateria>();
	
    
    //public CMaterias materias = new CMaterias(); 
    
        public string Nombre{set{nombre = value;}get{return nombre;}}
        public string Codigo{set{codigo=value;}get{return codigo;}}
        //Constructor de CPersona
        public CPersona(string pNombre, string pCodigo){
            nombre = pNombre;
            codigo = pCodigo;
        }
    
        public override string ToString(){
            return string.Format("NOMBRE: {0} CODIGO: {1}\r\n",nombre,codigo);
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
        List<CAlumno>Alumnos= new List<CAlumno>();
        List<CMaestro>Maestros= new List<CMaestro>();
	    
        //Constructor de CControl
        public CControl(){
       
            CAlumno alumno = new CAlumno("luis","0000");
            Alumnos.Add(alumno);
        
            CMaestro maestro = new CMaestro("pepe","0000");
            Maestros.Add(maestro);
       
        
        }
	
        public int ValidarPersona(string codigo, bool pIsAlumno){
            int posicion=-1;
            if(pIsAlumno){
			
                for(int i=0;i<Alumnos.Count;i++){
                    if(Alumnos[i].Codigo==codigo){
                        return posicion;

                    }
                }
            }
            return posicion;
		
        }
	
    }
}