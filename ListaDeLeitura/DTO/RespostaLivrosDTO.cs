using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTO
{
    public class RespostaLivrosDTO
    {
        public string kind { get; set; }
        public int totalItems { get; set; }
        public List<LivroDTO> items { get; set; }
    }
}
