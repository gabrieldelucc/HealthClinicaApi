﻿using webapi.healthclinica.tarde.Domains;

namespace webapi.healthclinicaapi.tarde.Interfaces
{
    public interface IMedicoRepository
    {

        void Cadastrar(Medico medico);

        void Deletar(Guid id);

        List<Medico> Listar();

        Medico BuscarPorId(Guid id); 


         
    }
}
