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
	private string nombre;
	private int edad;
	private List<CMateria> materias = new List<CMateria>();
	public CPerson(string pNombre, int pEdad)
	{
		nombre = pNombre;
		edad = pEdad;
	}

	public override string ToString()
	{
		return string.Format("Nombre: {0} Edad: {1}", nombre, edad);
	}
}

//Class Alumno
public class CAlumno : CPerson
{
	public CAlumno(string pNombre, int pEdad): base(pNombre, pEdad)
	{
	}
}

//Class Maestro
public class CMaestro : CPerson
{
	public CMaestro(string pNombre, int pEdad): base(pNombre, pEdad)
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
	public List<CMateria> materiasDisponibles
	{
		set;
		get;
	}

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
	public CRepoMaterias repoMaterias
	{
		set;
		get;
	}

	public CControlEscolar()
	{
		repoMaterias = new CRepoMaterias();
	}
}