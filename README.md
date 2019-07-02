# Eagle

## What is Eagle?
Eagle is a system designed to provide a high level view of your web services. It's designed to provide you quick information what apects of your distributed computing system is working and not working.

## Eagle Concepts
Eagle is a system that is tests and monitor a distributed cloud computing system. Eagle by iteself is a distributed system. Its made up of a dashboard and variable number of nodes.

### Eagle Dashboard
This is a web application. This lets the user know about all the tests that are available in the eco system. It also has a mechanism of scheduling a single test or a collection of tests organized as test suite.

### Eagle Node
A Eagle node is test/monitoring code deployed to provide insights about a small aspect of the system. The eagle node could be deployed as a web service or a serverless function  (AWS lambda or Azure Function, etc). Or it could be part of your productive service as well. 
