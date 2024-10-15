namespace Configuring_Default_Page
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            // Setting the Default Files
            app.UseDefaultFiles();

            // Adding static Files Middleware Component to serve the static files
            app.UseStaticFiles();

            // Adding Another Middleware Component to the Request Processing Pipeline
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Request Handled and Response Generated");
            });

            // This will Run the Application
            app.Run();
        }
    }
}
