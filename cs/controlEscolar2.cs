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
	private string codigo;
	private string nombre;
	private int hora;
	
	public string Codigo{
		
		get{
			return codigo;
		}
	}
	
	public CMateria(string pCodigo,string pNombre, int pHora)
	{
		codigo = pCodigo;
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
		CMateria espanol = new CMateria("000","espanol", 5);
		CMateria matematicas = new CMateria("001","matematicas", 6);
		CMateria historia = new CMateria("002","historia", 7);
		CMateria ingles = new CMateria("003","ingles", 8);
		CMateria fisica = new CMateria("004","fisica", 9);
	}
	
	//Buscar Materia en disponibles
	public int BuscarMateria(string pCodigo){
		int posicion=-1;
		
		for(int i=0; i<materiasDisponibles.Count;i++){
			if(materiasDisponibles[i].Codigo==pCodigo){
				posicion=i;
			}
		}
		return posicion;
	}
	
	//Agregar materia a materias disponibles
	public bool AgregarMateria(CMateria pMateria){
		int encontro=-1;
		
		if(pMateria!=null){
			
			encontro =BuscarMateria(pMateria.Codigo);
			
			if(encontro<0){
				materiasDisponibles.Add(pMateria);
			}
			return true;

		}
		return false;
	}
	
	
	
	
}

//Class ControlEscolar
public class CControlEscolar
{
	List<CAlumno> alumnos = new List<CAlumno>();
	List<CMaestro> maestros = new List<CMaestro>();
	
	CRepoMaterias repositorio = new CRepoMaterias();
	
	public CControlEscolar()
	{
		
	}
	
	public bool AddMateriaToAlumno(string pCodigo){
		
		return false;
	}
	
	
}
