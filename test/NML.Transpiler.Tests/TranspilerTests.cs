using System.IO;
using System.Text;
using System.Threading.Tasks;
using NML.Parser;
using NML.Parser.Objects;
using NML.Transpiler.Generators;
using Xunit;

namespace NML.Transpiler.Test
{
	public class TranspilerTests
    {

		/// <summary>
		/// Test function to test a test file in the project and compare it to a copied compiled file output
		/// </summary>
		[Fact]
        public async Task TestDocumentToHtmlAsync()
        {
            string fileText = await File.ReadAllTextAsync("test.nml", Encoding.UTF8);
            NMLDocument script = NMLDocumentLoader.Load(fileText);

            var transpiler = new Transpiler();
            var html = transpiler.ToScript(script, new HtmlGenerator());

			Assert.Equal(
				@"<html><head></head><body><div class=""container""><nav class=""navbar"" role=""navigation"" aria-label=""main navigation""><div class=""navbar-brand""><a class=""navbar-item"" href=""https://bulma.io""><img src=""https://bulma.io/images/bulma-logo.png"" width=""112"" height=""28"" /></a><a role=""button"" class=""navbar-burger"" aria-label=""menu"" aria-expanded=""false"" data-target=""navbarBasicExample""><span aria-hidden=""true"" /><span aria-hidden=""true"" /><span aria-hidden=""true"" /></a></div><div id=""navbarBasicExample"" class=""navbar-menu""><div class=""navbar-start""><a class=""navbar-item"">Home</a><a class=""navbar-item"">Documentation</a></div><div class=""navbar-end""><div class=""navbar-item""><a class=""button is-primary""><strong >Sign up</strong></a><a class=""button is-light"">Log in</a></div></div></div></nav><nav class=""navbar"" role=""navigation"" aria-label=""main navigation""><div class=""navbar-brand""><a class=""navbar-item"" href=""https://bulma.io""><img src=""https://bulma.io/images/bulma-logo.png"" width=""112"" height=""28"" /></a><a role=""button"" class=""navbar-burger"" aria-label=""menu"" aria-expanded=""false"" data-target=""navbarBasicExample""><span aria-hidden=""true"" /><span aria-hidden=""true"" /><span aria-hidden=""true"" /></a></div><div id=""navbarBasicExample"" class=""navbar-menu""><div class=""navbar-start""><a class=""navbar-item"">Home</a><a class=""navbar-item"">Documentation</a></div><div class=""navbar-end""><div class=""navbar-item""><a class=""button is-primary""><strong >Sign up</strong></a><a class=""button is-light"">Log in</a></div></div></div></nav><figure ><img src=""https://nml-lang.github.io/sdk/samples/img/img_food.jpg"" /><figcaption >Shows a car when on a screen thats under 1000 pixels, a girl when its under 600, and otherwise food</figcaption></figure><form ><input class=""form-control"" type=""text"" name=""testInput"" placeholder=""Placeholder Value"">Default Value<label class=""col-form"">Default Value</label><figcaption class=""form-text text-muted"">Help text</figcaption></input><select ><option value=""top action"" /><option value=""show secret option 2"" /><option value=""show secret option 2"" /><option value=""show secret option 2"" /><option value=""show secret option 2"" /></select><input class=""form-row horizontal"" name=""testInput"">imported input</input><button type=""submit"" class=""btn btn-primary"">Submit</button></form></div></body></html>"
				, html
			);
        }

		/// <summary>
		/// Test function to test a specific nml code block and compare it to a compiled code block
		/// </summary>
		[Fact]
		public void TestString()
		{
			string NMLHeaders = @"set page.title ""Quick example"";";
			string NMLContent = @"form: {
			input: {type: ""text""; placeholder: ""Test value""}
			select: {values: (""First"", ""Second"");option: for value in values { value: value;}}
			}";

			NMLDocument script = NMLDocumentLoader.Load(NMLHeaders + NMLContent);

			var transpiler = new Transpiler();
			var html = transpiler.ToScript(script, new HtmlGenerator());

			Assert.Equal(
				@"<html><head></head><body><form ><input type=""text"" placeholder=""Test value"" /><select ><option value=""Second"" /><option value=""Second"" /></select></form></body></html>",
				html
			);
		}
	}
}
