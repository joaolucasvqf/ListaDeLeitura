using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repositories.Interfaces
{
    public interface ILivroRepository
    {
        IEnumerable<Livro> Livros { get; }
        Livro GetById(string id);
        void salvarLivro(Livro livro);
        void removerLivro(Livro livro);
    }
}
