using IdeaManager.Core.Interfaces;
using IdeaManager.Data.Repositories;
using IdeaManager.UI.ViewModels;
using IdeaManager.UI.Views;
using Microsoft.Extensions.DependencyInjection;

namespace IdeaManager.UI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUIServices(this IServiceCollection services)
        {

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IIdeaService, IdeaService>();

            services.AddSingleton<MainWindow>();
            services.AddTransient<IdeaListViewModel>();
            services.AddSingleton<MainViewModel>();
            services.AddTransient<IdeaFormViewModel>();

            services.AddTransient<IdeaFormView>();
            services.AddTransient<IdeaListView>();
            return services;
        }
    }
}