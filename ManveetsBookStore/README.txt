﻿﻿Author Name: Manveet Kaur
Program Name: ManveetKaursBookStore
Student ID: W0782002
Date created: 2022/03/22
Purpose of the project: To learn about creating ASP.NET Core MVC application

2022/03/22
05:00PM
New Project ASP.NET Core Web App(Model-View-Controller)
AUTHENTICATION TYPE IS INDIVIDUAL ACCOUNTS!!

Made the base of the project... the major difference between this and the older project was this one had a folder named AREAS.
When the project was run, a local host with the URL https://localhost:44344/ was created.
The code for "RESISTER" and "LOG IN" pages were already there. 

Always "CLAEAN" and "BUILD" the file before running it everytime.
Just a safe side!!

05:10PM
Created a new GitHub repository and pushed the data.

05:33PM
Added a new theme using the bootstrap.css which I downloaded from https://bootswatch.com/
I picked Sketchy as my theme.
Made changes in the site.css with the file provided.
made few changes in _Layout file and _LoginPartial file to work with the theme
Updated and build the project. Ran the project to review the changes.
IT WORKED!!
added given links from the provided links of stylesheets and scripts to the _Layout file .

05:40PM
Added a dropdown to the NavBar

06:07PM
Added three new class library which are
ManveetKaursBooks.DataAccess
ManveetKaursBooks.Models
ManveetKaursBooks.Utility

deleted the auto generated classes and installed new packages in .DataAccess
Microsoft.AspNetCore.Identity.EntityFrameworkCore with Version=5.0.14
Microsoft.EntityFrameworkCore.Relational with Version=5.0.14
Microsoft.EntityFrameworkCore.SqlServer with Version=5.0.14

Changed the location of the Data file to .DataAccess and deleted few files.

06:20PM
Changed the location of the Model file from base project to .Models class library
Added the project references to the main project of .DataAccess and .Model
Made changes in the file.
BULID SUCCEEDED!!!!

06:34PM
!!!GOT ERRORS!!!
using the bildin-fuctions the errors were removed.

06:39PM
Created a static details class called SD.cs in .Utility
modified the properties of the class.
Added the project references to the main project of all the class libraries.
Added the project references to the .DataAccess of .Utility and .Model

06:44PM
In the Areas folder added a new Area named 'Customer'
changed the route in Startup.cs. Moved and eddited few files.
When the page was run, my theme was removed and only welcome screen was shown.
Located _viewImport and _ViewStart to customer area.

PAGE WORKES PROPERLY!!

06:51PM
In the Areas folder added a new Area named 'Admin'
Edited the folder. 
Added brief info in ReadMe.txt which i will elaborate in the morning
Udated the GitHub repo.

2022/03/23
11:28AM
Explained each part in README.txt so that I can remember how and what I did in this project.
Ran the page one last time before showing it to professor and it works!!

2022/03/25
01:16AM
Staring with Part 2 of Assignment 2. Updating the README.txt file and building the solution before working on the assignment.
Ran the WebPage and see if there is any errors or no.

01:18AM
edited the .json file to make the changes as required
add-migration AddDefaultIdentityMigration
20220418214102_AddDefaultIdentityMigration
update-database

add-migration AddCategoryToDb

2022/03/28
11:50AM
added 4 different repos and thier interfaces
CategoryRepository.cs, Repository.cs,SP_Call.cs and UnitOfWork.cs
and there repective interfaces where of same name with I in front of them.

1:20PM
Added data to the repos creted as per requirement so that the project should run.
few of the files are not given due to which the assignment cannot be completed.!

2022/03/29
Getting error with IUnitOfWork.cs and UnitOfWork.cs which is why I cannot continue the project
Asking Prof for help!!

2022/03/30
added interface in front of the errors and the webpage works fine.
Bulid the solution and had no errors
Build started...
========== Build: 0 succeeded, 0 failed, 4 up-to-date, 0 skipped ==========

PM> update-database
Build started...
Build succeeded.
Done.

Editted the readmen file and uploaed to GitHub


2022/04/05
01:45PM
improving previous errors

02:04PM
made same nessary changes to make my site apealing

02:37PM
changes and now moving forward

02:57PM
_Layout changes

03:36PM
AFTER LUNCH BREAK
category.js

Part 2 done