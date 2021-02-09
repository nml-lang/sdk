using System.IO;
using System.Text;
using NML.Parser;
using NML.Transpiler.Transpiler;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace NMLAspSample
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{

			services.AddControllers();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "NMLAspSample", Version = "v1" });
			});

			services.AddScoped<IScriptable, HtmlTranspiler>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NMLAspSample v1"));
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
				endpoints.MapGet("/", async context =>
				{
					StringBuilder builder = new("<html><body><ul>");

					builder.AppendLine($"<li><a href=\"samples/test.nml\">test.nml</a> <a href=\"compile/test.nml\">(view html)</a> <a href=\"compare/test.nml\">(compare)</a></li>");
					builder.AppendLine($"<li><a href=\"samples/pack.nml\">pack.nml</a> <a href=\"compile/pack.nml\">(view html)</a> <a href=\"compare/pack.nml\">(compare)</a></li>");
					builder.AppendLine($"<li><a href=\"samples/basic.nml\">basic.nml</a> <a href=\"compile/basic.nml\">(view html)</a> <a href=\"compare/basic.nml\">(compare)</a></li>");
					builder.AppendLine("</ul></body></html>");

					await context.Response.WriteAsync(builder.ToString());
				});
			});
		}
	}
}
