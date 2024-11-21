using WebCar.Models;

namespace WebCar.Repositorio
{
    public interface ICadastroRepositorio
    {
        List<CadastroModel> BuscarTodos();

        CadastroModel Adicionar(CadastroModel Cadastros);
    }
}
