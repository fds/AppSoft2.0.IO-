using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entity;
using App.IServices;
using App.IRepository;

namespace App.Services
{
    public partial class CustomServices : BaseServices<CustomModel>, ICustomServices
    {
        ICustomRepository _ICustomRepository;
        public CustomServices(ICustomRepository __ICustomRepository)
        {
            this._ICustomRepository = __ICustomRepository;
            base._IBaseRepository = __ICustomRepository;
        }
    }
}
