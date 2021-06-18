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
	
	public CControlEscolar()
	{
		
	}
	//Buscar alumnos
	public int BuscarAlumno(string pCodigo){
		int posicion=-1;
		
		for(int i=0; i<alumnos.Count;i++){
			if(alumnos[i].Codigo==pCodigo){
				posicion =i;
			}
		}
		
		
		return posicion;
	}
	//Buscar maestros
	public int BuscarMaestro(string pCodigo){
		int posicion =-1;
		
		for(int i=0; i<maestros.Count; i++){
			if(maestros[i].Codigo==pCodigo){
				posicion =i;
			}
		}
		return posicion;
	}
	//Agregar Alumnos
	
	public bool AgregarAlumno(CAlumno pAlumno){
		
		int encontro=BuscarAlumno(pAlumno.Codigo);
		
		if(encontro<0){
			alumnos.Add(pAlumno);
			return true;
		}
		
		return false;
	}
	
	public bool AgregarMaestro(CMaestro pMaestro){
		int encontro = BuscarMaestro(pMaestro.Codigo);
		
		if(encontro<0){
			maestros.Add(pMaestro);
			return true;
		}
		return false;
	}
	
}