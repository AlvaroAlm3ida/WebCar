using WebCar.Data;
using WebCar.Models;

namespace WebCar.Repositorio
{
    public class CadastroRepositorio : ICadastroRepositorio
    {
        //Injeção de dependencia     &   class Private tem que começar com letra minuscula e _
        private readonly BancoContext _bancoContext;

       public CadastroRepositorio(BancoContext bancoContext) 
        { 
            _bancoContext = bancoContext;
        }

        public List<CadastroModel> BuscarTodos()
        {
            return _bancoContext.Cadastros.ToList();
        }

        public CadastroModel Adicionar(CadastroModel Cadastros)
        {
            // Gravar no banco de dados
            _bancoContext.Cadastros.Add(Cadastros);
            _bancoContext.SaveChanges();

            return Cadastros;
        }


    }
}
