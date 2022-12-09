using QueryHub.Domain.Entities;
using System;
using System.Collections.Generic;

namespace QueryHub.Domain.Interfaces.Repository
{
    public interface IUsuarioService
    {
        void Cadastrar(Guid IdentificadorCliente, String Login, String Senha);
        void CadastrarAdministrador(Guid IdentificadorCliente, String Login, String Senha);
        void Atualizar(Guid IdentificadorCliente, Guid IdentificadorUsuario, String Login, String Senha);
        void Excluir(Guid IdentificadorUsuario);
        void ResetarSenha(Guid IdentificadorUsuario);
        IList<Usuario> Listar();
    }
}
