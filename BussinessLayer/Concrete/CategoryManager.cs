using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;      //türü ICategoryDal dan gelen, _categoryDal adında bir field ım var.

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(x => x.CategoryID==id);
        }

        //GenericRepository<Category> repo = new GenericRepository<Category>(); //repo isminde nesne türettik

        //public List<Category> GetAllBL()
        //{
        //    return repo.List();     //Listeleme yapmak için kullandık
        //}
        //public void CategoryAddBL(Category p)
        //{

        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3|| p.CategoryDescription == "" || p.CategoryName.Length >= 51)
        //    {

        //        //hata message

        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        //public void CategoryAddBL(Category p)
        //{
        //    if(p.CategoryName==""||p.CategoryStatus==false||p.CategoryName.Length<=3)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        _categoryDal.Insert(p);
        //    }
        //}


    }
}
