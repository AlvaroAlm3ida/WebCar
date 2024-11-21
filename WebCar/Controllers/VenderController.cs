using Microsoft.AspNetCore.Mvc;
using WebCar.Models;
using WebCar.Repositorio;

namespace WebCar.Controllers
{
    public class VenderController : Controller
    {
        private readonly IVendasRepositorio _vendasRepositorio;

        public VenderController(IVendasRepositorio vendasRepositorio)
        {
             _vendasRepositorio = vendasRepositorio;
        }
        

        public IActionResult Index()
        {
            return View();
        }

    [HttpPost]

        public IActionResult Anunciar(VendasModel vendas)
        {
            
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        _vendasRepositorio.Adicionar(vendas);
                        TempData["MensagemDeSucesso"] = "Anúncio Cadastrado com sucesso";
                        return RedirectToAction("Index");

                    }
                    return View(vendas);
                }
                catch (SystemException erro)
                {
                    TempData["MensagemErro"] = $"Ops, não conseguimos cadastra você ! Para mais detalhes:{erro.Message}";
                    return RedirectToAction("Index");
                }
            }
        }

      
    }
}
