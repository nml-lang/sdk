using NML.Parser.Objects;
using NML.Transpiler.Generators;

namespace NML.Transpiler
{
    public interface IScriptable
    {
        public string ToScript(NMLDocument value, IGenerator generator);
    }
}
