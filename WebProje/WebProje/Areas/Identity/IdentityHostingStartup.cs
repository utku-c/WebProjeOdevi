using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebProje.Data;

[assembly: HostingStartup(typeof(WebProje.Areas.Identity.IdentityHostingStartup))]
namespace WebProje.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebProjeContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WebProjeContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    
                    

                })
                    .AddEntityFrameworkStores<WebProjeContext>();
            });
        }
    }
}