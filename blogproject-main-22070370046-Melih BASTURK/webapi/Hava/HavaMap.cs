using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using services.Query;

namespace webapi.Blog
{
    public class HavaMap
    {
        public static void AddMap(WebApplication app) {
            app.MapGet("Hava durumu", (IMediator mediator) => {//Hava durumu yolunu eşleştiren bir
            // HTTP GET isteği tanımlar.
                return mediator.Send(new Hava_durumuQuery());//Hava_durumuQuery sorgusunu gönderir,sonucu döndürür.
            });
        }
    }
}