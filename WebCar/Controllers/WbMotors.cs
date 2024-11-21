using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebCar.Data;
using WebCar.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebCar.Controllers
{
    public class WbMotors : Controller
    {
        private readonly CarroContext _carroContext;

        public WbMotors(CarroContext carroContext)
        {
            _carroContext = carroContext;
        }
        public async Task<IActionResult> Index()
        {
            // Carregar as vendas com apenas os dados necessários (sem carregar a imagem ou outros campos desnecessários)
            var vendas = await _carroContext.Vendas
                .Select(v => new VendasModel
                {
                    Id = v.Id,
                    NomeCarro = v.NomeCarro,
                    ValorVenda = v.ValorVenda,
                    AnoCarro = v.AnoCarro,
                    Km = v.Km,
                    Localizacao = v.Localizacao
                })
                .ToListAsync();

            return View(vendas); // Passa as vendas para a view, agora com menos dados
        }
    }


}
