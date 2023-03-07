using AutoMapper;
using EntityFrameworkBLL.Configurations;
using EntityFrameworkBLL.Protos;
using EntityFrameworkBLL.Services.Abstract;
using EntityFrameworkBLL.Services.Concrete;
using EntityFrameworkDAL;
using EntityFrameworkDAL.Repositories.Abstract;
using EntityFrameworkDAL.Repositories.Concrete;
using EntityFrameworkDAL.UnitOfWork.Abstract;
using EntityFrameworkDAL.UnitOfWork.Concrete;

namespace EntityFrameworkAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;

        private IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<InventoryManagementDbContext>();

            services.AddGrpcClient<Products.ProductsClient>((_, options) =>
            {
                options.Address = new Uri(Configuration["urls:cleanArchService"] ?? string.Empty);
            });
            
            services.AddGrpcClient<Warehouses.WarehousesClient>((_, options) =>
            {
                options.Address = new Uri(Configuration["urls:adoDapperService"] ?? string.Empty);
            });
            
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<ISalesOrderRepository, SalesOrderRepository>();
            services.AddTransient<ISalesOrderProductRepository, SalesOrderProductRepository>();
            services.AddTransient<IShipInfoRepository, ShipInfoRepository>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<ISalesOrderService, SalesOrderService>();
            services.AddTransient<IShipInfoService, ShipInfoService>();
            services.AddTransient<IImageService, ImageService>();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddRazorPages();

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            
            app.UseCors(options => options
                .WithOrigins("http://localhost:3000")
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials());

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}