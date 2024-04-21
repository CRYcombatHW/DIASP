namespace DIASP
{
	public class Startup
	{
		private readonly IConfiguration _configuration;

		public Startup(IConfiguration configuration) {
			_configuration = configuration;
		}

		public void OldConfigureService() {
			UserService service = new UserService();
		}

		public void ConfigureService(IServiceCollection services) {
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddTransient<UserService>();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
			var builder = WebApplication.CreateBuilder();

			// Add services to the container.
			builder.Services.AddRazorPages();

			if (!env.IsDevelopment()) {
				app.UseExceptionHandler("/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			((WebApplication)app).MapRazorPages();
		}
	}
}
