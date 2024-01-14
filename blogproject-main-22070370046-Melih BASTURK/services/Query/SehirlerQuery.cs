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
    public class SehirlerQuery: IRequest<List<sehirler>>//sehirler türündeki veriyi liste olarak döndür
    {

        public class Handler : IRequestHandler<OgrencilerQuery,List<sehirler>>
        {
            public async Task<List<sehirler>> Handle(SehirlerQuery request, CancellationToken cancellationToken)
            {// sorgu işlenir.
                var uow = new BlogUnitOfWork();
                var Sehir = await uow.SehirRepository.GetQuery()//veri tabanından Sehir alınır.
                .ToListAsync();// liste verir
                return Sehir;//Sehir döndürür.
            }
        }
    }
}
