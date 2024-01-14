using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using services.Query;

namespace webapi.Blog
{
    public class SozlukMap
    {
        public static void AddMap(WebApplication app) {
            app.MapGet("sözlük", (IMediator mediator) => {//sözlük yolunu eşleştiren bir
            // HTTP GET isteği tanımlar.
                return mediator.Send(new SozlukQuery());//SozlukQuery sorgusunu gönderir,sonucu döndürür.
            });
        }
    }
}

