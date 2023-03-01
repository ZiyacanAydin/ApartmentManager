using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Flat : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsFull { get; set; }
        public char Block { get; set; }
        public string FlatNo { get; set; }
        public string FloorNo { get; set; }
        public User User { get; set; } 
    }
}
