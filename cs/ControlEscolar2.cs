using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Control Escolar");
		
		
	}
}

//Class Perso
public abstract class CPerson
{
	public string Codigo{set;get;}
	private string nombre;
	private int edad;
	/*private List<CMateria> materias = new List<CMateria>();*/
	//public CRepoMaterias repoMaterias = new CRepoMaterias();
	public string Nombre{set{nombre = value;}get{return nombre;}}
	public int Edad{set{edad=value;}get{return edad;}}
	
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

public class CRepoPersona{
	
	private List<CAlumno> Alumnos=null;
	private List<CMaestro> Maestros =null;
	
	private int tipoPersona =0;
	
	public CRepoPersona(){
		Alumnos = new List<CAlumno>();
		Maestros = new List<CMaestro>();
		
		CAlumno alumno1 = new CAlumno("0000","luis",30);
		CMaestro maestro1 = new CMaestro("0000","angel",30);

	}
	//
	private void ElegirTipoPersona(){
		
		//int tipoPersona = 0;
		int opcion=0;
		
		while(tipoPersona==0){
			Console.WriteLine("Elige una opcion");
			Console.WriteLine("1 uno para alumnnos");
			Console.WriteLine("2 para maestros");
		
			opcion = Convert.ToInt32(Console.ReadLine());
		
			switch(opcion){
				case 1:
					tipoPersona=1;
				break;
				case 2:
					tipoPersona=2;
				break;
				default:
					Console.WriteLine("Opcion no valida, elige una opcion valida");
				break;	
				
			}
		}
		
		//return tipoPersona;
	}
	
	public int BuscarPersona(string pCodigo){
		int posicion =-1;
		//int tipoPersona = ElegirTipoPersona();
		//Revisar que esta linea corra correctamente
		ElegirTipoPersona();
		if(tipoPersona==1){
			
			for(int i=0; i<Alumnos.Count; i++){
				if(Alumnos[i].Codigo==pCodigo){
					posicion = i;
				}
			}
		}
		
		if(tipoPersona==2){
			
			for(int i=0; i<Maestros.Count; i++){
				if(Maestros[i].Codigo==pCodigo){
					posicion = i;
				}
			}
		}
			
		return posicion;
	}
	
	public bool ModificarPersona(string pCodigo){
		
		int encontro = BuscarPersona(pCodigo);
		string codigo="";
		string nombre="";
		int edad=0;
		
		if(encontro>=0){
			try{
				Console.WriteLine("Ingresa el nuevo codigo");
				codigo = Console.ReadLine();
				Console.WriteLine("Ingresa el nuevo nombre");
				nombre = Console.ReadLine();
				Console.WriteLine("Ingresa la nueva edad");
				edad = Convert.ToInt32(Console.ReadLine());
			
				if(tipoPersona==1){
					Alumnos[encontro].Codigo =codigo;
					Alumnos[encontro].Nombre = nombre;
					Alumnos[encontro].Edad = edad;

				}
				if(tipoPersona==2){
					Maestros[encontro].Codigo =codigo;
					Maestros[encontro].Nombre = nombre;
					Maestros[encontro].Edad = edad;

				}
			
				return true;
			}catch(Exception e){
				Console.WriteLine("ERROR: {0}", e);
			}
			
		}
		
		
		return false;
	}
	
}

/*
//Interface repositorio
public interface RepoPersona{
	bool AgregarPersona(CPerson pPerson);
	bool EliminarPersona(string pCodigo);
	bool ModificarPersona(string pCodigo);
	void VerPersonas();
	int BuscarPersona(string pCodigo);
}

//Clase repositorio alumnos
public class RepositorioAlumnos: RepoPersona{

	public List<CAlumno> Alumnos; 
	
	public RepositorioAlumnos(){
		Alumnos  = new List<CAlumno>();
		CAlumno alumno = new CAlumno("0000","luis",30);	
		Alumnos.Add(alumno);
	
	}
	//Buscar Persona
	public int BuscarPersona(string pCodigo){
		int posicion=-1;
		
		for(int i=0; i<Alumnos.Count;i++){
			if(Alumnos[i].Codigo==pCodigo){
				posicion = i;
			}
		}
				
		return posicion;
	}
	//Agregar alumno
	public bool AgregarPersona(CPerson pPerson){
	
		int encontro = BuscarPersona(pPerson.Codigo);
	
		if(encontro>=0){
			return false;
		}else{
		
			Alumnos.Add((CAlumno)pPerson);
			
			return true;

		}
		
	}
	//Eliminar alumno
	public bool EliminarPersona(string pCodigo){
		int encontro = BuscarPersona(pCodigo);
		
		if(encontro>=0){
			Alumnos.RemoveAt(encontro);
			return true;
		}else{
			return false;
		}
	}
	//Ver lista de alumnos
	public void VerPersonas(){
		
		foreach(CAlumno alu in Alumnos){
			Console.WriteLine(alu.ToString());
		}
	}
	//Modificar alumno
	public bool ModificarPersona(string pCodigo){
	
		int encontro = BuscarPersona(pCodigo);
		
		if(encontro>=0){
			
			Console.WriteLine("Alumno a modificar {0}",Alumnos[encontro]);
			
			
			return true;
		}else{
			return false;
		}
	}
}
*/
//Class Materia
public class CMateria
{
	private string codigo;
	private string nombre;
	private int hora;
	
