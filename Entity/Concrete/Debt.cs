using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Debt : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FlatId { get; set; }
        public DateTime DateTime { get; set; }
        public int Cost { get; set; }
        public bool IsPaid { get; set; }
        public User User { get; set; }
        public Flat Flat { get; set; }
    }
}
