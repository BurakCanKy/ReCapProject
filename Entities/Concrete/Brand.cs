using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand:IEntity
    {
        public int brandID { get; set; }
        public string brandName { get; set; }
    }
}
