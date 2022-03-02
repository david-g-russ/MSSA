using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.IO;

namespace CodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var assemblyunit = new CodeCompileUnit(); // represents assembly

            var dynamic_namespace = new CodeNamespace("TestNamespace"); // namespace in assembly
            dynamic_namespace.Imports.Add(new CodeNamespaceImport("System")); // adds using statement

            var progtype = new CodeTypeDeclaration("Program"); // creates a class called Program
            dynamic_namespace.Types.Add(progtype); // adds the program class to the namespace

            var mainmethod = new CodeEntryPointMethod(); // creates the main method as an entry point for the program
            progtype.Members.Add(mainmethod); // adds the main method to the Program class
            
            var expression1 = new CodeMethodInvokeExpression(new CodeTypeReferenceExpression("Console"), "WriteLine", new CodePrimitiveExpression("Hello from new program"));
            var expression2 = new CodeMethodInvokeExpression(new CodeTypeReferenceExpression("Console"), "WriteLine", new CodePrimitiveExpression("This is generated code"));
            var expression3 = new CodeMethodInvokeExpression(new CodeTypeReferenceExpression("Console"), "WriteLine", new CodePrimitiveExpression("Do not be afraid of our new robot overlords"));
            var expression4 = new CodeMethodInvokeExpression(new CodeTypeReferenceExpression("Console"), "ReadLine");
            mainmethod.Statements.Add(expression1);
            mainmethod.Statements.Add(expression2);
            mainmethod.Statements.Add(expression3);
            mainmethod.Statements.Add(expression4);


            var csharp = new CSharpCodeProvider();
            var filename = "prog.cs";
            var stream = new StreamWriter(filename);
            var tw = new IndentedTextWriter(stream);

            var options = new CodeGeneratorOptions();
            options.BlankLinesBetweenMembers = true;

            assemblyunit.Namespaces.Add(dynamic_namespace);

            csharp.GenerateCodeFromCompileUnit(assemblyunit, tw, options); // generates prog.cs

            tw.Close();
            stream.Close();

            var compilersettings = new CompilerParameters();
            compilersettings.ReferencedAssemblies.Add("System.dll");
            compilersettings.GenerateExecutable = true;
            compilersettings.OutputAssembly = "demo.exe";
            compilersettings.GenerateInMemory = false;

            var result = csharp.CompileAssemblyFromFile(compilersettings, "prog.cs");
            Console.WriteLine("Exe is created");
            Console.ReadLine();

        }
    }
}
