using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using services.Query;

namespace webapi.Blog
{
    public class SehirlerMap
    {
        public static void AddMap(WebApplication app) {
            app.MapGet("sehir", (IMediator mediator) => {//sehir yolunu eşleştiren bir
               // HTTP GET isteği tanımlar.
                return mediator.Send(new SehirlerQuery());//SehirlerQuery sorgusunu gönderir,sonucu döndürür.
            });
        }
    }
}
