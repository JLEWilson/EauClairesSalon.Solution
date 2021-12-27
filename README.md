# _Eau Claire's Salon_

#### By _**Jacob Wilson**_

#### _An application for keeping track of stylist/client relations._

## Technologies Used

* _HTML_
* _CSS_
* _C#_
* _SQL_
* _MySQL_
* _Markdown_
* _Bootstrap_
* _Razor_
* _HTML Helper_
* _EntityFrameworkCore_


## Description

_An application designed using MVC layout for keeping track of stylist/client relations. The user starts on a splash page welcoming them to the program. From there the user is able to click a link that will rout them to a page containing all stylists, if any clients have been added they will also be able to click a link to view all clients and their respective stylist. Once the page viewing all stylists you will be able to click on a specific stylist to view all of their clients or you will be able to click "Add a stylist" to be routed to a create page containing a form. Once the form is filled out you will be redirected back to the page to view all stylists and the newly created stylist will have been saved into the database and is now loaded in with all the other stylists._

## Setup/Installation Requirements
* _Requires VSCode and MySql_

* _You can find the github repository [here]()_
* _Click the code button, and copy the https link_
* _In your in git bash or your preferred git terminal navigate to the directory you would like to store the project_
* _Enter: "git clone" followed by the https link_
* _Now that the repository is cloned to your computer, right click on the folder and click open with vs code_

_**In order to access a usable version of the sql database you will need to do the following:**_

* _Create a file named appsettings.json in the HairSolon directory_
* _The file should contain this block of code except with your own username and password for the server(brackets around private information not included):_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=jacob_wilson;uid={YOUR USER ID HERE};pwd={YOUR PASSWORD HERE};"
  }
}
```
* _Open MySQL and log into your server_
* _In the "Navigator" panel select the "Administration" tab._
* _Select "Data Import/Restore"_
* _Select "Import from self-contained file" navigate to to the HairSolon directory you cloned above and select jacob\_wilson.sql_
* _In "Default Schema to be Imported to" select new and name the schema jacob\_wilson_
* _NOTE: Make sure you name the file jacob\_wilson or else the project won't locate the correct database_
* _Click Start Import_
* _The schema has now been added! You may need to refresh your databases to see the newly imported database_

* _Now in your terminal run "dotnet restore" to download csproj dependencies._
 * _Once all of the above is completed you can view the project on your local server by running "dotnet run"_

## Known Bugs

* _No known bugs_

## License - [MIT](https://opensource.org/licenses/MIT)

_If you run into any problems or find a bug, would like to reach me for a separate reason, feel free to send me an email @jacobleeeugenewilson@gmail.com with details of your issue._

Copyright (c) _12/26/2021_ _Jacob Wilson(s)_