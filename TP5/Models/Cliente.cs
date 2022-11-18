public class Cliente : Persona{
        private string datosReferencia { get; set; }

        Cliente(int ID, string nombre, string direccion, string telefono, string datosReferencia) : base(ID,nombre,direccion,telefono){
                this.datosReferencia=datosReferencia;
        }
}