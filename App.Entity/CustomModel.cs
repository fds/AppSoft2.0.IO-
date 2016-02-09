using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entity
{
    [Serializable]
    public class CustomModel
    {
        public int CustomID { get; set; }

        public string CustomName { get; set; }
    }
}
