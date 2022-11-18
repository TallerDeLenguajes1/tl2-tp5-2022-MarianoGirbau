public class Cadete : Persona{

    //private int PagoPedidos=300;
    public Cadete(int ID, string Nombre, string Direccion, string Telefono) : base(ID,Nombre,Direccion,Telefono){
    }

    public void setID (int ID){
        this.ID=ID;
    }
    
    public int getID (){
        return this.ID;
    }
    
    /*
    public void ListarPedidos(){
        foreach (var pedido in Pedidos)
        {
            Console.WriteLine("Numero de pedido: "+pedido.Numero);
            Console.WriteLine("Observacion: "+pedido.Obs);
            Console.WriteLine("Cliente: "+pedido.Cliente);
            Console.WriteLine("Estado: "+pedido.Estado);
        }
    }
    public int JornadaACobrar(){
        return Pedidos.Where(x => x.Estado == Pedido.EstadoPedido.Entregado).ToList().Count * PagoPedidos;
    }
    */
}