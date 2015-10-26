namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FsEditorUtils")>]
[<assembly: AssemblyProductAttribute("FsEditorUtils")>]
[<assembly: AssemblyDescriptionAttribute("Utility Library for Visual Studio Extensions in F#")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
