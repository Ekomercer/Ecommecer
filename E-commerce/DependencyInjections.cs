using AutoMapper;
using E_Commerce.Data._1.Context;
using E_Commerce.Data._2.Repsitory;
using E_Commerce.Data._2.Repsitory.Interface.BaseInterface;
using Ecommece.Infrastucture;
using Microsoft.EntityFrameworkCore;

namespace E_commerce
{
    public class DependencyInjections 
    {
        public static void AddEcommerce(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();

            services.AddSingleton(mapper);


        }
    }
}
