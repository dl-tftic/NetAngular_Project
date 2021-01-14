using System;
using System.Collections.Generic;
using System.Text;
using DAO.Repository;
using BLL.Models;
using BLL.Mappers;
using BLL.Interface;
using dto = DTO.Models;
using System.Linq;

namespace BLL.Services
{
    public class ProjectCategoryService : IProjectCategoryService
    {
        private ProjectCategoryRepository _projectCategoryRepository = new ProjectCategoryRepository();

        private ICategoryService _categoryService;

        private IFilesService _filesService;

        private IProjectCategoryProductService _projectCategoryProductService;

        public ProjectCategoryService(  ICategoryService categoryService, 
                                        IFilesService filesService,
                                        IProjectCategoryProductService projectCategoryProductService)
        {
            this._categoryService = categoryService;

            this._filesService = filesService;

            this._projectCategoryProductService = projectCategoryProductService;
        }

        public List<ProjectCategory> Get(int projectId)
        {
            List<ProjectCategory> projectCategories = new List<ProjectCategory>();

            IEnumerable<dto.ProjectCategory> dto = _projectCategoryRepository.Get(projectId);

            foreach (dto.ProjectCategory item in dto)
            {
                ProjectCategory projectCategory = new ProjectCategory(_categoryService.Get(item.CategoryId));
                projectCategory.Id = item.Id;
                projectCategory.ParentCategoryTypeId = item.ParentProjectCategoryId;

                projectCategory.AddFiles(_filesService.GetByProjectCategory(projectCategory.Id));

                projectCategory.AddProjectCategoryProducts(_projectCategoryProductService.GetByProjectCategory(projectCategory.Id));

                if (projectCategory.ParentCategoryTypeId is null)
                {
                    projectCategories.Add(projectCategory);
                }
                else
                {
                    // IEnumerable<ProductCategory> props = productCategories.Where(x => x.Id == item.ParentCategoryProductId);
                    // AddSubCategories(props.ToList(), productCategory.ParentCategoryProductId);
                    // props.Single().AddChildProductCategory(productCategory);
                    AddSubCategories(projectCategories, projectCategory);
                }
            }

            return projectCategories;
        }

        public void AddSubCategories(List<ProjectCategory> projectCategories, ProjectCategory projectCategory)
        {
            foreach (ProjectCategory pc in projectCategories)
            {
                if (pc.HasChildren())
                {
                    AddSubCategories(pc.SubCategories, projectCategory);
                }
                else
                {
                    ProjectCategory child = projectCategories.Where(x => x.Id == projectCategory.ParentCategoryTypeId).SingleOrDefault();

                    if (child is null) { }
                    else
                    {
                        child.AddChildTypeCategory(projectCategory);
                        break;
                    }
                }
            }
        }
    }
}
