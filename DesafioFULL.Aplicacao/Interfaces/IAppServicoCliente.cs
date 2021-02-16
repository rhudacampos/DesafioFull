﻿using DesafioFULL.Dominio.Entidades;

namespace DesafioFULL.Aplicacao.Interfaces
{
    public interface IAppServicoCliente : IAppServicoBase<Cliente>
    {
        void Cadastrar(Cliente cliente);
    }
}