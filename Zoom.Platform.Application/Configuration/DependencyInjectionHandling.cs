using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Zoom.Platform.Infrastructure.AppContext;

namespace Zoom.Platform.Application.Configuration
{
    public static class DependencyInjectionHandling
    {
        public static void Handle(IServiceCollection services)
        {
            services.AddDbContext<ZoomPlatformDBContext>(options =>
            {
                options.UseSqlServer("Data Source=. ;Initial Catalog=ZoomPlatformDb;Persist Security Info=True;User ID=sa;Password=osamahamdy;MultipleActiveResultSets=True;Connect Timeout=30;");
            });

            // Repository


            //Services
        }
    }
}
