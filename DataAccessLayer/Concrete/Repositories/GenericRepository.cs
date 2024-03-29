﻿using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class         //Bütün bileşenlerin tamamını kapsıyor
    {
        Context c = new Context();
        DbSet<T> _object;       //_object T değerine gelen sınıfı tutuyor
        public GenericRepository()
        {
            _object = c.Set<T>();   //yukarıda tanımlanan _object in değerini contexte bağlı olarak gönderilen T değerini alacak
        }

        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter); //Bir dizi veya listede sadece 1 DEĞER DÖNDÜRMEK İÇİN SingleOrDefault kullanırız
        }                                           //Böylece GenericRepository den miras alan bütün sınıflarda da bu sınıf geçerli olacak.

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();      //Şaartlı listelemede filter den gelen değere göre bana listeleme yap
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
