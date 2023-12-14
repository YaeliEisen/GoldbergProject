using GoldbergProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repositories.Interfaces;
using Repositories.Repositories;
using Services;
using Services.Interfaces;
using Services.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddDbContext<ProjectContext>(options =>
//     options.UseSqlServer(Configuration.GetConnectionString("Server=DESKTOP-24EQMFH;Database=Project;Integrated Security=True;")));

builder.Services.AddDbContext<ProjectContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICommunityService, CommunityService>();
builder.Services.AddScoped<ICommunityrepository, Communityrepository>();

builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddScoped<IImageRepository, ImageRepository>();

builder.Services.AddScoped<IOrganizationService, OrganizationService>();
builder.Services.AddScoped<IOrganizationRepository, OrganizationRepository>();

builder.Services.AddScoped<ICommunitiesForOrganizationService, CommunitiesForOrganizationService>();
builder.Services.AddScoped<ICommunitiesForOrganizationRepository, CommunitiesForOrganizationRepository>();


builder.Services.AddAutoMapper(typeof(Mapping));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors();

app.Run();
