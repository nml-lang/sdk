# [NML](https://github.com/nml-lang/sdk)

NML (Native (environment) markup language) is a markup language designed to be used on different environments all with the same language

Project structure:

src directory:

- NML.Parser: Main NML parser directory
- NML.Transpiler: Collection of NML transpilers (for now only a HTML transpiler)
- NML.Transpiler.Tool: Small command line app to compile files to html

samples directory:

- Samples directory contains a sample of a web project to compile NML to HTML in the browser

test directory:

- Tests directory contains test for both NML.Parser and NML.Transpiler projects

- Docs branch contains a small doc website hosted on [github.io](https://nml-lang.github.io/sdk/)