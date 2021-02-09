using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NML.Parser;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NMLAspSample.Controllers
{
	[ApiController]
	public class NMLController : ControllerBase
	{
		private readonly IScriptable _scripter;

		public NMLController(IScriptable scripter)
		{
			_scripter = scripter;
		}

		[HttpGet("samples/{sample}")]
		public async Task<IActionResult> GetSampleAsync(string sample)
		{
			using HttpClient http = new();
			try
			{
				var text = await http.GetStringAsync("https://mr9madness.github.io/NML/samples/" + sample);
				return Content(text, "text/plain");
			}
			catch(Exception)
			{
				return BadRequest("Sample does not exist");
			}
		}

		[HttpGet("compile/{sample}")]
		public async Task<IActionResult> GetCompiledSampleAsync(string sample)
		{
			using HttpClient http = new();
			try
			{
				var text = await http.GetStringAsync("https://mr9madness.github.io/NML/samples/" + sample);
				var document = NMLDocumentLoader.Load(text);

				return Content(_scripter.ToScript(document), "text/html");
			}
			catch (Exception)
			{
				return BadRequest("Sample does not exist");
			}
		}

		[HttpGet("compare/{sample}")]
		public async Task<IActionResult> GetCompareSampleAsync(string sample)
		{
			using HttpClient http = new();
			try
			{
				var text = await http.GetStringAsync("https://mr9madness.github.io/NML/samples/" + sample);
				var document = NMLDocumentLoader.Load(text);

				NML.Transpiler.Generator.HtmlGenerator.SetFormatting(true);
				var compiledText = _scripter.ToScript(document);

				StringBuilder builder = new("<html><body>");
				builder.AppendLine($"<textarea readonly rows='50' style='width: 49%;'>{text}</textarea>");
				builder.AppendLine($"<textarea readonly rows='50' style='width: 49%;'>{compiledText}</textarea>");

				builder.AppendLine("</body></html>");

				return Content(builder.ToString(), "text/html");
			}
			catch (Exception)
			{
				return BadRequest("Sample does not exist");
			}
		}

		[HttpPost("compile")]
		public IActionResult CompileCode([FromBody] string code)
		{
			if (!string.IsNullOrWhiteSpace(code))
				return BadRequest("No code provided");

			var document = NMLDocumentLoader.Load(code);
			return Content(_scripter.ToScript(document), "text/html");
		}
	}
}
