# Creating ASP.Net Core service with Eagle NUnit Http

1. Create a ASP.Net core web application project
2. Create a NUnit v3 .Net Core Test project
 * The project should be compatible to the ASP.Net core web application project
3. Refer the Test project in the ASP.Net core web application project
4. In the ASP.Net core web application project, include the nuget package "WonderTools.Eagle.Http.Contract"
5. Modify the starup of ASP.Net core web application to handle Eagle requests by calling the "UseEagleNUnitHttp" as shown [here](https://raw.githubusercontent.com/WonderTools/Eagle.Documentation/master/Samples/S001-asp.net-core-azure-functions/code/EagleAzureFunctionNunitHttp/EagleAzureFunctionNunitHttp/Function1.cs)
6. Test the Web application by deploying it locally or in Azure.
* If you have adapted the function as shown in the same, the funtion could be triggered by the url "https://localhost:44345/api/tests/execute"
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
