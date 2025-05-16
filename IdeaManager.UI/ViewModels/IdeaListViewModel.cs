using CommunityToolkit.Mvvm.ComponentModel;
using IdeaManager.Core.Entities;
using IdeaManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaManager.UI.ViewModels
{
    public partial class IdeaListViewModel :ObservableObject
    {
        private readonly IIdeaService _ideaService;

        [ObservableProperty]
        private ObservableCollection<Idea> _ideas;

        public IdeaListViewModel(IIdeaService ideaService)
        {
            _ideaService = ideaService;
            _ideas = new ObservableCollection<Idea>();
            LoadAsync();
        }

        public async Task LoadAsync()
        {
            var ideas = await _ideaService.GetAllAsync();
            if (ideas != null)
            {
                foreach (var idea in ideas)
                {
                    _ideas.Add(idea);
                }
            }
        }
    }
}
