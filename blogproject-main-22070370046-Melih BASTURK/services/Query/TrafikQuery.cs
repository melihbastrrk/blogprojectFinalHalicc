using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.tables;
using MediatR;
using data.uows;
using Microsoft.EntityFrameworkCore;

namespace services.Query
{
    public class TrafikQuery: IRequest<List<Trafik>>//Trafik türündeki veriyi liste olarak döndür
    {

        public class Handler : IRequestHandler<TrafikQuery,List<Trafik>>
        {
            public async Task<List<Trafik>> Handle(TrafikQuery request, CancellationToken cancellationToken)
            {// sorgu işlenir.
                var uow = new BlogUnitOfWork();
                var trafik = await uow.trafikRepository.GetQuery()//veri tabanından trafik alınır.
                .ToListAsync();// liste verir
                return trafik;//trafik döndürür.
            }
        }
    }
}

