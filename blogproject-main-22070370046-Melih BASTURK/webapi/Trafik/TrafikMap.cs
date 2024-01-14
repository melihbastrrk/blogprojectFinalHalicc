using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using services.Query;

namespace webapi.Blog
{
    public class TrafikMap
    {
        public static void AddMap(WebApplication app) {
            app.MapGet("Trafik", (IMediator mediator) => {//Trafik durumu yolunu eşleştiren bir
             // HTTP GET isteği tanımlar.
                return mediator.Send(new TrafikQuery());//TrafikQuery sorgusunu gönderir,sonucu döndürür.
            });
        }
    }
}
