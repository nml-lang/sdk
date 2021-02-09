//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from NML.g4 by ANTLR 4.9

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace NML.Parser.Generated {
 #pragma warning disable 3021 
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="NMLParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9")]
[System.CLSCompliant(false)]
public interface INMLVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="NMLParser.nml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNml([NotNull] NMLParser.NmlContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NMLParser.headers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHeaders([NotNull] NMLParser.HeadersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NMLParser.setheader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSetheader([NotNull] NMLParser.SetheaderContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NMLParser.assignheader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignheader([NotNull] NMLParser.AssignheaderContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NMLParser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElement([NotNull] NMLParser.ElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NMLParser.elementkey"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElementkey([NotNull] NMLParser.ElementkeyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NMLParser.with"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWith([NotNull] NMLParser.WithContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NMLParser.loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLoop([NotNull] NMLParser.LoopContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NMLParser.when"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhen([NotNull] NMLParser.WhenContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NMLParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPair([NotNull] NMLParser.PairContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NMLParser.key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKey([NotNull] NMLParser.KeyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NMLParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValue([NotNull] NMLParser.ValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NMLParser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitList([NotNull] NMLParser.ListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="NMLParser.concat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConcat([NotNull] NMLParser.ConcatContext context);
}
} // namespace NML.Parser.Generated
