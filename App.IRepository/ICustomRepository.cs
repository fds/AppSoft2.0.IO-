using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entity;

namespace App.IRepository
{
    public partial interface ICustomRepository : IBaseRepository<CustomModel>
    {
    }
}
