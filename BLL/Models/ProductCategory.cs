using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interface;

namespace BLL.Models
{
    public class ProductCategory : Category
    {
        #region constructor
        public ProductCategory()
        {
            // _categoryId = -1;
            SubCategories = new List<ProductCategory>();

            Files = new List<Files>();
        }

        public ProductCategory(int categoryId) : this()
        {
            this._categoryId = categoryId;
        }

        public ProductCategory(Category category) : this()
        {
            this._categoryId = category.Id;
            FromCategory(category);
        }
        #endregion

        private int _categoryId;

        public List<ProductCategory> SubCategories { get; set; }

        public List<Files> Files { get; set; }

        public int? ParentCategoryProductId { get; set; }

        public int GetCategoryId()
        {
            return _categoryId;
        }

        private void FromCategory(Category category)
        {
            // this.Id = 0;
            
            this.Name = category.Name;
            this.Description = category.Description;
            this.Type = category.Type;
            this.CreateBy = category.CreateBy;
            this.CreateDate = category.CreateDate;
        }

        public void AddChildProductCategory(ProductCategory productCategory)
        {
            if (productCategory is null) { }
            else this.SubCategories.Add(productCategory);
        }

        public void AddFile(Files file)
        {
            if (file is null) { }
            else this.Files.Add(file);
        }

        public void AddFiles(List<Files> files)
        {
            foreach (Files file in files)
            {
                this.AddFile(file);
            }
        }

        public bool HasChildren()
        {
            return SubCategories.Count > 0;
        }

        public bool HasFiles()
        {
            return Files.Count > 0;
        }
    }
}
