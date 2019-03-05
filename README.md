# testapi

## Running locally

### Server
1) Run the recreatedatabase.cmd script in the scripts folder.  This will create a database called "TestApi_db" in (localdb)\MSSQLLocalDB with seed data.

2) Run the TestApi project from visual studio. This will start a localserver at https://localhost:44359/ 

### Client
1) "npm i" to install depenedencies
2) "ng serve -o" to run the application and open a browser page on http://localhost:4200/

## Running the tests

### Server
Run the tests contained within the TestApi.Tests projects from the Visual Studio Test Explorer.

### Client
To use Jest:
1) "npm i" to install dev dependencies
2) npm test
