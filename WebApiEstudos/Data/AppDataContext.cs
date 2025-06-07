using Microsoft.EntityFrameworkCore;
using WebApiEstudos.Models;

namespace WebApiEstudos.Data

{
    public class AppDataContext : DbContext
    {
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }
    public DbSet<Produto> Produtos { get; set; } // Tabela de Produtos
    }
    
}
