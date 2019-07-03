# Creating Eagle C# NUnit in .Net Core Http Azure Function

1. Create a Azure functions project
 * The project should be Azure Function V2 or something supports .Net Core
 * The azure function should be triggered by http
2. Create a NUnit v3 .Net Core Test project
 * The project should be compatible to the Azure Function project
3. Refer the Test project in the Azure function project
4. In the Azure Function project, include the nuget package "WonderTools.Eagle.Http.Contract"
5. Modify the Azure Function to handle Eagle requests by calling the extention method "HandleRequest" as shown [here](https://raw.githubusercontent.com/WonderTools/Eagle.Documentation/master/Samples/S001-asp.net-core-azure-functions/code/EagleAzureFunctionNunitHttp/EagleAzureFunctionNunitHttp/Function1.cs)
6. Test the Azure Function by deploying in Azure or in the Simulator.
* If you have adapted the function as shown in the same, the funtion could be triggered by the url "http://localhost:7071/api/api/tests/execute"
* The payload to the test the function is as below
```javascript
{
  "nodeName": "string",
  "id": "",
  "callBackUrl": "string",
  "requestId": "string"
}
```
7. The sample code could be downloaded [here](https://github.com/WonderTools/Eagle.Documentation/raw/master/Samples/S001-asp.net-core-azure-functions/code/EagleAzureFunctionNunitHttp.zip)
8. The application is tested in .net core version 2.1
