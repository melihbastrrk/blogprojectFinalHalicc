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
    public class OkulQuery: IRequest<List<Okul>>//Okul türündeki veriyi liste olarak döndür
    {

        public class Handler : IRequestHandler<okulQuery,List<Okul>>
        {
            public async Task<List<Okul>> Handle(OkulQuery request, CancellationToken cancellationToken)
            {// sorgu işlenir.
                var uow = new BlogUnitOfWork();
                var okul_liste = await uow.okul_listeRepository.GetQuery()//veri tabanından okul_liste alınır.
                .ToListAsync();// liste verir
                return okul_liste;//okul_liste döndürür.
            }
        }
    }
}

