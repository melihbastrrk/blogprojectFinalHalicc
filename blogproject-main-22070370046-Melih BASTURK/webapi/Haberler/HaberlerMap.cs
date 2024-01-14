using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using services.Query;

namespace webapi.Blog
{
    public class HaberlerMap
    {
        public static void AddMap(WebApplication app) {
            app.MapGet("Haberler", (IMediator mediator) => {//Haberler yolunu eşleştiren bir
            // HTTP GET isteği tanımlar.
                return mediator.Send(new HaberlerQuery()); //HaberlerQuery sorgusunu gönderir ve sonucu döndürür.
            });
        }
    }
}

