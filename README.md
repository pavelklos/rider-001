# rider-001 <small>(JetBrains Rider Course steps)</small>

- Recommended **.gitignore** files ([.NET](https://github.com/github/gitignore/blob/main/Dotnet.gitignore), [JetBrains](https://www.toptal.com/developers/gitignore/api/jetbrains), [JetBrains Rider](https://github.com/JetBrains/resharper-rider-samples/blob/master/.gitignore))

- Solution [rider-001.sln](rider-001.sln) with <ins>**Project types**</ins>:
  - Console [ConsoleApp1](ConsoleApp1/) ([csproj](ConsoleApp1/ConsoleApp1.csproj))
  - Class Library [ClassLibrary1](ClassLibrary1/) ([csproj](ClassLibrary1/ClassLibrary1.csproj))
  - Desktop - WPF Application [WpfApp1](WpfApp1/) ([csproj](WpfApp1/WpfApp1.csproj))
  - Desktop - Windows Forms App [WinFormsApp1](WinFormsApp1/) ([csproj](WinFormsApp1/WinFormsApp1.csproj))
  - Web - Blazor Web App - Server [BlazorAppServer1](BlazorAppServer1/) ([csproj](BlazorAppServer1/BlazorAppServer1.csproj))
  - Web - Blazor Web App - WebAssembly
    - [BlazorAppWebAssembly1](BlazorAppWebAssembly1/BlazorAppWebAssembly1/) ([csproj](BlazorAppWebAssembly1/BlazorAppWebAssembly1/BlazorAppWebAssembly1.csproj))
    - [BlazorAppWebAssembly1.Client](BlazorAppWebAssembly1/BlazorAppWebAssembly1.Client/) ([csproj](BlazorAppWebAssembly1/BlazorAppWebAssembly1.Client/BlazorAppWebAssembly1.Client.csproj))
  - Web - Web API [WebApi1](WebApi1/) ([csproj](WebApi1/WebApi1.csproj))
  - Web - Web API - Minimal API [WebApiMinimalApi1](WebApiMinimalApi1/) ([csproj](WebApiMinimalApi1/WebApiMinimalApi1.csproj))
  - Web - Web App (Model-View-Controller) [WebAppMvc1](WebAppMvc1/) ([csproj](WebAppMvc1/WebAppMvc1.csproj))
  - Web - Web App (Razor Pages) [WebAppRazorPages1](WebAppRazorPages1/) ([csproj](WebAppRazorPages1/WebAppRazorPages1.csproj))
  - Web - gRPC Service [GrpcService1](GrpcService1/) ([csproj](GrpcService1/GrpcService1.csproj))
  - Services [WorkerService1](WorkerService1/) ([csproj](WorkerService1/WorkerService1.csproj))
  - Unit Test - NUnit 3 [TestProjectNunit1](TestProjectNunit1/) ([csproj](TestProjectNunit1/TestProjectNunit1.csproj))
  - Unit Test - MSTest [TestProjectMstest1](TestProjectMstest1/) ([csproj](TestProjectMstest1/TestProjectMstest1.csproj))
  - Unit Test - xUnit [TestProjectXunit1](TestProjectXunit1/) ([csproj](TestProjectXunit1/TestProjectXunit1.csproj))

- Course steps:
  - **Working with codebase** [DometrainRiderPlayground](DometrainRiderPlayground/) ([csproj](DometrainRiderPlayground/DometrainRiderPlayground.csproj)) <small>Console</small>
  - **Debugging**
    - [DometrainDebuggingPlayground](DometrainDebuggingPlayground/) ([csproj](DometrainDebuggingPlayground/DometrainDebuggingPlayground.csproj)) <small>Web API</small>
    - [DometrainDebuggingPlayground.Tests](DometrainDebuggingPlayground.Tests/) ([csproj](DometrainDebuggingPlayground.Tests/DometrainDebuggingPlayground.Tests.csproj)) <small>Web API (Integration Test - xUnit)</small>
  - **Testing**
    - [ShoppingCartLib](ShoppingCartLib/) ([csproj](ShoppingCartLib/ShoppingCartLib.csproj)) <small>Class Library</small>
    - [ShoppingCartLib.Tests](ShoppingCartLib.Tests/) ([csproj](ShoppingCartLib.Tests/ShoppingCartLib.Tests.csproj)) <small>Class Library (Unit Test - xUnit)</small>
  - **AI**
    - [AiAssistantDemo](AiAssistantDemo/) ([csproj](AiAssistantDemo/AiAssistantDemo.csproj)) <small>Console</small>
    - [AiAssistantDemo.Tests](AiAssistantDemo.Tests/) ([csproj](AiAssistantDemo.Tests/AiAssistantDemo.Tests.csproj)) <small>Class Library (Unit Test - xUnit)</small>
  - **Profiling**
    - [PerformanceModule](PerformanceModule/) ([csproj](PerformanceModule/PerformanceModule.csproj)) <small>Console (Spectre.Console)</small>