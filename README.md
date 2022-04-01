# _AnimalApi_

####  _**Chase Stokes**_

#### _An api project, to practice building apis with dotnet._

## Technologies Used

* _Visual Studio Code_
* _C#_
* _ASP.NET Core MVC_
* _MySql_
* _MySqlWorkbench_
* _Markdown_
* _EntityCore_
* _Swagger_
* _Postman_

## Description

_An epicodus project using .net to create an api, and practice with creating endpoints._


## Setup/Installation Requirements


* _[Visual Studio Code](https://code.visualstudio.com/?msclkid=e76fe139b1fd11eca54107c3b437fe4e)_
* _[MySqlWorkbench](https://dev.mysql.com/downloads/workbench/)_
* _Optional [Postman](https://www.postman.com/?msclkid=25d9461cb1fe11ec9745e337fbafb304)_

* _You can find the github repository [here](https://github.com/ChaseStokes/AnimalApi.Solution)_
* _Copy the URL/https link_
* _In git bash or your preferred git terminal navigate to the directory you would like to store the project_
* _Enter: ```git clone``` followed by the https link_
* _Now that the repository is cloned to your computer, right click on the folder and click open with vs code_

## Datebase Instructions

_**In order to access a usable version of the sql database you will need to do the following:**_

* _Create a file named appsettings.json in the AnimalApi directory_
* _The file should contain this block of code except with your own username and password for the server(brackets around private information not included):_
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[database_name];uid=root;pwd=[your_workbench_password];"
  }
}
```
* _Navigate to the AnimalApi directory_
* _Run the command ```dotnet restore```_
* _Run the command ```dotnet build```_
* _Run the command ```dotnet ef database update```_


*_To interact with the api in postman, run the command  ```dotnet run```_

## API Documentation

_**You can explore the API endpoints in postman**_

_**You can view all of the endpoints with swagger, by using ```dotnet run``` in your terminal, and input ```https://localhost:5001/swagger/index.html```**_

_**Endpoints**_

_**Request Structure**_


```
--Version One--
Get /api/animals/
Post /api/animals/
Get /api/animals/{id}
Put /api/animals/{id}
Delete /api/animals/{id}
```
```
--Version Two--
Get /api/2.0/animals/
Post /api/2.0/animals/
Get /api/2.0/animals/{id}
Put /api/2.0/animals/{id}
Delete /api/2.0/animals/{id}
Get /api/2.0/animals/random
```
```
--No Versioning--
Get /api/parks/
Post /api/parks/
Get /api/parks/{id}
Put /api/parks/{id}
Delete /api/parks/{id}
```

_**Example Query**_

```http://localhost:5000/api/2.0/animals?age=3&species=cat```

_**Sample Reponse of Query**_

```
[
    {
        "animalId": 1,
        "species": "cat",
        "name": "chihiro",
        "breed": "shorthair",
        "sex": "female",
        "age": 3
    },
    {
        "animalId": 3,
        "species": "cat",
        "name": "perchik",
        "breed": "longhair",
        "sex": "male",
        "age": 3
    }
]
```


## Known Bugs

* _No known bugs_

## License - [MIT](https://opensource.org/licenses/MIT)

_If you have any feedback or concerns, please contact me by email at chasehstokes@gmail.com with details._

Copyright (c) _2022_ _Chase Stokes_