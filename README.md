# _Claire's Hair Salon_

#### By _**Kai Clausen**_

#### _This will keep track of the stylists and their clients at Eau Claire's Salon._

## Technologies Used

* _C#_
* _/.Net_
* _HTML_
* _CSS_
* _MySQL_
* _MySQL Workbench_
* _Bootstrap_

## Description

_This application was created as an independent project to be submitted for code review to demonstrate basic understanding of databases. The styling was not a priority._

## Setup/Installation Requirements

* _If you do not have C#/.Net, dotnet-script, and MySQL, visit [this page](https://www.learnhowtoprogram.com/c-and-net) and work through the second Pre-Work lesson_
* _Once C#/.Net, dotnet-script, and MySQL are correctly installed and configured, clone down this repository_
* _Navigate to the top directory, labeled ```HairSalon.Solution```_
* _Find the file called ```kai_clausen.sql```, this will be the file that you import into MySQL Workbench._
* _Open MySQL Workbench and follow these instructions on how to import a file, only the Self-Contained File you will be choosing is ```kai_clausen.sql``` and when you name the schema, name it ```hair_salon```_
* _Once your database is set up, you will need to add a file to HairSalon.Solution's root directory_
* _Name the file ```appsettings.json```_
* _Copy and paste the following into this file_

```cs
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

* _Make sure to replace [YOUR-DB-NAME] with ```hair_salon```, [YOUR-USER-HERE] with your userid, and [YOUR-PASSWORD-HERE] with your password_
* _Navigate into HairSalon.Solution/HairSalon in your terminal and enter the following: ```dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0.``` and ```dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0```_
* _Once those commands have been run, you can enter the command in the terminal ```dotnet run``` to launch the application in your browser._
* _When you are finished, exit the browser window and click into your terminal and press Ctrl+C_

## Known Bugs

* _No known bugs_

## License

_MIT - If you encounter any bugs, please feel free to fix them yourself, or contact me at kaiclausen123@gmail.com_

Copyright (c) _2023_ _Kai Clausen_