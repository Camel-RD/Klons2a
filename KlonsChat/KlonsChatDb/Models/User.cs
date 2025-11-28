using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsChatDb.Models
{
    public  class User
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
