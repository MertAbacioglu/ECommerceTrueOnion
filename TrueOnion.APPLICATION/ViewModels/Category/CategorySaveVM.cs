﻿
using System.ComponentModel;
using TrueOnion.APPLICATION.ViewModels.Abstracts;

namespace TrueOnion.APPLICATION.ViewModels.Category
{
    public class CategorySaveVM : SaveVM
    {
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
        [DisplayName("Parent Category")]
        public int ParentID { get; set; }
        public List<CategoryVM> CategoryVMs { get; set; }

    }
}