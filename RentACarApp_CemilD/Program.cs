using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace RentACarApp_CemilD
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Giris());
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<ICarDal, EfCarDal>();
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<IBrandDal, EfBrandDal>();
            services.AddScoped<IRentDal, EfRentDal>();
            services.AddScoped<ICarService, CarManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IBrandService, BrandManager>();
            services.AddScoped<IRentService, RentManager>();

            services.AddScoped<Giris>();
            services.AddScoped<RentACar>();
        }
    }
}