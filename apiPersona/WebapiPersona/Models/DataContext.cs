
namespace WebapiPersona.Models
{
    using System.Data.Entity;
    public class DataContext: DbContext //Aumentamos :DbContext y creamos la libreria para que ya no marque error. Click derecho en el proyecto y le damos a Administrar paquetes nuget, en el buscador ponemos entityframework, le damos examinar y esocogemos el primero e instalar y aceptar a todo. Le damos otra vez control punto a la palabra y escogemos el primero para crear la libreria y nos dejará de dar error
    {
        // ctor, tap tap y aparece public DataContext(){}
        public DataContext():base("DefaultConnection") //escribimos :base("DefaultConnection") Con esto terminamos de enlazar con la base de datos wuuu 20 puntos
        {

        }

        public System.Data.Entity.DbSet<WebapiPersona.Models.Person> People { get; set; }
    }
}