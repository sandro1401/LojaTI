using LojaTI.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LojaTI.Models;

namespace LojaTI.Data;

public class LojaTIContext : IdentityDbContext<UsuarioModel>
{
    public LojaTIContext(DbContextOptions<LojaTIContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<LojaTI.Models.Cliente> Cliente { get; set; } = default!;

public DbSet<LojaTI.Models.Produto> Produto { get; set; } = default!;

public DbSet<LojaTI.Models.Pedido> Pedido { get; set; } = default!;

public DbSet<LojaTI.Models.ItemPedido> ItemPedido { get; set; } = default!;

public DbSet<LojaTI.Models.NotaFiscal> NotaFiscal { get; set; } = default!;
}
