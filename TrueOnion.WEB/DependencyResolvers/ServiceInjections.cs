﻿using FluentValidation.AspNetCore;
using TrueOnion.APPLICATION.Validators;
using TrueOnion.WEB.Filters;

namespace TrueOnion.WEB.DependencyResolvers
{
    public static class ServiceInjections
    {
        public static void AddWebLayerInjections(this IServiceCollection services)
        {
            services.AddControllersWithViews()
                    .AddRazorRuntimeCompilation()
                    .AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<ProductSaveVMValidator>());

            services.AddScoped(typeof(NotFoundFilter<,,>));

        }
    }
}
