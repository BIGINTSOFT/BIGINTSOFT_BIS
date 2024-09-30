using BIS.Data.Contexts;
using EFCore.AutomaticMigrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIS.UI
{
	public partial class SettingsForm : Form
	{
		private AppDbContext _context;
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string connectionString = $"Server={txtServer.Text};Database={txtDatabase.Text};User Id={txtUsername.Text};Password={txtPassword.Text};TrustServerCertificate=True;";
			MessageBox.Show($"Using connection string: {connectionString}"); // Bağlantı dizesini kontrol edin

			try
			{
				SaveConnectionString(connectionString);

				var options = new DbContextOptionsBuilder<AppDbContext>()
			  .UseSqlServer(connectionString,
				options => { options.MigrationsHistoryTable("__EFMigrationsHistory", "dbo"); })
				.Options;

				_context = new AppDbContext(options);

				ApplyMigrations();



			}
			catch (Exception ex)
			{

				throw;
			}
		}
		private async void ApplyMigrations()
		{

			var options = new DbMigrationsOptions
			{
				AutomaticMigrationsEnabled = true,
				AutomaticMigrationDataLossAllowed = true,

			};

			try
			{
				await MigrateDatabaseToLatestVersion.ExecuteAsync(_context, options);

			}
			catch (Exception ex)
			{

				throw;
			}
		}


		private void SaveConnectionString(string connectionString)
		{
			string appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

			try
			{
				// Dosyayı oku
				string json = File.ReadAllText(appSettingsPath);

				// JSON'ı ayrıştır
				var jsonObject = JsonNode.Parse(json).AsObject();

				// ConnectionStrings nesnesini al veya oluştur
				if (!jsonObject.ContainsKey("ConnectionStrings"))
				{
					jsonObject["ConnectionStrings"] = new JsonObject();
				}
				var connectionStrings = jsonObject["ConnectionStrings"].AsObject();

				// DefaultConnection'ı güncelle veya ekle
				connectionStrings["DefaultConnection"] = connectionString;

				// JSON'ı geri yaz
				var options = new JsonSerializerOptions { WriteIndented = true };
				string updatedJson = JsonSerializer.Serialize(jsonObject, options);
				File.WriteAllText(appSettingsPath, updatedJson);

				Console.WriteLine("appsettings.json başarıyla güncellendi.");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"appsettings.json güncellenirken hata oluştu: {ex.Message}");
			}
		}
	}
}
