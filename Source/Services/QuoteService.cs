using System;
using System.Linq;
using Codenation.Challenge.Models;

namespace Codenation.Challenge.Services
{
    public class QuoteService : IQuoteService
    {
        private ScriptsContext _context;
        private IRandomService _randomService;

        public QuoteService(ScriptsContext context, IRandomService randomService)
        {
            this._context = context;
            this._randomService = randomService;

        }

        public Quote GetAnyQuote()
        {

            
            //lista inteira de Quotes
            var x = _context.Quotes.ToList();
            if (x == null)
                return null;

            // a partir do tamanho da lista, retorna um valor aleatório que utilizaremos de index
            //var index = new System.Random().Next(x.Count);
            var index = _randomService.RandomInteger(x.Count);
            //retorno produto aleatorio
            var retorno = x.Skip(index).FirstOrDefault();

            return retorno;
        }

        public Quote GetAnyQuote(string actor)
        {
            //lista inteira de Quotes

            var x = _context.Quotes.Where(s => s.Actor == actor).ToList();
            if (x == null)
                return null;

            // a partir do tamanho da lista, retorna um valor aleatório que utilizaremos de index
            var index = _randomService.RandomInteger(x.Count);

            //retorno produto aleatorio
            var retorno = x.Skip(index).FirstOrDefault();

            return retorno;

        }
    }
}