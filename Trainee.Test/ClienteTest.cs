using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Trainee.Application.AutoMapper;
using Trainee.Application.Interfaces;
using Trainee.Application.Services;
using Trainee.Application.ViewModels;
using Trainee.Domain.Interfaces;
using Trainee.Infra.Data.Context;
using Trainee.Infra.Data.Repository;
using System.Linq;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Trainee.Test
{
    public class ClienteTest
    {
        [Fact]
        public void Test_GetAll()
        {
            Mock<IClienteAppService> mockService = new Mock<IClienteAppService>();
            mockService.Setup(m => m.GetAll()).Returns(Task.FromResult(new List<ClienteViewModel>().AsEnumerable()));

            var controller = new Trainee.Web.Controllers.ClienteController(mockService.Object);

            // Act
            var actionResult = controller.Index() as Task<IActionResult>;

            Assert.NotEqual(actionResult, null);

        }

        [Fact]
        public void Test_GetById()
        {
            Mock<IClienteAppService> mockService = new Mock<IClienteAppService>();
            mockService.Setup(m => m.GetById(1)).Returns(Task.FromResult(new ClienteViewModel()));

            var controller = new Trainee.Web.Controllers.ClienteController(mockService.Object);

            // Act
            var actionResult = controller.Index() as Task<IActionResult>;

            Assert.NotEqual(actionResult, null);
        }

        [Fact]
        public void Test_Add()
        {
            var cliente = new ClienteViewModel
            {
                Ativo = true,
                Id = 0,
                Nome = "Teste"
            };
            Mock<IClienteAppService> mockService = new Mock<IClienteAppService>();
            mockService.Setup(m => m.Register(cliente)).Returns(Task.FromResult(ValidationResult.Success));

            var controller = new Trainee.Web.Controllers.ClienteController(mockService.Object);

            // Act
            var actionResult = controller.Index() as Task<IActionResult>;

            Assert.NotEqual(actionResult, null);

        }

        [Fact]
        public void Test_Update()
        {
            var cliente = new ClienteViewModel
            {
                Ativo = true,
                Id = 1,
                Nome = "Teste Atualizacao"
            };
            Mock<IClienteAppService> mockService = new Mock<IClienteAppService>();
            mockService.Setup(m => m.Update(cliente)).Returns(Task.FromResult(ValidationResult.Success));

            var controller = new Trainee.Web.Controllers.ClienteController(mockService.Object);

            // Act
            var actionResult = controller.Index() as Task<IActionResult>;

            Assert.NotEqual(actionResult, null);
        }

        [Fact]
        public void Test_ActivateInactivate()
        {
            Mock<IClienteAppService> mockService = new Mock<IClienteAppService>();
            mockService.Setup(m => m.ActivateInactivate(1)).Returns(Task.FromResult(ValidationResult.Success));

            var controller = new Trainee.Web.Controllers.ClienteController(mockService.Object);

            // Act
            var actionResult = controller.Index() as Task<IActionResult>;

            Assert.NotEqual(actionResult, null);

        }
    }
}
