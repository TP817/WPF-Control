---
title: "Assembly Documentation"
page-title: "Assembly Documentation - SyntaxEditor .NET Languages Add-on"
order: 4
---
# Assembly Documentation

Each [IAssembly](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IAssembly) is able to provide documentation for the types and members that it contains.  This documentation generally originates from XML documentation comments.

## Assembly Documentation

The [IAssembly](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IAssembly).[Documentation](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IAssembly.Documentation) property provides access to the assembly's documentation.  It returns an object of type [IAssemblyDocumentation](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IAssemblyDocumentation) that has @if (winrt) {[GetDocumentationAsync](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IAssemblyDocumentation.GetDocumentationAsync)}@if (wpf winforms) {[GetDocumentation](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IAssemblyDocumentation.GetDocumentation*)} method overloads, capable of returning an [IDocumentationProvider](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IDocumentationProvider) for a specific type or member.

The [IDocumentationProvider](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IDocumentationProvider) makes it easy to get the documentation summary, type parameter info, or parameter info for the target type/member.  This data is generally used in IntelliPrompt display.

## Project Assembly Documentation

Project assemblies, or types implementing [IProjectAssembly](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IProjectAssembly), automatically create a special [IAssemblyDocumentation](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IAssemblyDocumentation) instance that provides the documentation for types/members defined in the project's source files.  This class is wired up by default onto the [IProjectAssembly](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IProjectAssembly).[Documentation](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IAssembly.Documentation) property.

## Binary Assembly Documentation

@if (winrt) {

Binary assemblies, or types implementing [IBinaryAssembly](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IBinaryAssembly), cannot automatically attempt to probe and look for XML documentation files due to security sandboxing in @@PlatformName.  That being said, if XML documentation files are accessible in certain folder paths, they can be manually loaded per the information in the following section.

}

@if (wpf winforms) {

Binary assemblies, or types implementing [IBinaryAssembly](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IBinaryAssembly), will automatically attempt to probe and look for XML documentation files of the same name as the DLL in certain file system locations.  This attempt will not succeed where security prohibits access to certain file paths.  If the attempt does succeed and an appropriate XML documentation file is located, it will be loaded up into a [FileAssemblyDocumentation](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.Implementation.FileAssemblyDocumentation) instance that gets assigned to the [IBinaryAssembly](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IBinaryAssembly).[Documentation](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IAssembly.Documentation) property.  If that property is `null`, then no documentation was able to be automatically loaded for the assembly.

}

@if (wpf winforms) {

### Probing Logic

When probing for XML files, it will first examine the folder that contained the DLL file, if that is known.  Within this folder, it will search for a localization child folder named by the current culture.  If a file is not found there, it will look in the folder that contains the DLL.  If a file is not found there, it will start searching through various known .NET "Reference Assemblies" folders for the file.

}

## Manually Loading Binary Assembly Documentation

For scenarios where the automatic probing for XML documentation comment files was unsuccessful (generally because of security restrictions or the files simply not being in a known location), but you know where the XML file is located, it is possible to manually create a [FileAssemblyDocumentation](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.Implementation.FileAssemblyDocumentation) instance and pass the file path in its constructor.  Then set that instance to the [IBinaryAssembly](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IBinaryAssembly).[Documentation](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IAssembly.Documentation) property.

As long as security permits access to the path, the documentation will be loaded properly as needed.

## Custom Assembly Documentation

Custom [IAssemblyDocumentation](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.IAssemblyDocumentation) implementations can also be built if you would prefer to access type/member documentation in another fashion (web service, etc.).

For instance, a class inheriting [StreamAssemblyDocumentationBase](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.Implementation.StreamAssemblyDocumentationBase) could be made to access XML documentation files stored as a manifest resource in the application's EXE.  In this case, simply override the @if (winrt) {[GetStreamAsync](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.Implementation.StreamAssemblyDocumentationBase.GetStreamAsync)}@if (wpf winforms) {[GetStream](xref:ActiproSoftware.Text.Languages.DotNet.Reflection.Implementation.StreamAssemblyDocumentationBase.GetStream*)} method to return a `Stream` to the XML file, and the base class will do the rest.
