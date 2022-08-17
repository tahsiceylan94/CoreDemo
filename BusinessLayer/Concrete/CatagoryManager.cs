﻿using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CatagoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;

        public CatagoryManager(){
            efCategoryRepository = new EfCategoryRepository();
        }

        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }

        public List<Category> GetAllCategories()
        {
            return efCategoryRepository.GetListAll();
        }

        public Category GetCategoryById(int id)
        {
            return efCategoryRepository.GetById(id);
        }
    }
}
