using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.CommandLine;
using System.CommandLine.Invocation;
using NML.Transpiler.Generators;
using NML.Parser;
using NML.Parser.Objects;

namespace NML.Transpiler.Tool
{
	public enum Lang
	{
		Html,
	}
	class Program
	{
		static async Task Main(string[] args)
		{
			var command = new Command("html") { new Option<string>(new string[] { "-f", "--file" }) };

			command.Handler = CommandHandler.Create(
				(string file, string output) => DoTask(Lang.Html, file, output)
			);
			var rootCommand = new RootCommand {
				command,
				new Option<string>(new string[] { "-o", "--output" })
			};

			await rootCommand.InvokeAsync(args);
		}

		static async Task DoTask(Lang lang, string filePath, string outputDir)
		{
			if(!File.Exists(filePath)) throw new Exception("File does not exist");
			if(!Directory.Exists(outputDir)) Console.WriteLine("Output directory does not exist. It will be created");

			string fileName = Path.GetFileNameWithoutExtension(filePath);

			CancellationTokenSource source = new();
			CancellationToken token = source.Token;

			string fileText = await File.ReadAllTextAsync(filePath, Encoding.UTF8, token);

			NMLDocument script = NMLDocumentLoader.Load(fileText);

			Transpiler transpiler = new Transpiler();
			IGenerator generator = lang switch
			{
				Lang.Html => new HtmlGenerator(),
				_ => throw new NotImplementedException(),
			};
			string contents = transpiler.ToScript(script, generator);

			Directory.CreateDirectory(outputDir);
			await File.WriteAllTextAsync(Path.Join(outputDir, fileName + ".html"), contents, Encoding.UTF8, token);
		}
	}
}
