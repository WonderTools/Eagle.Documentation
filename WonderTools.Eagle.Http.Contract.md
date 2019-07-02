# WonderTools.Eagle.Http.Contract

WonderTools.Eagle.Http.Contract details the communication between Eagle Dashboard and Eagle Node using Http. The current and the only version of WonderTools.Eagle.Http.Contract is 1.1.0

The below picture gives an overview of the communication between Dashboard and the client using WonderTools.Eagle.Http.Contract.

![WonderTools Eagle Http Contract](https://raw.githubusercontent.com/WonderTools/Eagle.Documentation/master/http-contract.JPG)

The communication has 3 parts to it.
1. Triggering the test by the Dashboard
2. Posting the partial test report by the Node
3. Responding to the test trigger request with the full test report by the Node.


### Triggering the test by the Dashboard
1. Initiated by Dashboard
2. Handled by Node
3. URL: The URL of the node registed with the dashboard
4. Method: POST
5. Payload is as shown below
{
  "nodeName": "name of the node",
  "id": "testid",
  "callBackUrl": "http://dashboard-callback.url",
  "requestId": "request id",
  "nodeSecret": "node secret"
}



