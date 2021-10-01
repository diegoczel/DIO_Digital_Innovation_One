using System;
using Microsoft.EntityFrameworkCore;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        // quando precisar acessar, basta referenciar class Context

        // diz que a classe X irá virar tabela no banco
        public virtual DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        // define qual banco usar
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // responsavel por configurar o EntityFramework
            // define qual banco usar
            optionsBuilder.UseSqlServer(
                @"Server=localhost\SQLEXPRESS;Database=Cursomvc;Trusted_Connection=True");
        }

        // seta o estado da entidade para modificado
        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
