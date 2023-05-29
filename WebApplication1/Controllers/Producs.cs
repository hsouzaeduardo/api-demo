using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Create()
        {
            var model = new Product();

            model.Categories = GetCategories();

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Product model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Lógica para processar o produto recebido
            // Aqui, você pode salvar os dados do produto no banco de dados ou realizar outras operações

            // Redirecionar para uma página de confirmação ou outra ação, se necessário
            return View("Create");
        }
            private List<SelectListItem> GetCategories()
        {
            // Lógica para obter as categorias de produtos do banco de dados ou de outra fonte de dados
            // Aqui, estou apenas simulando algumas categorias de exemplo

            var categories = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Eletrônicos" },
            new SelectListItem { Value = "2", Text = "Roupas" },
            new SelectListItem { Value = "3", Text = "Acessórios" }
        };

            return categories;
        }
    }
}
