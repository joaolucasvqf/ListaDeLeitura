using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Api.DTO;
using Api.Models;
using Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Api.Controllers
{
    [Produces("application/json", "text/plain")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private IConfiguration config;
        private readonly ILivroRepository _repository;
        public LivrosController(IConfiguration _config, ILivroRepository repository)
        {
            config = _config;
            _repository = repository;
        }
        /// <summary>
        /// Retorna os livrosde acordo com a pesquisa informada.
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [HttpGet("{param}")]
        public async Task<IActionResult> BuscarLivros(string param)
        {
            try
            {
                HttpClient client = new HttpClient();
                Uri urlRequisicao = new Uri(config.GetSection("Urls").GetSection("Base").Value + config.GetSection("Urls").GetSection("GetBooksCatalog").Value + param);
                HttpResponseMessage responseMessage = await client.GetAsync(urlRequisicao);
                string response = await responseMessage.Content.ReadAsStringAsync();

                List<LivroDTO> livrosDTO;
                try
                {
                    RespostaLivrosDTO resposta = JsonConvert.DeserializeObject<RespostaLivrosDTO>(response);
                    livrosDTO = resposta.items;
                }
                catch
                {
                    livrosDTO = new List<LivroDTO>();
                }
                List<Livro> livros = new List<Livro>();
                livrosDTO.ForEach(dto =>
                {
                    Livro livro = new Livro(dto);
                    livros.Add(livro);
                });

                List<dynamic> livrosList = new List<dynamic>();
                livros.ForEach(livro =>
                {
                    bool favorito = _repository.GetById(livro.Id) != null;
                    livrosList.Add(new
                    {
                        livro.Id,
                        livro.Etag,
                        livro.Title,
                        livro.Authors,
                        livro.Categories,
                        livro.Thumbnail,
                        livro.Description,
                        favorito
                    });
                });

                if (livrosList.Count > 0)
                    return Ok(livrosList);

                return NoContent();
            }
            catch (Exception e)
            {
                return UnprocessableEntity(e.Message);
            }
        }
        /// <summary>
        /// Lista todos os livros da lista de favoritos
        /// </summary>
        /// <returns></returns>
        [HttpGet("Favoritos")]
        public async Task<IActionResult> ListarFavoritos()
        {
            try
            {
                List<Livro> livros = (List<Livro>)_repository.Livros;

                if (livros != null && livros.Count > 0)
                    return Ok(livros);

                return NoContent();
            }
            catch (Exception e)
            {
                return UnprocessableEntity(e.Message);
            }
        }
        /// <summary>
        /// Obtém as informações relativas ao livro selecionado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Detalhes/{id}")]
        public async Task<IActionResult> ObterDetalhes(string id)
        {
            try
            {
                Livro livro = _repository.GetById(id);

                if (livro != null)
                    return Ok(livro);

                return NoContent();
            }
            catch (Exception e)
            {
                return UnprocessableEntity(e.Message);
            }
        }
        /// <summary>
        /// Adicionar um livro à lista de favoritos.
        /// </summary>
        /// <param name="livro"></param>
        /// <returns></returns>
        [HttpPost()]
        public async Task<IActionResult> RegistrarFavorito([FromBody] Livro livro)
        {
            try
            {
                _repository.salvarLivro(livro);

                return Ok();
            }
            catch (Exception e)
            {
                return UnprocessableEntity(e.Message);
            }
        }
        /// <summary>
        /// Remove o livroda lista de favoritos.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoverLivro(string id)
        {
            try
            {
                Livro livro = _repository.GetById(id);
                _repository.removerLivro(livro);

                return Ok();
            }
            catch (Exception e)
            {
                return UnprocessableEntity(e.Message);
            }
        }
    }
}