using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class CadeteViewModel{
        public int ID ;
        [Required] [StringLength(1000)] 
        public string Nombre {get;set;}
        [Required] [StringLength(1000)] 
        public string Direccion {get;set;}
        [Phone]
        public string Telefono {get;set;}
    }
}