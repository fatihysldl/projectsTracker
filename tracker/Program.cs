using businessLayer.abstracts;
using businessLayer.concrete;
using dataAccessLayer.abstracts;
using dataAccessLayer.concrete;
using dataAccessLayer.entityFramework;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<context>();

builder.Services.AddScoped<IProjectDal, efProjectDal>();
builder.Services.AddScoped<IProjectService, projectManager>();

builder.Services.AddScoped<ITaskStageDal, efTaskStageDal>();
builder.Services.AddScoped<ITaskStageService, taskStageManager>();

builder.Services.AddScoped<IUserDal, efUserDal>();
builder.Services.AddScoped<IUserService, userManager>();

builder.Services.AddScoped<ICompanyUserDal, efCompanyUserDal>();
builder.Services.AddScoped<ICompanyUserService, companyUserManager>();


builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers();

// Swagger Servislerini Ekleyin
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// MVC Servislerini Ekleyin
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Geliþtirme Ortamýnda Swagger UI Aktif
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        options.RoutePrefix = string.Empty;
    });
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
