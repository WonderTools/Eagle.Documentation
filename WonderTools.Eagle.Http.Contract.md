# WonderTools.Eagle.Http.Contract

WonderTools.Eagle.Http.Contract details the communication between Eagle Dashboard and Eagle Node using Http. The current and the only version of WonderTools.Eagle.Http.Contract is 1.1.0

The below picture gives an overview of the communication between Dashboard and the client using WonderTools.Eagle.Http.Contract.

![WonderTools Eagle Http Contract](https://raw.githubusercontent.com/WonderTools/Eagle.Documentation/master/http-contract.JPG)

The communication has 3 parts to it.
1. Triggering the test by the Dashboard
2. Posting the partial test report by the Node
3. Responding to the test trigger request with the full test report by the Node.

