﻿using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string FlatId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NationalINumber { get; set; }
        public string PhoneNumber { get; set; }
        public Flat Flat { get; set; }
    }
}
