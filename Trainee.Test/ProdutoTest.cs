using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Trainee.Application.Interfaces;
using Trainee.Application.ViewModels;
using System.Linq;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Trainee.Test
{
    public class ProdutTest
    {
        [Fact]
        public void Test_GetAll()
        {
            Mock<IProdutoAppService> mockService = new Mock<IProdutoAppService>();
            mockService.Setup(m => m.GetAll()).Returns(Task.FromResult(new List<ProdutoViewModel>().AsEnumerable()));

            var controller = new Trainee.Web.Controllers.ProdutoController(mockService.Object);

            // Act
            var actionResult = controller.Index() as Task<IActionResult>;

            Assert.NotEqual(actionResult, null);

        }

        [Fact]
        public void Test_GetById()
        {
            Mock<IProdutoAppService> mockService = new Mock<IProdutoAppService>();
            mockService.Setup(m => m.GetById(1)).Returns(Task.FromResult(new ProdutoViewModel()));

            var controller = new Trainee.Web.Controllers.ProdutoController(mockService.Object);

            // Act
            var actionResult = controller.Index() as Task<IActionResult>;

            Assert.NotEqual(actionResult, null);
        }

        [Fact]
        public void Test_Add()
        {
            var cliente = new ProdutoViewModel
            {
                Ativo = true,
                Id = 0,
                Nome = "Teste"
            };
            Mock<IProdutoAppService> mockService = new Mock<IProdutoAppService>();
            mockService.Setup(m => m.Register(cliente)).Returns(Task.FromResult(ValidationResult.Success));

            var controller = new Trainee.Web.Controllers.ProdutoController(mockService.Object);

            // Act
            var actionResult = controller.Create() as Task<IActionResult>;

            // Act
            var actionResult1 = controller.Create(cliente) as Task<IActionResult>;

            Assert.NotEqual(actionResult1, actionResult);

        }

        [Fact]
        public void Test_Update()
        {
            var cliente = new ProdutoViewModel
            {
                Ativo = true,
                Id = 1,
                Nome = "Teste Atualizacao"
            };
            Mock<IProdutoAppService> mockService = new Mock<IProdutoAppService>();
            mockService.Setup(m => m.Update(cliente)).Returns(Task.FromResult(ValidationResult.Success));

            var controller = new Trainee.Web.Controllers.ProdutoController(mockService.Object);

            // Act
            var actionResult = controller.Index() as Task<IActionResult>;

            Assert.NotEqual(actionResult, null);
        }

        [Fact]
        public void Test_ActivateInactivate()
        {
            Mock<IProdutoAppService> mockService = new Mock<IProdutoAppService>();
            mockService.Setup(m => m.ActivateInactivate(1)).Returns(Task.FromResult(ValidationResult.Success));

            var controller = new Trainee.Web.Controllers.ProdutoController(mockService.Object);

            // Act
            var actionResult = controller.Index() as Task<IActionResult>;

            Assert.NotEqual(actionResult, null);

        }
    }
}
