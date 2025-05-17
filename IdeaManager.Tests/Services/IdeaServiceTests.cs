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
        public async Task RefusIdee()
        {

            var idea = new Idea { Title = "", Description = "ghfghddj" };
            var exempleErreur = await Assert.ThrowsAsync<ArgumentException>(() => _service.SubmitIdeaAsync(idea));
        }


        [Fact]
        public async Task NewIdea()
        {

            var idea = new Idea { Title = "Voyage", Description = "ghfghddj" };
            await _service.SubmitIdeaAsync(idea);
            Assert.Contains("Voyage", idea.Title);
        }
    }
}
