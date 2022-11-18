public class Persona{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }

    public Persona(int ID, string nombre, string direccion, string telefono)
    {
        this.ID = ID;
        this.Nombre = nombre;
        this.Direccion = direccion;
        this.Telefono = telefono;
    }

}