---
title: "Indent Provider"
page-title: "Indent Provider - C# Language - SyntaxEditor .NET Languages Add-on"
order: 4
---
# Indent Provider

An indent provider enables support for smart indent features when pressing <kbd>Enter</kbd>.

The [Indent Providers](../../user-interface/input-output/indent-providers.md) topic talks about indent providers in general and how to register them as a "feature" language service.

The [CSharpIndentProvider](xref:ActiproSoftware.Text.Languages.CSharp.Implementation.CSharpIndentProvider) class is the default implementation of an [IIndentProvider](xref:@ActiproUIRoot.Controls.SyntaxEditor.IIndentProvider) service for this language.

## Feature Summary

### Smart Indent

The built-in indent provider will attempt to properly indent lines inside the current block scope.  For instance, pressing <kbd>Enter</kbd> after a `{` will cause the next line to be indented by one tab stop.  Pressing <kbd>Enter</kbd> while still typing a statement will also attempt to indent the next line by one tab stop.

### Typed Characters

When certain characters such as `{`, `}`, or `:` are typed, the line will be examined to see if it should be indented/outdented.

## Registering with a Syntax Language

Any object that implements [IIndentProvider](xref:@ActiproUIRoot.Controls.SyntaxEditor.IIndentProvider) can be associated with a syntax language by registering it as an [IIndentProvider](xref:@ActiproUIRoot.Controls.SyntaxEditor.IIndentProvider) service on the language.

The [CSharpSyntaxLanguage](xref:ActiproSoftware.Text.Languages.CSharp.Implementation.CSharpSyntaxLanguage) class automatically registers a [CSharpIndentProvider](xref:ActiproSoftware.Text.Languages.CSharp.Implementation.CSharpIndentProvider) with itself when it is created, so normally indent providers never need to be set on a C# language unless a custom one is made.

This code creates a custom indent provider (defined in a make-believe `CustomCSharpIndentProvider` class) and registers it with the syntax language that is already declared in the `language` variable:

```csharp
language.RegisterIndentProvider(new CustomCSharpIndentProvider());
```

> [!NOTE]
> The [SyntaxLanguageExtensions](xref:ActiproSoftware.Text.SyntaxLanguageExtensions).[RegisterIndentProvider](xref:ActiproSoftware.Text.SyntaxLanguageExtensions.RegisterIndentProvider*) method in the code snippet above is a helper extension method that gets added to [ISyntaxLanguage](xref:ActiproSoftware.Text.ISyntaxLanguage) objects when the `ActiproSoftware.Text` namespace is imported.  See the [Service Locator Architecture](../../language-creation/service-locator-architecture.md) topic for details on registering and retrieving various service object instances, both via extension methods and generically, as there are some additional requirements for using the extension methods.

## Disabling the Functionality

Since this feature is installed as a "feature" service on the language and is installed on [CSharpSyntaxLanguage](xref:ActiproSoftware.Text.Languages.CSharp.Implementation.CSharpSyntaxLanguage) by default, it can be disabled by uninstalling the service from the language.
