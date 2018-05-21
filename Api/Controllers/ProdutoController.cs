using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Interfaces;
using Aplication.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/produto")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public IEnumerable<ProdutoViewModel> BuscarTodos()
        {
            return _produtoService.BuscarTodos();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(Guid id)
        {
            var produtoViewModel = _produtoService.BuscarPorId(id);
            if (produtoViewModel != null) {
                return Ok(produtoViewModel);
            }
            return BadRequest();
        }
    }
}