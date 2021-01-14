public class MyClass {
    public static void main(String args[]) {
      int x=10;
      int y=25;
      int z=x+y;

      System.out.println("Sum of x+y = " + z);
    }
    
    //agregar alumnos y maestros
    //a cada maestro agregarle AULAS(a,b,c,d,e) MATERIAS(esp, mat, ingles, hist, fisica) GRUPOS(1,2,3,4,5)
}



class CMovimientos{
    
    private ArrayList<CAlumno> alumnos = new ArrayList<CAlumno>();
    private ArrayList<CMaestro> maestros = new ArrayList<CMaestro>();
    
    
    //valida si es maestro o alumno y su existencia
    
    public int validarPersona(String pMatricula, CPersona pPersona){
        int posicion=-1;
        
        if(pPersona instanceof CAlumno){
            for(int x=0; x<alumnos.length; x++){
                if(alumnos[x].getMatricula()==pMatricula){
                    posicion=x;
                }
            }
        }
        
        if(pPersona instanceof CMaestro){
            for(int x=0; x<CMaestro.length; x++){
                if(maestros[x].getMatricula()==pMatricula){
                    posicion=x;
                }
            }
        }
        
       return posicion; 
    }
    
    public void agregarPersona(CPersona pPersona){
        
        
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
    
}

//CLASE MAESTRO

class CMaestro extends CPersona{
    
}

//REGISTROS***


//CLASE Registro

class CRegistro{
    private String nombre;
    
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
    
    @Override
    public String toString(){
        String datos;
        datos: = "Nombre del aula: "+nombre;
        return datos;
    }
}

//CLASE MATERIA

class CMateria extends CRegistro{
    
    @Override
    public String toString(){
        String datos;
        datos: = "Nombre de la materia: "+nombre;
        return datos;
    }
}

//CLASE GRUPO

class CGrupo extends CRegistro{
    
    @Override
    public String toString(){
        String datos;
        datos: = "Nombre del grupo: "+nombre;
        return datos;
    }
}



