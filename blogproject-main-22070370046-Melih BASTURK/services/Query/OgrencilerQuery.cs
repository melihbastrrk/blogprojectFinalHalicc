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
    public class OgrencilerQuery: IRequest<List<Ogrenci>>//Ogrenci türündeki veriyi liste olarak döndür
    {

        public class Handler : IRequestHandler<OgrencilerQuery,List<Ogrenci>>
        {
            public async Task<List<Ogrenci>> Handle(OgrencilerQuery request, CancellationToken cancellationToken)
            {// sorgu işlenir.
                var uow = new BlogUnitOfWork();
                var Ogrenciler = await uow.OgrencilerRepository.GetQuery()//veri tabanından Ogrenciler alınır.
                .ToListAsync();// liste verir
                return Ogrenciler;//Ogrenciler döndürür.
            }
        }
    }
}



