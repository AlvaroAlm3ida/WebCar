using Microsoft.AspNetCore.Mvc;
using WebCar.Models;
using WebCar.Repositorio;

namespace WebCar.Controllers
{
    public class FormularioCadastro : Controller
    {
        private readonly ICadastroRepositorio _cadastroRepositorio;

        public FormularioCadastro(ICadastroRepositorio CadastroRepositorio)
        {
            _cadastroRepositorio = CadastroRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Criar(CadastroModel Cadastros)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _cadastroRepositorio.Adicionar(Cadastros);
                    TempData["MensagemDeSucesso"] = "Usuário Cadastrado com sucesso";
                    return RedirectToAction("Index");

                }
                return View(Cadastros);
            }
            catch (SystemException erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastra você ! Para mais detalhes:{erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}