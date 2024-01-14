using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.repositories;
using data.tables;
namespace data.uows
{
    public class BlogUnitOfWork
    {
        private BlogContext _context;

        public BlogUnitOfWork() {
            _context = new BlogContext();
        }
        private Repository<Blog> _blogRepository;
        private Repository<Post> _postRepository;
        private Repository<Krediler> _kredilerRepository;
        private Repositsory<Ogrenci> _OgrencilerRepository;
         private Repository<Okul> _okul_listeRepository;
         private Repository<sehirler> _SehirRepository;
         private Repository<sozluk> _SozlukRepository;
         private Repository<Haberler> _haberlerRepository;
         private Repository<Hava> _h_DurumuRepository;
         private Repository<Trafik> _trafikRepository;




        public Repository<Krediler> kredilerRepository {
            get {
                if (_kredilerRepository == null) {
                    _kredilerRepository = new Repository<Krediler>(_context);
                }
                return _kredilerRepository;
            }
        }
        public Repository<Blog> blogRepository {
            get {
                if (_blogRepository == null) {
                    _blogRepository = new Repository<Blog>(_context);
                }
                return _blogRepository;
            }
        }
        public Repository<Post> postRepository {
            get {
                if (_postRepository == null) {
                    _postRepository = new Repository<Post>(_context);
                }
                return _postRepository;
            }
        }

         public Repository<Okul> okul_listeRepository {
            get {
                if (_okul_listeRepository == null) {
                    _okul_listeRepository = new Repository<Okul>(_context);//yeni bir Repository örneğini atar
                }
                return _okul_listeRepository;//_okul_listeRepository döndürür
            }
        }

         public Repository<Ogrenci> OgrencilerRepository {
            get {
                if (_OgrencilerRepository == null) {
                    _OgrencilerRepository = new Repository<Ogrenci>(_context);//yeni bir Repository örneğini atar
                }
                return _OgrencilerRepository; //_OgrencilerRepository döndürür
            }
        }

         public Repository<sehirler> SehirRepository {
            get {
                if (_SehirRepository == null) {
                    _SehirRepository = new Repository<sehirler>(_context);//yeni bir Repository örneğini atar
                }
                return _SehirRepository; //_SehirRepository döndürür
            }
        }

             public Repository<sozluk> SozlukRepository {
            get {
                if (_SozlukRepository == null) {
                    _SozlukRepository = new Repository<sozluk>(_context);//yeni bir Repository örneğini atar
                }
                return _SozlukRepository;//_SozlukRepository döndürür
            }
        }
              public Repository<Haberler> haberlerRepository {
            get {
                if (_haberlerRepository == null) {
                    _haberlerRepository = new Repository<Haberler>(_context); //yeni bir Repository örneğini atar
                }
                return _haberlerRepository; // _haberlerRepository döndürür
            }
        }

              public Repository<Hava> h_DurumuRepository {
            get {
                if (_h_DurumuRepository == null) {
                    _h_DurumuRepository = new Repository<Hava>(_context);//yeni bir Repository örneğini atar
                }
                return _h_DurumuRepository; // _h_DurumuRepository döndürür
            }
        }

              public Repository<Trafik> trafikRepository {
            get {
                if (_trafikRepository == null) {
                    _trafikRepository = new Repository<Trafik>(_context);//yeni bir Repository örneğini atar
                }
                return _trafikRepository;//_trafikRepository döndürür
            }
        }





    }
}