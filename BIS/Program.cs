using BIS.BLL.Functions;
using BIS.BLL.General;
using BIS.Data.Contexts;
using BIS.UI.Forms.UserForms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows.Forms;

namespace BIS.UI
{
    internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{

			var configuration = new ConfigurationBuilder()
		.SetBasePath(Directory.GetCurrentDirectory())
		.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
		.Build();

			var services = new ServiceCollection();

			ConfigureServices(services, configuration);

			var serviceProvider = services.BuildServiceProvider();

            GeneralFunctions.Initialize(configuration);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

			Application.Run(serviceProvider.GetRequiredService<LoginForm>());
		}

		private static void ConfigureServices(ServiceCollection services, IConfiguration configuration)
		{
			var connectionString = configuration.GetConnectionString("DefaultConnection");

			// Bağlantı dizesi boş olsa bile AppDbContext'i ekleyin
			services.AddDbContext<AppDbContext>(options =>
			{
				if (string.IsNullOrWhiteSpace(connectionString))
				{
					// Boşsa bağlantı yapma
				}
				else
				{
					options.UseSqlServer(connectionString);
				}
			});

			services.AddScoped<UserService>();
			services.AddTransient<LoginForm>();
			services.AddTransient<UserEditForm>();
			services.AddTransient<UserListForm>();
		}
	}
}