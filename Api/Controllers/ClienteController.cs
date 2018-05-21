using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Interfaces;
using Aplication.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/cliente")]
    public class ClienteController : Controller
    {
        private readonly IHostingEnvironment _environment;
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService, IHostingEnvironment environment)
        {
            _environment = environment;
            _clienteService = clienteService;
        }

        [HttpGet]
        public IActionResult BuscarTodos() {
            var clientesViewModel = _clienteService.BuscarTodos().ToList();
            clientesViewModel.ForEach(x =>
            {
                if (x.File != null) {
                    x.File = this.retornarImagem(x.Foto);
                }
            });
            return Ok(clientesViewModel);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(Guid id) {
            var clienteViewModel = _clienteService.BuscarPorId(id);
            clienteViewModel.File = this.retornarImagem(clienteViewModel.Foto);
            if (clienteViewModel != null) {
                return Ok(clienteViewModel);
            }
            return BadRequest();
        }

        [HttpPost]
        public IActionResult Salvar([FromBody]ClienteViewModel clienteViewModel)
        {
            var cliente = _clienteService.Salvar(clienteViewModel);
            if (cliente.File != null) {
                cliente.File = this.retornarImagem(cliente.Foto);
            }
            if (cliente != null) {
                return Ok(cliente);
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(Guid id) {
            _clienteService.Excluir(id);
            return Ok();
        }


        [HttpPost]
        [Route("upload/{id}")]
        public IActionResult UploadFoto(IFormFile file, Guid id)
        {
            var uploads = Path.Combine(_environment.WebRootPath, "uploads\\" + id);
            if (file.Length > 0)
            {
                if (!Directory.Exists(uploads + "\\" + id))
                {
                    Directory.CreateDirectory(uploads + "\\" + id);
                }
                using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                {
                    file.CopyTo(fileStream);
                    var cliente = _clienteService.BuscarPorId(id);
                    cliente.Foto = file.FileName;
                    _clienteService.Editar(cliente.Id, cliente);
                    return Ok();
                }
            }
            return BadRequest();
        }

        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"}
            };
        }


        public String retornarImagem(string caminhoImagem)
        {
            var path = _environment.WebRootPath + "\\uploads\\" + caminhoImagem;
            byte[] imageBytes = System.IO.File.ReadAllBytes(path);
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }

    }
}