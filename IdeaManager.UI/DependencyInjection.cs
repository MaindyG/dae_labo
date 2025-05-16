using IdeaManager.UI.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace IdeaManager.UI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUIServices(this IServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddTransient<DashboardViewModel>();
            services.AddTransient<IdeaFormViewModel>();
            services.AddTransient<ProjectListViewModel>();
            return services;
        }
    }
}