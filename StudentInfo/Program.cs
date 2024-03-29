using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using StudentInfo.Interfaces.IRepositories;
using StudentInfo.Model;
using StudentInfo.Repositories;

namespace StudentInfo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddServerSideBlazor().AddHubOptions(o =>
            {
                o.MaximumReceiveMessageSize = 10 * 1024 * 1024;
            }); 

            builder.Services.AddScoped<DialogService>();
            builder.Services.AddScoped<NotificationService>();
            builder.Services.AddScoped<TooltipService>();
            builder.Services.AddScoped<ContextMenuService>();
            builder.Services.AddRadzenComponents();
            

            builder.Services.AddScoped<IBaseRepository<Faculty>, FacultyRepository>();
            builder.Services.AddScoped<IBaseRepository<Department>, DepartmantRepository>();
            builder.Services.AddScoped<IBaseRepository<Student>, StudentRepository>();
            builder.Services.AddScoped<IBaseRepository<StudentInfo.Model.Group>, GroupRepository>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}