	public string Codigo{get{return codigo;}set{codigo = value;}}
	public string Nombre{get{return nombre;}set{nombre = value;}}
	public int Hora{get{return hora;}set{hora = value;}}

	public CMateria(string pCodigo,string pNombre, int pHora)
	{
		codigo = pCodigo;
		nombre = pNombre;
		hora = pHora;
	}
	
	public override string ToString(){
		return string.Format("Codigo: "+Codigo+" nombre: "+ Nombre+" Hora: "+Hora);
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
		
		materiasDisponibles.Add(espanol);
		materiasDisponibles.Add(matematicas);
		materiasDisponibles.Add(historia);
		materiasDisponibles.Add(ingles);
		materiasDisponibles.Add(fisica);


	}
	
	public CMateria this[int indice]{
		get{
			return materiasDisponibles[indice];
		}
	}
	
	public void MostrarMateriasDisponibles(){
		foreach(CMateria m in materiasDisponibles){
			Console.WriteLine(m.ToString());
		}
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
			
			encontro=BuscarMateria(pMateria.Codigo);
			
			if(encontro<0){
				materiasDisponibles.Add(pMateria);
			}
			return true;

		}
		return false;
	}
	//Eliminar de materias disponibles  
	public bool EliminarMateria(string pCodigo){
		int encontro = -1;
		
		encontro = BuscarMateria(pCodigo);
		
		if(encontro>=0 && encontro<materiasDisponibles.Count){
			
			materiasDisponibles.RemoveAt(encontro);
			return true;
		}
		
		return false;
	}
	//Modificar materia de disponibles
	public bool ModificarMateria(string pCodigo){
		int encontro =-1;
		
		encontro = BuscarMateria(pCodigo);
		
		if(encontro>=0 && encontro<materiasDisponibles.Count){
			
			string codigo="";
			string nombre="";
			int hora=0;
			try{
				Console.WriteLine("Ingrese nuevo codigo");
				codigo = Console.ReadLine();
				Console.WriteLine("Ingrese nuevo nombre");
				nombre = Console.ReadLine();
				Console.WriteLine("Ingrese nueva hora");
				hora = Convert.ToInt32(Console.ReadLine());
			}catch(Exception e){
				Console.WriteLine("ERROR: {0}",e);
			}
			
			materiasDisponibles[encontro].Codigo = codigo;
			materiasDisponibles[encontro].Nombre = nombre;
			materiasDisponibles[encontro].Hora = hora;

			
			return true;
		}
		return false;
	}
	
}



//Class ControlEscolar
public class CControlEscolar
{	
	/*
	List<CAlumno> alumnos = new List<CAlumno>();
	List<CMaestro> maestros = new List<CMaestro>();
	*/
	CRepoMaterias repositorio = new CRepoMaterias();
	
	public CControlEscolar()
	{
		
	}
	
	
		
	
}
