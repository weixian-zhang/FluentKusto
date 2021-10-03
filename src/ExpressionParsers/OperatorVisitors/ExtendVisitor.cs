
// using System;
// using System.Collections.Generic;
// using System.Linq.Expressions;
// using System.Reflection;
// using System.Reflection.Metadata;
// using System.Reflection.Metadata.Ecma335;
// using System.Text.RegularExpressions;
// using ICSharpCode.Decompiler;
// using ICSharpCode.Decompiler.CSharp;
// using Microsoft.CodeAnalysis.CSharp;
// using Microsoft.CodeAnalysis.CSharp.Syntax;

// namespace FluentKusto
// {
//     public class ExtendVisitor : IOperatorFuncVisitor
//     {
//         public string ParseQuery<T>(Func<TableBase<T>, dynamic, object> func)  where T : new()
//         {
//             var decompiler = Decompiler.New();

//             var handle = (MethodDefinitionHandle)MetadataTokens.EntityHandle(func.Method.MetadataToken);

//             var funcRawCode = decompiler.DecompileAsString(handle);//(new List<EntityHandle>() { method.Value });

//             string noBreaklineCode = Regex.Replace(Regex.Replace(funcRawCode, @"\n|\r", " "), @"\s+", " ");

//             string removeCodeTillCurlyBracket =
//                 noBreaklineCode.Substring(noBreaklineCode.IndexOf('{'), noBreaklineCode.Length - noBreaklineCode.IndexOf('{'));

//             string removeObjectCasting = removeCodeTillCurlyBracket.Replace("(object)", "");

//             int indexOfEndOfReturn = removeObjectCasting.IndexOf("return") + "return".Length;

//             int lastIndexOfCurlyBrac = removeObjectCasting.LastIndexOf("}") -1;

//             string removeUpToReturnStatement = removeObjectCasting.Substring(indexOfEndOfReturn);

//             string codeWithoutCloseCurlyBracEnd =  removeUpToReturnStatement.Remove(removeUpToReturnStatement.LastIndexOf('}') - 1, 1);

//             return "";
//         }

//     }
// }