using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Domain.Entities
{
    public class Usuario
    {
        public Usuario()
        {
            UsuarioId = Guid.NewGuid();
        }

        public Guid UsuarioId { get; set; }

        public string Email { get; set; }

        public string NomeCompleto { get; set; }

        public string Username { get; set; }

        public DateTime DataRegistroA { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}
