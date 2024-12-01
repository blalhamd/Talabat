﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;
using Talabat.Core.Abstractions;

namespace Talabat.DependencyInjection
{
    public static class Container
    {
        public static IServiceCollection Register(this IServiceCollection services, IConfiguration configuration)
        {

            // Register AppDbContext 

            services.RegisterConnectionString(configuration);

            // Register Redis

            services.RegisterRedisConfig(configuration);

            // register Identity

            services.RegisterIdentityConnectionString(configuration);


            // Register IUnit Of work 

            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));

            services.AddScoped(typeof(IBasketRepository), typeof(BasketRepository));

            //Register Services

            services.RegisterServices();

            // Register AutoMappper

            services.AddAutoMapper(typeof(Mapping));

            // Register RateLimiting

            services.RegisterConcurrencyRateLimitingConfig();

            services.RegisterOptionsPatternConfig(configuration);

            return services;
        }

        private static IServiceCollection RegisterConnectionString(this IServiceCollection services, IConfiguration configuration)
        {

            var connection = configuration["ConnectionStrings:DefaultConnectionString"];
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connection));
            services.AddScoped<AppDbContext, AppDbContext>();

            return services;
        }


        private static IServiceCollection RegisterRedisConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IConnectionMultiplexer>(options =>
            {
                var connection = configuration["ConnectionStrings:RedisConnectionString"];

                return ConnectionMultiplexer.Connect(connection!);
            });

            return services;
        }

        private static IServiceCollection RegisterIdentityConnectionString(this IServiceCollection services, IConfiguration configuration)
        {

            var connection = configuration["ConnectionStrings:IdentityConnectionString"];
            services.AddDbContext<AppIdentityDbContext>(x => x.UseSqlServer(connection));
            services.AddScoped<AppIdentityDbContext, AppIdentityDbContext>();

            return services;
        }

        private static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IProductService), typeof(ProductService));
            services.AddScoped(typeof(IBrandService), typeof(BrandService));
            services.AddScoped(typeof(IProductTypeService), typeof(ProductTypeService));
            services.AddScoped(typeof(IBasketService), typeof(BasketService));
            services.AddScoped(typeof(IJwtProvider), typeof(JwtProvider));
            services.AddScoped(typeof(IAuthenticationService), typeof(AuthenticationService));
            services.AddScoped(typeof(IOrderService), typeof(OrderService));
            services.AddScoped(typeof(IPayementService), typeof(PayementService));
            services.AddScoped(typeof(ICacheService), typeof(CacheService));
            services.AddScoped(typeof(IRoleService), typeof(RoleService));
            services.AddScoped(typeof(IUserService), typeof(UserService));
            services.AddScoped(typeof(IEmailSender), typeof(EmailSender));
            services.AddScoped(typeof(IEmailBodyBuilder), typeof(EmailBodyBuilder));


            return services;
        }

        private static IServiceCollection RegisterOptionsPatternConfig(this IServiceCollection services,IConfiguration configuration)
        {
            services.Configure<MailSettings>(configuration.GetSection("MailSettings"));

            return services;
        }

		private static IServiceCollection RegisterConcurrencyRateLimitingConfig(this IServiceCollection services)
		{
			services.AddRateLimiter(RateLimiterOptions =>
			{
				RateLimiterOptions.RejectionStatusCode = StatusCodes.Status429TooManyRequests;

				RateLimiterOptions.AddConcurrencyLimiter(RateLimiterType.Concurrency, ConcurrencyLimiterOptions =>
				{
					ConcurrencyLimiterOptions.PermitLimit = 1000;
					ConcurrencyLimiterOptions.QueueLimit = 100; // will go to waiting list..
					ConcurrencyLimiterOptions.QueueProcessingOrder = QueueProcessingOrder.OldestFirst; // will exist empty place to accept request, will move oldest waited request from Queue to execute..
				});
			});

			return services;
		}

	}
    
}
