using System;
using System.Collections;
using System.Collections.Generic;
/*PAGINA .NET JFIDDLE*/
//Inicio de main
public class Program
{
    public static void Main() {
       
        string opcion="";
        int valor =0;
        bool alumno;
        
        CControl control = new CControl();
        
        
        while(valor!=3){
            
            valor=0;

            Console.WriteLine("***CONTROL ESCOLAR***");
            Console.WriteLine("1.-Ingrese uno para alumnos");
            Console.WriteLine("2.-Ingrese dos para maestros");
            Console.WriteLine("3.-Ingrese tres para salir");

        
            try{
                opcion =Console.ReadLine();
                valor = Convert.ToInt32(opcion);
            }catch(Exception e){
            }
        
             CPersona persona;
			//Menu principal
            switch(valor){
                case 1:
                    int opcioneAlumno=0;
                    string codigo="";
                    string nombre ="";
                    alumno = true;
                    
                    
                    control.getArregloAlumnos();
                    
                    opcionesArrayAlumno();
                    try{
                        opcioneAlumno = Convert.ToInt32(Console.ReadLine());

                    }catch(Exception e){
                        //Console.WriteLine("OPCION NO VALIDA {0}",e);
                    }
                    //Opcion para agregar alumno
                    if(opcioneAlumno==1){
                        
                        Console.WriteLine("Ingresa nombre del nuevo alumno");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingresa codigo del nuevo alumno");
                        codigo = Console.ReadLine();
                        
                        persona = new CAlumno(nombre,codigo);
                        control.AgregarPersona(persona);
                        
                    }
                    //Opcion para eliminar alumno
                    if(opcioneAlumno==2){
                        Console.WriteLine("Ingrese el codigo del alumno a eliminar");
                        codigo = Console.ReadLine();
                        control.EliminarPersona(codigo,alumno);
                    }
                    //Opcion para modificar alumno
                    if(opcioneAlumno==3){
                        int opcAModificar=0;
						
                        Console.WriteLine("Ingrese el codigo del alumno a modificar");
                        codigo = Console.ReadLine();
						
                        opcionAModificar();
                        opcAModificar = Convert.ToInt32(Console.ReadLine());
						
                        switch(opcAModificar){
                            case 1:
                               control.modificarPersona(codigo,alumno); 
                            break;
                            case 2:
                                control.modificarMateria(codigo,alumno);
                            break;
                        }
                        //control.modificarPersona(codigo,alumno);

                    }
                break;
                //Console.WriteLine("case de maestros");

                case 2:
                    int opcionesMaestro=0;
                    string nombreMaestro="";
                    codigo = "";
                    alumno = false;
                    
                    control.getArrayMaestros();
                    opcionesArrayMaestro();
                    
                    try{
                        opcionesMaestro = Convert.ToInt32(Console.ReadLine());

                    }catch(Exception e){

                    }
                    
                    if(opcionesMaestro==1){

                        Console.WriteLine("Ingrese nombre del maestro");
                        nombreMaestro = Console.ReadLine();
                        Console.WriteLine("Ingrese codigo del maestro");
                        codigo = Console.ReadLine();
                        
                        persona = new CMaestro(nombreMaestro,codigo);
                        
                        control.AgregarPersona(persona);

                    }
                    if(opcionesMaestro==2){
                        Console.WriteLine("Ingrese codigo del maestro a eliminar");
                        codigo = Console.ReadLine();
                        
                        control.EliminarPersona(codigo,alumno);
                    }
                    
                    if(opcionesMaestro==3){
                        Console.WriteLine("Ingrese codigo del maestro a modificar");
                        codigo = Console.ReadLine();
                        
                        control.modificarPersona(codigo,alumno);
                    }
                    

                break;
                
                case 3:
                    valor=3;
                    Console.WriteLine("adios");
                break;
                
                default:
                    Console.WriteLine("Opcion no valida");
                    //valor=3;
                    /*
                    if(valor==4)
                    */
                    
                    
                break;
                
            }  
            /*
            if(valor==3)
                break;
                
            */
        }
        

        
        
        
        
        

    }
    
    public static void opcionesArrayAlumno(){
        Console.WriteLine("***OPCIONES PARA ALUMNOS***");
        Console.WriteLine("Elige una opcion");
        Console.WriteLine("1.-Uno para agregar alumnos");
        Console.WriteLine("2.-Dos para eliminar alumno");
        Console.WriteLine("3.-Modificar alumno");
        Console.WriteLine("4.-Cuatro para regresar");


    }
    
    public static void opcionesArrayMaestro(){
        Console.WriteLine("***OPCIONES PARA MAESTROS***");

        Console.WriteLine("Elige una opcion");

        Console.WriteLine("1.-Uno para agregar maestro");
        Console.WriteLine("2.-Dos para eliminar maestro");
        Console.WriteLine("3.-Modificar maestro");
        Console.WriteLine("4.-Cuatro para regresar");

    }
    
    public static void opcionAModificar(){
        Console.WriteLine("1.-Uno para modificar datos");
        Console.WriteLine("2.-Dos para modificar materias");
    } 
	
