import java.util.ArrayList;
import java.util.List;

public class MyClass {
    public static void main(String args[]) {
      
      
        CAlumno alumno1 = new CAlumno("luis",29,"0000");
        CAlumno alumno2 = new CAlumno("angel",30,"0001");
        CAlumno alumno3 = new CAlumno("zepeda",31,"0002");
        
        CRegistoAlumnos registro = new CRegistoAlumnos();
        
        registro.agregarAlumno(alumno1);
        registro.agregarAlumno(alumno2);
        registro.agregarAlumno(alumno3);

        registro.mostrarAlumnos();
        
        

    }
}

class CAlumno{
    private String nombre;
    private int edad;
    private String matricula;
    
    public CAlumno(String pNombre, int pEdad, String pMatricula){
        nombre = pNombre;
        edad = pEdad;
        matricula = pMatricula;
    }
    
    public String toString(){
        String datos;
        datos ="nombre: "+nombre+" edad: "+edad+" matricula: "+matricula;
        return datos;
    }
}


class CRegistoAlumnos{
    
    private List<CAlumno> alumnos= new ArrayList<CAlumno>();
    
    
    
    
    public void agregarAlumno(CAlumno pAlumno){
        
        if(pAlumno!=null){
            alumnos.add(pAlumno);

        }
        
    }
    
    public void mostrarAlumnos(){
        for(CAlumno aux: alumnos){
            System.out.println(aux.toString());
        }
    }
    
    
}