using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HoangDucManh253.Models;

namespace HoangDucManh253.Data
{
    public class HoangDucManh253Context : DbContext
    {
        public HoangDucManh253Context (DbContextOptions<HoangDucManh253Context> options)
            : base(options)
        {
        }

        public DbSet<HoangDucManh253.Models.PersonHDM253> PersonHDM253 { get; set; }
    }
}