	/*Ocpciones para materias*/
	
	public static void opcionesArrayMaterias(){
		Console.WriteLine("1.- Uno para agregar Materia");
		Console.WriteLine("2.- Dos eliminar Materia");

	}
    
    
}
//Fin de main
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
    
    List <CMateria>materias;
    
    public CMaterias(){
        
        materias = new List<CMateria>();
        CMateria espanol = new CMateria("español","lunes",5);
        
        materias.Add(espanol);
    }
    
    //Agregar materia
    public bool AddMateriaToList(CMateria pMateria){
        
		GetMaterias();
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
    
    public CMaterias materias = new CMaterias(); 
    
    public string Nombre{set{nombre = value;}get{return nombre;}}
    public string Codigo{set{codigo=value;}get{return codigo;}}
    
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
    
    //CMaterias materias = new CMaterias();
    
    List<CAlumno>Alumnos= new List<CAlumno>();
    List<CMaestro>Maestros= new List<CMaestro>();

    public CControl(){
       
        CAlumno alumno = new CAlumno("luis","0000");
        Alumnos.Add(alumno);
        
        CMaestro maestro = new CMaestro("pepe","0000");
        Maestros.Add(maestro);
       
        
    }
    //Metodo para validar alumno
    public int validarAlumno(string pCodigo){
        int posicion=-1;
       
        for(int i =0; i<Alumnos.Count; i++){
            if(Alumnos[i].Codigo == pCodigo){
                posicion = i;
            }
        }  
        
        return posicion;
    }
    //Metodo para validar maestro

    public int validarMaestro(string pCodigo){
        int posicion=-1;
       
        for(int i =0; i<Maestros.Count; i++){
            if(Maestros[i].Codigo == pCodigo){
                posicion = i;
            }
        }  
        
        return posicion;
    }
    
    //Metod para agregar alumno o maestro
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
    
    //Metodo para eliminar persona    
    public bool EliminarPersona(string pCodigo, bool pAlumno){
        int encontro=-1;

        if(pAlumno){
           encontro=validarAlumno(pCodigo); 
           
           if(encontro>=0){
                Alumnos.RemoveAt(encontro);
                return true;
           }else{
               return false;
           }
           
        } 
        if(!pAlumno){
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
    //Metodo para modificar alumno
    public bool modificarPersona(string pCodigo, bool pAlumno){
        int encontro = -1;
        string nombre="";
        string codigo="";
       
           if(pAlumno){
                encontro = validarAlumno(pCodigo);
                
                if(encontro>=0){
                    Console.WriteLine("Alumno a modificar: {0} ",Alumnos[encontro]);

                    Console.WriteLine("Ingrese el nuevo nombre");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo codigo");
                    codigo = Console.ReadLine();
            
                    if(nombre != "" && codigo!=""){
                        Alumnos[encontro].Nombre = nombre;
                        Alumnos[encontro].Codigo = codigo;
                        
                        return true;
                    } 
                }
                
            }
            
            if(!pAlumno){
                encontro = validarMaestro(pCodigo);
                
                if(encontro>=0){
                    Console.WriteLine("Maestro a modificar: {0} ",Maestros[encontro]);

                    Console.WriteLine("Ingrese el nuevo nombre");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo codigo");
                    codigo = Console.ReadLine();
            
                    if(nombre != "" && codigo!=""){
                        Maestros[encontro].Nombre = nombre;
                        Maestros[encontro].Codigo = codigo;
                        
                        return true;
                    } 
                }
                
                
            }
              
        return false;    
    } 
    

    //Mostrar todos los alumnos
    public void getArregloAlumnos(){
        
        Console.WriteLine("***ALUMNOS***");
        /*
        foreach(CAlumno alum in Alumnos){
            Console.WriteLine(alum);

        }
        */
        for(int i=0; i<Alumnos.Count;i++){
            Console.WriteLine("{0} {1}",i+1,Alumnos[i]);
        
            
        }
    }
	
	//Modificar materia
	public bool modificarMateria(string pCodigo, bool pAlumno){
		int encontro = -1;
		
		if(pAlumno){
			encontro = validarAlumno(pCodigo);
			if(encontro>=0){
				string nombre="";
				string dia="";
				int hora=0;
				
				Alumnos[encontro].materias.GetMaterias();

				Console.WriteLine("Ingresa nombre de la materia");
				nombre = Console.ReadLine();
				Console.WriteLine("Ingresa dia de la materia");
				dia = Console.ReadLine();
				Console.WriteLine("Ingresa hora de la materia");
				hora = Convert.ToInt32(Console.ReadLine());
				
				CMateria materia = new CMateria(nombre,dia,hora);	
				Alumnos[encontro].materias.AddMateriaToList(materia);
			}
			
		}
		if(!pAlumno){
		
		}
		
		return true;
	}
	
    //Mostrar todos los maestros
    public void getArrayMaestros(){
        Console.WriteLine("***Maestros***");

        foreach(CMaestro m in Maestros){
            Console.Write(m);
        }
    }
    
}