using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Router("api/livro")]

    public class LivroController : Controller

    {
        [HttpPost]
        [Route("create")]

        public aluno create(livro produto)
        {
            produto.Name += "cadastrado"
            return livro;

        }
    }





}