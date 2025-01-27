## Introduction

Random Image Widget

## Download

Compiled downloads are not available.

## Compiling

To clone and run this application, you'll need [Git](https://git-scm.com) and [.NET](https://dotnet.microsoft.com/) installed on your computer. From your command line:

```
# Clone this repository
$ git clone https://github.com/btigi/randomimagewidget

# Go into the repository
$ cd src

# Build  the app
$ dotnet build
```

## Installation
- Open the project in Visual Studio.
- Build the project
- Deploy the project (right-click the solution and select Deploy)
- Bring up the Windows Widget area (Windows + W)
- Select the + icon
- Select Random Image

Note: The solution may fail to deploy on subsequent deploments due to the files being in used. Choosing the Deploy option multiple times generally results in the app being updated.

## Configuration

Random Image Widget reads images.txt from the LocalAppData directory, e.g. C:\Users\%username%\AppData\Local. The file is expected to contain one image URL per line.


## References
https://www.adaptivecards.io/designer/

https://learn.microsoft.com/en-gb/windows/apps/desktop/modernize/desktop-to-uwp-distribute

https://github.com/microsoft/WindowsAppSDK-Samples/tree/main/Samples/Widgets

https://learn.microsoft.com/en-us/windows/apps/develop/widgets/implement-widget-provider-cs

## Licencing

Random Image Widget is licenced under the [MIT licence](https://mit-license.org/) Full licence details are available in licence.md