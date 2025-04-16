using Microsoft.Extensions.DependencyInjection;
using Onion.Application.Features.CQRS.Handlers;

namespace Onion.Application.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddApplicationExt(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ServiceRegistration).Assembly);


            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly);
            });


            services.AddScoped<GetCategoryQueryHandler>();
            services.AddScoped<GetCategoryByIdQueryHandler>();
            services.AddScoped<CreateCategoryCommandHandler>();
            services.AddScoped<UpdateCategoryCommandHandler>();
            services.AddScoped<RemoveCategoryCommandHandler>();
        }
    }
}
