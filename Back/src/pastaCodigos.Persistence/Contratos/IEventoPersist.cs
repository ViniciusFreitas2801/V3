using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pastaCodigos.Domain;

namespace pastaCodigos.Persistence.Contratos
{
    public interface IEventoPersist
    {
        Task<Evento> GetAllEventosByTemaAsync(string tema, int eventoId, bool includePalestrantes = false);
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false);
    }
}