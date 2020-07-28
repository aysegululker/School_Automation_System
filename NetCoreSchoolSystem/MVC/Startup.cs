using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using BLL.Repository;
using DAL.Context;
using DAL.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MVC
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        //You should do "Set as Startup Project" (MVC'ye sað týklayarak baþlangýç projesi yapmalýsýnýz)
        //You should downland the following packages with Package Manager Console. Be careful, you should be at "Default project:MVC" (Package Manager Console'da, Default project:MVC olacak þekilde aþaðýdaki paketleri indirmelisiniz)
        //install-package Microsoft.EntityFrameworkCore.SqlServer
        //install-package Microsoft.EntityFrameworkCore.Design
        //install-package Microsoft.EntityFrameworkCore.Tools


        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(x => x.EnableEndpointRouting = false); //For app.UseMVC(routes)
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("MVC")));

            //Scoped
            services.AddScoped<IBranchService, BranchRepository>();
            services.AddScoped<IClassRoomService, ClassRoomRepository>();
            services.AddScoped<ILessonHourService, LessonHourRepository>();
            services.AddScoped<ILessonService, LessonRepository>();
            services.AddScoped<IPeriodInformationService, PeriodInformationRepository>();
            services.AddScoped<ISuccessDocumentIdentificationService, SuccessDocumentIdentificationRepository>();
            services.AddScoped<ITeacherService, TeacherRepository>();
            services.AddScoped<IPreRegistrationService, PreRegistrationRepository>();
            services.AddScoped<IStudentService, StudentRepository>();

            //Identity
            services.AddIdentity<AppUser, AppUserRole>().AddEntityFrameworkStores<AppDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            
            app.UseRouting();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                routes.MapRoute(
                 name: "default",
                 template: "{controller=Home}/{action=Index}/{id?}"
               );
            });
        }
    }
}
