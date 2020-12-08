using MongoDB.Driver;
using Nyous.Api.NoSql.Contexts;
using Nyous.Api.NoSql.Domains;
using Nyous.Api.NoSql.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nyous.Api.NoSql.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly IMongoCollection<Evento> _eventos;
        public EventoRepository(INyousDataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnetionString);
            var database = client.GetDatabase(settings.EventoColletionName);

            _eventos = database.GetCollection<Evento>(settings.EventoColletionName);
        }
        public void Adicionar(Evento evento)
        {
            try
            {
                _eventos.InsertOne(evento);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Atualizar(string id, Evento evento)
        {
            try
            {
                _eventos.ReplaceOne(c => c.Id == id, evento);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Evento> Listar()
        {
            try
            {
                return _eventos.AsQueryable<Evento>().ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Remover(string id)
        {
            try
            {
                _eventos.DeleteOne(c => c.Id == id);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
