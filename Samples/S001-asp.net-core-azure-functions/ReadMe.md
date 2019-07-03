# Creating Eagle C# NUnit in .Net Core Http Azure Function

1. Create a Azure functions project
 * The project should be Azure Function V2 or something supports .Net Core
 * The azure function should be triggered by http
2. Create a NUnit v3 .Net Core Test project
 * The project should be compatible to the Azure Function project
3. Refer the Test project in the Azure function project
4. In the Azure Function project, include the nuget package "WonderTools.Eagle.Http.Contract"
5. Modify the Azure Function to handle Eagle requests by calling the extention method "HandleRequest" as shown [here](https://raw.githubusercontent.com/WonderTools/Eagle.Documentation/master/Samples/S001-asp.net-core-azure-functions/code/EagleAzureFunctionNunitHttp/EagleAzureFunctionNunitHttp/Function1.cs)
6. The sample code could be downloaded [here](https://github.com/WonderTools/Eagle.Documentation/raw/master/Samples/S001-asp.net-core-azure-functions/code/EagleAzureFunctionNunitHttp.zip)
