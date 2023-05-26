
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Diagnostics;

var workspace = new AdhocWorkspace();


Project generatedCodeProject = 
    workspace.AddProject("GeneratedCode", LanguageNames.CSharp)
        .WithCompilationOptions(new CSharpCompilationOptions(
           OutputKind.DynamicallyLinkedLibrary, nullableContextOptions: NullableContextOptions.Disable));

var compilation = await generatedCodeProject.GetCompilationAsync();

Debug.Assert(compilation != null);

var attributes =  compilation.Assembly.GetAttributes()
    .ToArray();

Console.WriteLine($"Assembly attributes found: {attributes.Length}");


