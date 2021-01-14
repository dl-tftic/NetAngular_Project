using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class CategoryAbstract<T> : Category
    {
        #region constructor
        public CategoryAbstract()
        {
            SubCategories = new List<T>();

            Files = new List<Files>();
        }

        public CategoryAbstract(Category category) : this()
        {
            this._categoryId = category.Id;
            FromCategory(category);
        }
        #endregion

        #region properties
        private int _categoryId;
        public List<T> SubCategories { get; set; }

        public List<Files> Files { get; set; }

        public int? ParentCategoryTypeId { get; set; }
        #endregion

        #region function
        public int GetCategoryId()
        {
            return _categoryId;
        }

        private void FromCategory(Category category)
        {
            this.Name = category.Name;
            this.Description = category.Description;
            this.Type = category.Type;
            this.CreateBy = category.CreateBy;
            this.CreateDate = category.CreateDate;
        }

        public void AddChildTypeCategory(T typeCategory)
        {
            if (typeCategory is null) { }
            else this.SubCategories.Add(typeCategory);
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
        #endregion
    }
}
