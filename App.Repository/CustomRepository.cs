using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entity;
using App.IRepository;

namespace App.Repository
{
    public partial class CustomRepository : BaseRepository<CustomModel>, ICustomRepository
    {
    }
}
