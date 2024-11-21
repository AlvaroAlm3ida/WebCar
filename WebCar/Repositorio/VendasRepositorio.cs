using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCar.Data;
using WebCar.Models;

namespace WebCar.Repositorio
{

    public class VendasRepositorio : IVendasRepositorio
    {

        //Injeção de dependencia     &   class Private tem que começar com letra minuscula e _
        private readonly CarroContext _carroContext;

        public VendasRepositorio(CarroContext carroContext)
        {
            _carroContext = carroContext;
        }
        public List<VendasModel> BuscarTodos()
        {
            return _carroContext.Vendas.ToList();
        }
        public VendasModel Adicionar(VendasModel vendas)
        {
            //Gravar no banco de dados
            _carroContext.Vendas.Add(vendas);
            _carroContext.SaveChanges();

            return vendas;




        }

    }
 } 

