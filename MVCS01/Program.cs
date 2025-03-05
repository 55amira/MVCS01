namespace MVCS01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //builder.Services.AddControllers();
            builder.Services.AddControllersWithViews();
            var app  = builder.Build();
           
            //app.MapGet("/", () => "Hello World!");
            ////app.MapGet("/login", () => " u r in signed in !"); 
            //app.MapGet("/login", Sign);
            app.UseStaticFiles();
            app.MapControllerRoute(
                
                name : "defult",
                pattern: "{controller}/{action}/{id?}"
            );

            app.Run();
        }

        public static String Sign()
        {
            return" u r in signed in !";
        }
    }
}
