using ViewModels;
namespace Mappers
{
    public class MapperViewModel {
        
        public MapperViewModel(){

        }
        
        public Cadete getCadete(CadeteViewModel cad){
            Cadete NuevoCadete = new Cadete(cad.ID,cad.Nombre,cad.Direccion,cad.Telefono);
            return NuevoCadete;
        }

        public CadeteViewModel getCadeteViewModel(Cadete cad){
            CadeteViewModel nuevoViewModel = new CadeteViewModel();
            nuevoViewModel.ID = cad.ID;
            nuevoViewModel.Nombre = cad.Nombre;
            nuevoViewModel.Direccion = cad.Direccion;
            nuevoViewModel.Telefono = cad.Telefono;
            return nuevoViewModel;
        }

        public List<CadeteViewModel> getListViewModel(List<Cadete> Cadetes){
            List<CadeteViewModel> NuevaLista = new List<CadeteViewModel>();
            foreach (var cad in Cadetes)
            {
                CadeteViewModel NuevoViewModel = new CadeteViewModel();
                NuevoViewModel.ID = cad.ID;
                NuevoViewModel.Nombre = cad.Nombre;
                NuevoViewModel.Direccion = cad.Direccion;
                NuevoViewModel.Telefono = cad.Telefono;
                NuevaLista.Add(NuevoViewModel);
            }
            return NuevaLista;
        }
        /*
        public Pedido getPedido(PedidoVIewModels pedido){
            Pedido nuevo = new Pedido(pedido.Nro,pedido.Obs, pedido.id_cliente, pedido.estado,pedido.id_cadete);
            return nuevo;
        }

        public PedidoViewModels getPedidoViewModels(Pedido pedido){
            PedidoViewModels nuevo = new PedidoViewModels(pedido.Nro,pedido.Obs, pedido.id_cliente, pedido.estado,pedido.id_cadete);
            return nuevo;
        }
        */
    }
}