using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IdeaManager.UI.Views;
using System.Windows.Controls;

namespace IdeaManager.UI.ViewModels
{
    public partial class MainViewModel :ObservableObject
    {
        [ObservableProperty]
        private UserControl currentView;

        private IdeaFormView IdeaFormView { get; }
        private IdeaListView IdeaListView { get; }

        public MainViewModel(IdeaFormView ideaFormView, IdeaListView ideaListView)
        {
            currentView = ideaFormView; 
            IdeaFormView = ideaFormView;
            IdeaListView = ideaListView;
        }

        [RelayCommand]
        private void ShowIdeaFormCommand() => CurrentView = IdeaFormView;

        //[RelayCommand]
        //private void ShowIdeaList() => CurrentView = IdeaListView;
    }
}