using Nyous.Api.NoSql.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nyous.Api.NoSql.Interfaces
{
    interface IEventoRepository
    {
        List<Evento> Listar();

        void Adicionar(Evento evento);

        void Atualizar(string id, Evento evento);

        void Remover(string id);
    }
}
