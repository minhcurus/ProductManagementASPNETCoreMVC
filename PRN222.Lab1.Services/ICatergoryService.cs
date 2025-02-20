using PRN222.Lab1.Repositories.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN222.Lab1.Services
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
