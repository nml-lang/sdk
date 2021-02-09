using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NML.Parser;
using NML.Parser.Objects;
using NML.Parser.Objects.Elements;
using Xunit;

namespace NML.Test
{
	public class ParsingTests
	{
		/// <summary>
		/// Test function to test a test file in the project and check if its not null
		/// </summary>
		[Fact]
		public async Task TestDocumentAsync()
		{
			string fileText = await File.ReadAllTextAsync("test.nml", Encoding.UTF8);
			NMLDocument script = NMLDocumentLoader.Load(fileText);

			Assert.NotNull(script);
		}

		/// <summary>
		/// Test function to test a specific nml code block and check if its not null and if the base element is not null and has the excepted attr's and children
		/// </summary>
		[Fact]
		public void TestString()
		{
			string nmlHeaders = @"set page.title ""Quick example"";";
			string nmlContent = @"form#form-container: {
			input: {type: ""text""; placeholder: ""Test value""}
			select: {values: (""First"", ""Second"");option: for value in values { value: value;}}
			}";

			NMLDocument script = NMLDocumentLoader.Load(nmlHeaders + nmlContent);

			Assert.NotNull(script);

			var baseElement = script.Children.FirstOrDefault();

			Assert.NotNull(baseElement);

			Assert.IsAssignableFrom<NamedElement>(baseElement);
			var named = baseElement as NamedElement;

			Assert.Equal("form", named.Name);
			Assert.Equal("form-container", named.Identifier);

			Assert.Equal(0, named.Attributes.Count);
			Assert.Equal(2, named.Children.Count);
		}
	}
}
