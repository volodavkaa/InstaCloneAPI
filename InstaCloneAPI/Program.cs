
using Microsoft.EntityFrameworkCore;

namespace InstaCloneAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            
            app.UseRouting();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();

        }
    }
}
