# Extensibility Template Pack

[![Build status](https://ci.appveyor.com/api/projects/status/opoy5kyysss7f851?svg=true)](https://ci.appveyor.com/project/madskristensen/extensibilitytemplatepack-dhpo7)

Awesome item templates for VSIX development

Download this extension from the [Marketplace](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.ExtensibilityItemTemplates)
or get the [CI build](https://www.vsixgallery.com/extension/88049e1e-62f2-4ea2-851f-9ddb2de37f41).

----------------------------------------------

A template pack for Visual Studio extension authors full of useful project- and item templates.

## Project templates
Two new project templates replaces the existing *VSIX Project* and *Empty VSIX Project* templates that ships with Visual Studio.

The two project templates also include a reference to the NuGet package [Community.VisualStudio.Toolkit](https://www.nuget.org/packages/Community.VisualStudio.Toolkit/), which makes extension development a lot easier.

### 1. VSIX Project (Community)
This template generates a clean VSIX project with a *AsyncPackage* class, an extension icon, and NuGet references to the VSSDK.

![Vsix Project](art/vsix-project.png)

#### 1.1 VSIX Project w/Command (Community)
Same as VSIX Project (Community) + a custom command.

### 3. Empty VSIX Project (Community)
This template generates an empty VSIX project with only an extension icon and NuGet references to the VSSDK.

![Empty Vsix Project](art/empty-vsix-project.png)

Find both templates in the New Project Dialog.

![New Project Dialog](art/npd.png?)

They are both cleaned up and simplified versions of the built in templates.


## Item templates
The templates marked `(modern)` can be used with the regular Visual Studio SDK. They are a cleaned up and modern version of the original templates, but the follow best practices and are much simpler.

The templates marked `(Community)` can be used with the NuGet package [Community.VisualStudio.Toolkit](https://www.nuget.org/packages/Community.VisualStudio.Toolkit/) which makes extension development much easier.

* [Async Package (modern)](https://github.com/madskristensen/VsixItemTemplates/blob/master/src/ItemTemplates/Package/VsPkg.cs)
* [Command (modern)](https://github.com/madskristensen/VsixItemTemplates/blob/master/src/ItemTemplates/CustomCommand/Command.cs)
* [Command (Community)](https://github.com/madskristensen/VsixItemTemplates/blob/master/src/ItemTemplates/CustomCommandOptimized/Command.cs)
* [Async Tool Window (modern)](https://github.com/madskristensen/VsixItemTemplates/tree/master/src/ItemTemplates/ToolWindow)
* [Async Tool Window (Community)](https://github.com/madskristensen/VsixItemTemplates/tree/master/src/ItemTemplates/ToolWindow%20Optimized)
* [Options Page (Community)](https://github.com/madskristensen/VsixItemTemplates/blob/master/src/ItemTemplates/OptionsPage/OptionsPage.cs)

![Add New Items](art/add-new-items.png)

In addition, there are seveal other templates available.

* [Editor Command Binding](https://github.com/madskristensen/VsixItemTemplates/blob/master/src/ItemTemplates/EditorCommandBinding/EditorCommandBinding.cs)
* [Editor Command Handler](https://github.com/madskristensen/VsixItemTemplates/blob/master/src/ItemTemplates/EditorCommandHandler/EditorCommandHandler.cs)
* [WPF TextView Creation Listener](https://github.com/madskristensen/VsixItemTemplates/blob/master/src/ItemTemplates/TextviewCreationListener/TextviewCreationListener.cs)
* [Code Snippets](https://github.com/madskristensen/VsixItemTemplates/blob/master/src/ItemTemplates/Snippet/Snippet.snippet)

![Add New Items2](art/add-new-items2.png)

## License
[Apache 2.0](LICENSE)