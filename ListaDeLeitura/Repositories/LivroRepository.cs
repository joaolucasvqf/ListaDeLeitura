using Api.DataBase;
using Api.Models;
using Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly AppDbContext _context;
        public LivroRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Livro> Livros => _context.livrosFavoritos.ToList();

        public Livro GetById(string id)
        {
            return _context.livrosFavoritos.FirstOrDefault(l => l.Id == id);
        }

        public void removerLivro(Livro livro)
        {
            _context.livrosFavoritos.Remove(livro);
            _context.SaveChanges();
        }

        public void salvarLivro(Livro livro)
        {
            _context.livrosFavoritos.Add(livro);
            _context.SaveChanges();
        }
    }
}
