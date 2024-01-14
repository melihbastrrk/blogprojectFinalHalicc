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
    public class Hava_durumuQuery: IRequest<List<Hava>> //Hava türündeki veriyi liste olarak döndür
    {

        public class Handler : IRequestHandler<Hava_durumuQuery,List<Hava>>
        {
            public async Task<List<Hava>> Handle(Hava_durumuQuery request, CancellationToken cancellationToken)
            {// sorgu işlenir.
                var uow = new BlogUnitOfWork();
                var h_Durumu = await uow.h_DurumuRepository.GetQuery()//veri tabanından h_Durumu alınır.
                .ToListAsync();// liste verir
                return h_Durumu;//h_Durumu döndürür.
            }
        }
    }
}

