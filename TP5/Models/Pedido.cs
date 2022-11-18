public class Pedido{
    public int Numero;
    public string Obs;
    public Cliente Cliente;
    public EstadoPedido Estado;
    public int NumeroCadete;

    public enum EstadoPedido{
        Pendiente,
        EnCamino,
        Entregado
    }

    public Pedido(int Numero, string Obs, Cliente Cliente, EstadoPedido Estado, int NumeroCadete){
        this.Numero=Numero;
        this.Obs=Obs;
        this.Cliente=Cliente;
        this.Estado=Estado;
        this.NumeroCadete=NumeroCadete;
    }
}