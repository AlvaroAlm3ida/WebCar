using WebCar.Data;
using WebCar.Models;

namespace WebCar.Repositorio
{
    public interface IVendasRepositorio
    {
        List<VendasModel> BuscarTodos();

        VendasModel Adicionar(VendasModel vendas);



    }
}
