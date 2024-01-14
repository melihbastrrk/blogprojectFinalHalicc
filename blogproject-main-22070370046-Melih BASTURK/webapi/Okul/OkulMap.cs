using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using services.Query;

namespace webapi.Blog
{
    public class OkulMap
    {
        public static void AddMap(WebApplication app) {
            app.MapGet("okul", (IMediator mediator) => {//okul yolunu eşleştiren bir
            // HTTP GET isteği tanımlar.
                return mediator.Send(new OkulQuery());//OkulQuery sorgusunu gönderir,sonucu döndürür.
            });
        }
    }
}
