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
    public class SozlukQuery: IRequest<List<sozluk>>//sozluk türündeki veriyi liste olarak döndür
    {

        public class Handler : IRequestHandler<SozlukQuery,List<sozluk>>
        {
            public async Task<List<sozluk>> Handle(SozlukQuery request, CancellationToken cancellationToken)
            {// sorgu işlenir.
                var uow = new BlogUnitOfWork();
                var Sozluk = await uow.SozlukRepository.GetQuery()//veri tabanından Sozluk alınır.
                .ToListAsync();// liste verir
                return Sozluk;//Sozluk döndürür.
            }
        }
    }
}

