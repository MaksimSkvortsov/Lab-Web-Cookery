using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookery.Domain.Entities
{
    public class Product
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public Boolean ShowInList { get; set; }
    }
}