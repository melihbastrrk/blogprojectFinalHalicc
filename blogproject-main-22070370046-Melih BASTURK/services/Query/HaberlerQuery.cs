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
    public class HaberlerQuery: IRequest<List<Haberler>> //Haberler türündeki veriyi liste olarak döndür
    {

        public class Handler : IRequestHandler<HaberlerQuery,List<Haberler>>
        {
            public async Task<List<Haberler>> Handle(HaberlerQuery request, CancellationToken cancellationToken)
            {// sorgu işlenir.
                var uow = new BlogUnitOfWork();
                var haberler = await uow.haberlerRepository.GetQuery() //veri tabanından haberler alınır.
                .ToListAsync(); // liste verir
                return haberler; //haberleri döndürür.
            }
        }
    }
}

