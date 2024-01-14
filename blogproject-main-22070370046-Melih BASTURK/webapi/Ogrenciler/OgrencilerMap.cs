using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using services.Query;

namespace webapi.Blog
{
    public class OgrencilerMap
    {
        public static void AddMap(WebApplication app) {
            app.MapGet("Öğrenciler", (IMediator mediator) => {//Öğrenciler yolunu eşleştiren bir
            // HTTP GET isteği tanımlar.
                return mediator.Send(new OgrencilerQuery());//OgrencilerQuery sorgusunu gönderir,sonucu döndürür.
            });
        }
    }
}
