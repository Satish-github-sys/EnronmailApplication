using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using SearchAPI.Domain.Common;
using SearchAPI.Domain.Settings;
using SearchAPI.Persistence;
using SearchAPI.Service.Contract;
using SearchAPI.Service.Implementation;
using System;
using System.Reflection;
using System.Text;

namespace EnronMailApplication.Configurations
{
    public static class DependencyInjection
    {
        public static void AddServiceLayer(this IServiceCollection services)
        {
            // or you can use assembly in Extension method in Infra layer with below command
            services.AddMediatR(Assembly.GetExecutingAssembly());
            
        }

        
    }
}

