﻿using DIASP.Abstract;
using DIASP.Services;

namespace DIASP
{
	public class Startup
	{
		private readonly IConfiguration _configuration;

		public Startup(IConfiguration configuration) {
			_configuration = configuration;
		}

		public void OldConfigureService() {
			PersonService service = new PersonService();
		}

		public void ConfigureService(IServiceCollection services) {
			services.AddScoped<IPersonOutputService, PersonOutputService>();

			services.AddRazorPages();
		}
	}
}
