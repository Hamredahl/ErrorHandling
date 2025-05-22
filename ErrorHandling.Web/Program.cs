namespace ErrorHandling.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/error/exception");
                app.UseStatusCodePagesWithRedirects("/error/http/{0}");
            }
            app.MapControllers();
            app.Run();
        }
    }
}
