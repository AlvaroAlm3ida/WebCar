using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebCar.Data;
using WebCar.Models;
using WebCar.Repositorio;

namespace WebCar
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //Faz a conexão com o SQL SERVER

            services.AddControllersWithViews();
            services.AddEntityFrameworkSqlServer()
           .AddDbContext<BancoContext>(o => o.UseSqlServer(Configuration.GetConnectionString("Database")));
            services.AddScoped<ICadastroRepositorio, CadastroRepositorio>();

            // Configuração do VendasContext            
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<CarroContext>(o => o.UseSqlServer(Configuration.GetConnectionString("VendasDatabase")));
            //Injeção de dependência para os repositórios
            services.AddScoped<IVendasRepositorio, VendasRepositorio>();
        }
       

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=WbMotors}/{action=Index}/{id?}");
            });
        }
    }
}