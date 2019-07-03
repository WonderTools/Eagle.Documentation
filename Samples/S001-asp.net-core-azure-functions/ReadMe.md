# Creating Eagle C# NUnit in .Net Core Http Azure Function

1. Create a Azure functions project
 * Make sure to create V2 version of the function that supports .Net Core
 * Make sure to make this funciton Http Triggerable
2. Create a test project
 * Make sure that the test project is in C#, based on NUnit 3, and in .Net Core (version comparabile to the azure function project)
3. Refer the test project in the azure function project
4. In the Azure Function project, add the nuget package "WonderTools.Eagle.Http.Contract"
5. Modify the Azure Function

https://raw.githubusercontent.com/WonderTools/Eagle.Documentation/master/Samples/S001-asp.net-core-azure-functions/code/EagleAzureFunctionNunitHttp/EagleAzureFunctionNunitHttp/Function1.cs

https://github.com/WonderTools/Eagle.Documentation/raw/master/Samples/S001-asp.net-core-azure-functions/code/EagleAzureFunctionNunitHttp.zip
