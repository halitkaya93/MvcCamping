using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>(); //repo isminde nesne türettik

        public List<Category> GetAll()
        {
            return repo.List();     //Listeleme yapmak için kullandık
        }
        public void CategoryAddBL(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length <= 3
                || p.CategoryName.Length >= 51)
            {

                //hata message
            }
            else
            {
                repo.Insert(p);

            }
        }

    }
}
