# AbySalto technical Task

## Description
   This is a small web app made with C#/ASP.NET as backend
   and Blazor as frontend. There are few web api-s that connect 
   whole project. Api is documented with swagger, tested
   with postman.
   You can see swager documentation after you start project and
   go to url:http://localhost:5074 in your browser.

## Setup
   To startup this app you have to run both 
   Blazor and AbySalto.Junior:http project inside
   solution.

   In JetBrains ryder you can do this by clicking
  Run/Debug configuration -> edit configuration ->
  add new configuration -> Compound 
  (and then you click on projects you need as said before)
   
There is docker-compose.yml file that will run PostgreSQL DB 
so make sure Docker is running before you start up project. If you are going to use some other 
database, make sure DbContext and entities data types are compatible.

## Possible improvments/features 

- Croatian language is hardcoded. It would make much better practice
  to make dictionari with multiple languages and dropdown list for choice.
- Pagination / filters
- Search bar for orders
- custom exceptions / global exceptions
- In case of deployment add User secrets / env. variables
- More order sorting options
- Nicer UI
- Optimization