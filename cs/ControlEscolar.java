import java.util.ArrayList;

public class MyClass {
    public static void main(String args[]) {
      
      CMovimientos baseDatos = new CMovimientos();
      
      CMaestro maestro = new CMaestro("luis","01");
      CAlumno alumno = new CAlumno("angel","02");
      baseDatos.agregarPersona(alumno);
      baseDatos.agregarPersona(alumno);

      baseDatos.recorrerLista();
    }
    
    //agregar alumnos y maestros
    //a cada maestro agregarle AULAS(a,b,c,d,e) MATERIAS(esp, mat, ingles, hist, fisica) GRUPOS(1,2,3,4,5)
}


//CLASE CONTROLADORA
class CMovimientos{
    
    private ArrayList<CAlumno> alumnos = new ArrayList<CAlumno>();
    private ArrayList<CMaestro> maestros = new ArrayList<CMaestro>();
    
    
    //valida si es maestro o alumno y su existencia
    
    public int validarPersona(String pMatricula, CPersona pPersona){
        int posicion=-1;
        
        if(pPersona instanceof CAlumno){
            for(int x=0; x<alumnos.size(); x++){
                if(alumnos.get(x).getMatricula()==pMatricula){
                    posicion=x;
                }
            }
        }
        
        if(pPersona instanceof CMaestro){
            for(int x=0; x<maestros.size(); x++){
                if(maestros.get(x).getMatricula()==pMatricula){
                    posicion=x;
                }
            }
        }
        
       return posicion; 
    }
    
    //agregar persona
    public boolean agregarPersona(CPersona pPersona){
        int posicion = validarPersona(pPersona.getMatricula(),pPersona);
        
        if(posicion>=0){
            System.out.println("LA PERSONA YA EXISTE");
            return false;
        }else{
            
            if(pPersona instanceof CAlumno){
                alumnos.add((CAlumno)pPersona);
            }
            
            if(pPersona instanceof CMaestro){
                maestros.add((CMaestro)pPersona);

            }
            
        }
        return true;
        
        
    }
    
    public void recorrerLista(){
        
        for(CAlumno alumno : alumnos){
            System.out.println(alumno);
        }
    }

    
}

//PERSONAS***

class CPersona{
    private String nombre;
    private String matricula;
    
    public CPersona(String pNombre, String pMatricula){
        nombre = pNombre;
        matricula = pMatricula;
    }
    
    public String toString(){
        String datos;
        datos = "Nombre: "+nombre+"\r\nMatricula: "+matricula; 
        return datos;
    }
    
    
    public String getNombre(){
        return nombre;
    }
    
    public String getMatricula(){
        return matricula;
    }
    
    
}
//CLASE ALUMNO
class CAlumno extends CPersona{
    
    public CAlumno(String pNombre, String pMatricula){
        super(pNombre,pMatricula);
    }
}

//CLASE MAESTRO

class CMaestro extends CPersona{
    
    public CMaestro(String pNombre, String pMatricula){
        super(pNombre,pMatricula);
    }
    
}

//REGISTROS***


//CLASE Registro

class CRegistro{
    private String nombre;
    
    public String getNombre(){
        return nombre;
    }
    
    public CRegistro(String pNombre){
        nombre = pNombre;
    }
    
    
    
    public String toString(){
        String datos;
        datos= "Nombre: "+nombre;
        return datos;
    }
    
}


//CLASE AULA

class CAula extends CRegistro{
    
    public CAula(String pNombre){
        super(pNombre);
    }
    
    @Override
    public String toString(){
        String datos;
        datos = "Nombre del aula: "+getNombre();
        return datos;
    }
}

//CLASE MATERIA

class CMateria extends CRegistro{
    
    public CMateria(String pNombre){
        super(pNombre);
    }
    
    @Override
    public String toString(){
        String datos;
        datos = "Nombre de la materia: "+getNombre();
        return datos;
    }
}

//CLASE GRUPO

class CGrupo extends CRegistro{
    
    public CGrupo(String pNombre){
        super(pNombre);
    }
    
    @Override
    public String toString(){
        String datos;
        datos = "Nombre del grupo: "+getNombre();
        return datos;
    }
}



