using SpecificationPattern.Domain.Entities;
using SpecificationPattern.Domain.Rules.Base;
using SpecificationPattern.Domain.Specification.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Domain.Rules.Usuarios
{
    public class ClientePersistenteParaBD : ValidadorRegraBase<Usuario>
    {
        public ClientePersistenteParaBD()
        {
            var EspecificacaoUsuarioMaiorIdade = new UsuarioMaiorDeIdade();
            var EspecificacaoEmailValido = new UsuarioPossuiEmailValido();

            base.AdicionarRegra("UsuarioMaiorIdade", new Regra<Usuario>(EspecificacaoUsuarioMaiorIdade, "Usuário não é maior de idade"));
            base.AdicionarRegra("UsuarioPossuiEmailCorreto", new Regra<Usuario>(EspecificacaoEmailValido, "Email inválido"));
        }
    }
}
