namespace WebApi.Controllers
{
    public class Alumno
    {
        //creando propiedades
        string nombre;
        string apellido;
        string dni;
        DateTime fechanacimiento;

        //constructor sin parametros 
        public Alumno()
        {
            nombre = string.Empty;
            apellido = string.Empty;
            dni = string.Empty;
            fechanacimiento = DateTime.Now;
        }
        //construcutor con parametros
        public Alumno(string pnombre, string papellido, string pdni)
        {
            nombre = pnombre;
            apellido = papellido;
            dni = pdni;
        }

        public Alumno(string pnombre, string papellido, string pdni, DateTime pfechanacimiento)
        {
            nombre = pnombre;
            apellido = papellido;
            dni = pdni;
            fechanacimiento = pfechanacimiento;
        }

        public string DevolverEDad()
        {
            return dni;
        }

        public int DevolverEdad()
        {
            return DateTime.Now.Year - fechanacimiento.Year;
        }

    }
}
