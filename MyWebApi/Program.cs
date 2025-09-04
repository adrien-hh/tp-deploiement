
namespace MyWebApi
{
	public class Program
	{
		public static void Main(string[] args)
		{
			WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			_ = builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			_ = builder.Services.AddEndpointsApiExplorer();
			_ = builder.Services.AddSwaggerGen();

			WebApplication app = builder.Build();

			_ = app.UseSwagger();
			_ = app.UseSwaggerUI();

			_ = app.UseHttpsRedirection();

			_ = app.UseAuthorization();

			_ = app.MapControllers();

			_ = app.MapGet("/", () => "Hello World!");

			app.Run();
		}
	}
}
