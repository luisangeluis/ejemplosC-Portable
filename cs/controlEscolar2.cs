using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Control Escolar");
	}
}

//Class Person
public abstract class CPerson
{
	public string Codigo{set;get;}
	private string nombre;
	private int edad;
	private List<CMateria> materias = new List<CMateria>();
	
	public CPerson(string pCodigo,string pNombre, int pEdad)
	{
		Codigo = pCodigo;
		nombre = pNombre;
		edad = pEdad;
	}

	public override string ToString()
	{
		return string.Format("Codig: {0} Nombre: {1} Edad: {2}",Codigo,nombre, edad);
	}
}

//Class Alumno
public class CAlumno : CPerson
{
	public CAlumno(string pCodigo,string pNombre, int pEdad): base(pCodigo,pNombre, pEdad)
	{
	}
}

//Class Maestro
public class CMaestro : CPerson
{
	public CMaestro(string pCodigo,string pNombre, int pEdad): base(pCodigo,pNombre, pEdad)
	{
	}
}

//Class Materia
public class CMateria
{
	private string nombre;
	private int hora;
	
	public CMateria(string pNombre, int pHora)
	{
		nombre = pNombre;
		hora = pHora;
	}
}

//Class Repositorio materias
public class CRepoMaterias
{
	public List<CMateria> materiasDisponibles{set;get;}

	public CRepoMaterias()
	{
		materiasDisponibles = new List<CMateria>();
		CMateria espanol = new CMateria("espanol", 5);
		CMateria matematicas = new CMateria("matematicas", 6);
		CMateria historia = new CMateria("historia", 7);
		CMateria ingles = new CMateria("ingles", 8);
		CMateria fisica = new CMateria("fisica", 9);
	}
	
	
}

//Class ControlEscolar
public class CControlEscolar
{
	List<CAlumno> alumnos = new List<CAlumno>();
	List<CMaestro> maestros = new List<CMaestro>();
	
	private bool isAlumno=true;
	
	public CRepoMaterias repoMaterias{set;get;}

	public CControlEscolar()
	{
		repoMaterias = new CRepoMaterias();
	}
	
	//Metodo para buscar persona
	public int BuscarPersona(bool pIsAlumno,string pCodigo){
		int posicion=-1;
		if(pIsAlumno){
			for(int i=0;i<alumnos.Count;i++){
				if(alumnos[i].Codigo==pCodigo)
					posicion=i;
			}
		}else{
			for(int i=0;i<maestros.Count;i++){
				if(maestros[i].Codigo==pCodigo){
					posicion=i;
				}
			}
				
		}
		return posicion;
	}
	//Fin de Metodo para buscar persona
	//Metodo para agregar persona
	public bool AgregarPersona(CPerson pPerson){
		
		int posicionEncontrada=-1;
		
		if(pPerson is CAlumno){
			posicionEncontrada = BuscarPersona(true,pPerson.Codigo);
			
			if(posicionEncontrada<0){
				alumnos.Add((CAlumno)pPerson);
				return true;
			}else{
				Console.WriteLine("Alumno ya exite,No agregado");
				return false;
			}
		}
		
		if(pPerson is CMaestro){
			posicionEncontrada = BuscarPersona(false,pPerson.Codigo);
			
			if(posicionEncontrada<0){
				maestros.Add((CMaestro)pPerson);
				return true;
			}else{
				Console.WriteLine("Maestro ya existe, No agregado");
				return false;

			}
		}
		
		return false;
	}
	//Fin de Metodo para agregar persona
	//Metodo para eliminar persona
	public bool EliminarPersona(bool pIsAlumno,string pCodigo){
		int posicionEncontrada=-1;
		
		posicionEncontrada =BuscarPersona(pIsAlumno,pCodigo);
		
		if(posicionEncontrada>0){
			if(pIsAlumno){
				alumnos.RemoveAt(posicionEncontrada);
			}else{
				maestros.RemoveAt(posicionEncontrada);

			}
			return true;
		}else{
			Console.WriteLine("Codigo no encontrado");
			return false;
		}
		
	}
	//Fin de Metodo para eliminar persona

	
	
	
}
