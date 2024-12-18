
using LaboBibliotheque_API.Services;
using LaboBibliotheque_BLL.Services;
using LaboBibliotheque_Common.Repositories;
using LaboBibliotheque_DB;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel;
using System.Text;

namespace LaboBibliotheque_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<DataContext>();
            builder.Services.AddScoped<IAchatsRepository<LaboBibliotheque_BLL.Entities.Achats>,LaboBibliotheque_BLL.Services.AchatsServices>();
            builder.Services.AddScoped<IAdressesRepository<LaboBibliotheque_BLL.Entities.Adresses>, LaboBibliotheque_BLL.Services.AdressesServices>();
            builder.Services.AddScoped<IAuteursRepository<LaboBibliotheque_BLL.Entities.Auteurs>, LaboBibliotheque_BLL.Services.AuteursServices>();
            builder.Services.AddScoped<IGenresRepository<LaboBibliotheque_BLL.Entities.Genres>, LaboBibliotheque_BLL.Services.GenresServices>();
            builder.Services.AddScoped<ILivresRepository<LaboBibliotheque_BLL.Entities.Livres>, LaboBibliotheque_BLL.Services.LivresServices>();
            builder.Services.AddScoped<ILocationsRepository<LaboBibliotheque_BLL.Entities.Locations>, LaboBibliotheque_BLL.Services.LocationsServices>();
            builder.Services.AddScoped<IUtilisateursRepository<LaboBibliotheque_BLL.Entities.Utilisateurs>, LaboBibliotheque_BLL.Services.UtilisateursServices>();
            builder.Services.AddScoped<TokenService>();

            // Add JWT config
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = builder.Configuration["Token:Issuer"],
                        ValidAudience = builder.Configuration["Token:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:Secret"]))
                    };
                });
            


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors(o => o.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
