using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BlazorWASM_1ero.Shared.Models;

namespace BlazorWASM_1ero.Server.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Aportes> Aportes { get; set; }
    }
}
