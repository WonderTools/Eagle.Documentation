# Eagle

## What is Eagle?
Eagle is a system designed to provide a high level view of your web services. It's designed to provide you quick information what apects of your distributed computing system is working and not working.

## Eagle Concepts
Eagle is a system that is tests and monitor a distributed cloud computing system. Eagle by itself is a distributed system. Its made up of a dashboard and variable number of nodes.

![Block Diagram of Eagle](https://raw.githubusercontent.com/WonderTools/Eagle.Documentation/master/block-diagram.JPG)

### Eagle Dashboard
This is a web application. This lets the user know about all the tests that are available in the eco system. It also has a mechanism of scheduling a single test or a collection of tests organized as test suite.

### Eagle Node
A Eagle node is test/monitoring code deployed to provide insights about a small aspect of the system. The eagle node could be deployed as a web service or a serverless function  (AWS lambda or Azure Function, etc). Or it could be part of your productive service as well. When a Eagle Node is introduced (deployed) in the system, it is registered with the Eagle Dashboard. The Eagle node and Eagle Dashboard communicated with each other using the standardized way called as Eagle Communication Contract.

### Eagle Communication Contract
This is a standardization of communication between Eagle Node and Eagle Dashboard. The communication between Dashboard and Node could in using different technologies such as HTTP or AMQP or anthing else. So there are could be different Eagle Communication Contracts. Currently the communication over HTTP is defined and this is called "WonderTools.Eagle.Http.Contract". These communication contracts are designed to evolve over time to meet the demands, so they are versioned. While implementing Eagle, we should ensure that all the dashboards and all the nodes talk using the same version of the same communication contract.

#### WonderTools.Eagle.Http.Contract
The communication contract to communicate over http between dashboard and nodes. More details can be found [here](https://github.com/WonderTools/Eagle.Documentation/blob/master/WonderTools.Eagle.Http.Contract.md#wondertoolseaglehttpcontract)

## Implementing Eagle System
Implementing a Eagle System involes deploying a Eagle Dashboard, and at least one Eagle node. There are libraries that are available facilitate in the implementation of Eagle system. These libraries are developed such that when installed in  your application, you need to focus on only the business aspect of the testing and eaglizing it is taken care. The packages available are [here](https://github.com/WonderTools/Eagle.Documentation/blob/master/ListOfPackages.md#list-of-package-for-building-eagle-components)
