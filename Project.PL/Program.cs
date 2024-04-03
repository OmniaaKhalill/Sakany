using Microsoft.EntityFrameworkCore;
using Project.BLL.Interfaces;
using Project.BLL.Repositories;
using Project.DAL.Context;


namespace Project.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            #region Connection To DB
            builder.Services.AddDbContext<ProjDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn"));
            });


            #endregion



            builder.Services.AddScoped<IApartmentRepo, ApartmentRepo>();
            builder.Services.AddScoped<IBuildingRepo, BuildingRepo>();
            builder.Services.AddScoped<IFloorRepo, FloorRepo>();
            builder.Services.AddScoped<IManagerRepo, Manager>();
            builder.Services.AddScoped<IRenterRepo, RenterRepo>();
            builder.Services.AddScoped<IRenterServiceRepo, RenterServiceRepo>();
            builder.Services.AddScoped<IRoomRepo, RoomRepo>();
            builder.Services.AddScoped<IServiceRepo, ServiceRepo>();

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=home}/{action=index}/{id?}");

            app.Run();
        }
    }
}
