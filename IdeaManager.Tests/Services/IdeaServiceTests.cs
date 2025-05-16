using IdeaManager.Core.Entities;
using IdeaManager.Core.Interfaces;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace IdeaManager.Tests.Services
{
    public class IdeaServiceTests
    {
        private readonly Mock<IRepository<Idea>> _mockIdeaRepository;
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly IdeaService _service;

        public IdeaServiceTests()
        {
            _mockIdeaRepository = new Mock<IRepository<Idea>>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockUnitOfWork.Setup(i => i.IdeaRepository).Returns(_mockIdeaRepository.Object);
            _service = new IdeaService(_mockUnitOfWork.Object);
        }

      

        [Fact]
        public async Task RefusIdeeSansTitre_ThrowsArgumentException()
        {

            var idea = new Idea { Title = "", Description = "ghfghddj" };
            var exempleErreur = await Assert.ThrowsAsync<ArgumentException>(() => _service.SubmitIdeaAsync(idea));
        }
    }
}
