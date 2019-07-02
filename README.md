# Eagle

## What is Eagle?
Eagle is a system designed to provide a high level view of your web services. It's designed to provide you quick information what apects of your distributed computing system is working and not working.

## Eagle Concepts
Eagle is a system that is tests and monitor a distributed cloud computing system. Eagle by iteself is a distributed system. Its made up of a dashboard and variable number of nodes.

### Eagle Dashboard
This is a web application. This lets the user know about all the tests that are available in the eco system. It also has a mechanism of scheduling a single test or a collection of tests organized as test suite.

### Eagle Node
A Eagle node is test/monitoring code deployed to provide insights about a small aspect of the system. The eagle node could be deployed as a web service or a serverless function  (AWS lambda or Azure Function, etc). Or it could be part of your productive service as well. When a Eagle Node is introduced (deployed) in the system, it is registered with the Eagle Dashboard. The Eagle node and Eagle Dashboard communicated with each other using the standardized way called as Eagle Communication Contract.

### Eagle Communication Contract
This is a standardization of communication between Eagle Node and Eagle Dashboard. The communication between Dashboard and Node could in using different technologies such as HTTP or AMQP or anthing else. So there are could be different Eagle Communication Contracts. Currently the communication over HTTP is defined and this is called "WonderTools.Eagle.Http.Contract".

#### WonderTools.Eagle.Http.Contract
The communication contract to communicated over http between dashboard and nodes

