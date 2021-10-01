using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Moq;
using Microsoft.EntityFrameworkCore;
using CursoMVC.Models;
using Xunit;
using CursoAPI.Controllers;

namespace CursoTeste
{
    public class CategoriasControllerTest
    {
        // Testar o contexto, MAS não pode afetar banco PRODUÇÃO
        // então usa moq, que cria um objeto FAKE digamos
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Categoria _categoria;

        public CategoriasControllerTest()
        {
            // inicialização objetos mock
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContext = new Mock<Context>();
            _categoria = new Categoria
            {
                // {} inicializador de objeto ou collection
                Id = 1,
                Descricao = "Teste Categoria"
            };
            
            // define que Categorias de MockContext se refere a
            // Categorias de mockSet
            _mockContext.Setup(m => m.Categorias)
                .Returns(_mockSet.Object);

            // define que method FindAsync retorne a _categoria de
            // teste criada neste ambiente
            _mockContext.Setup(m => m.Categorias.FindAsync(1))
                .ReturnsAsync(_categoria);

            _mockContext.Setup(m => m.SetModified(_categoria));

            _mockContext.Setup(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()));

        }

        // TESTES

        // GET: api/Categorias/5
        [Fact]
        public async Task Get_Categoria()
        {

            // CategoriasController vem de CursoAPI.Controllers

            // Controller precisa de um Context então usa
            // _mockContext.Object Context fake 
            var service = new CategoriasController(_mockContext.Object);

            // com isso var service tem todo o conteudo do Controller Categorias
            // disponivel para uso
            await service.GetCategoria(1);

            // _mockSet executa FindAsync(1) da categoria 1
            // simulação do method GET com id 1 do controller categoria
            _mockSet.Verify(
                m => m.FindAsync(1),
                Times.Once()
            );

            // arrange
        }   

        [Fact]
        public async Task Put_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object);

            await service.PutCategoria(1, _categoria);

            _mockContext.Verify(
                m => m.SaveChangesAsync(It.IsAny<CancellationToken>()),
                Times.Once()
            );
        }

        [Fact]
        public async Task Post_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object);

            await service.PostCategoria(_categoria);

            _mockSet.Verify(
                x => x.Add(_categoria),
                Times.Once()
            );

            _mockContext.Verify(
                m => m.SaveChangesAsync(It.IsAny<CancellationToken>()),
                Times.Once()
            );
        }

        [Fact]
        public async Task Delete_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object);

            await service.DeleteCategoria(1);

            _mockSet.Verify(
                m => m.FindAsync(1),
                Times.Once()
            );

            _mockSet.Verify(
                x => x.Remove(_categoria),
                Times.Once()
            );

            _mockContext.Verify(
                m => m.SaveChangesAsync(It.IsAny<CancellationToken>()),
                Times.Once()
            );
        }

    }
}
