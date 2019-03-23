


# Installation Instructions
* Ensure that a SQL Server Instance is up and running
* clone the project from the repository and restore all nuget packages
* build the project
* run the application from visual studio and go to the url: http://localhost:49978/Help to view the list of APIs

* to request a token go to http://localhost:49978/token and enter the following parameters as an x-www-form-urlencoded value
	- username
	- password
	- grant_type
	
* to use the token to call an api, enter the token as a value to the Authorization header in this format Bearer [token]
