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
	}
}
