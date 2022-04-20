﻿﻿Author Name: Manveet Kaur
Program Name: ManveetKaursBookStore
Student ID: W0782002
Date created: 2022/04/18
Purpose of the project: To learn about creating ASP.NET Core MVC application

************************
************************
!!PART 1!!
************************
************************

2022/04/18
04:43PM
Making the project 4th time as I got errors 3 times.
New Project ASP.NET Core Web App(Model-View-Controller)
AUTHENTICATION TYPE IS INDIVIDUAL ACCOUNTS!!

Made the base of the project... the major difference between this and the older project was this one had a folder named AREAS.
When the project was run, a local host with the URL https://localhost:44344/ was created.
The code for "RESISTER" and "LOG IN" pages were already there. 

Always "CLAEAN" and "BUILD" the file before running it everytime.
Just a safe side!!

04:47PM
Created a new GitHub repository and pushed the data.

04:52PM
Edited the startup as it was asked.
Added a new theme using the bootstrap.css which I downloaded from https://bootswatch.com/
I picked Sketchy as my theme.

04:55PM
Made changes in the site.css with the file provided.

04:58PM
made few changes in _Layout file and _LoginPartial file to work with the theme
Updated and build the project. Ran the project to review the changes.
IT WORKED!!

05:02PM
added given links from the provided links of stylesheets and scripts to the _Layout file .

05:04PM
Added a dropdown to the NavBar

05:07PM
Added three new class library which are
ManveetKaursBooks.DataAccess
ManveetKaursBooks.Models
ManveetKaursBooks.Utility

deleted the auto generated classes and installed new packages in .DataAccess

05:13PM
Microsoft.AspNetCore.Identity.EntityFrameworkCore with Version=5.0.14
Microsoft.EntityFrameworkCore.Relational with Version=5.0.14
Microsoft.EntityFrameworkCore.SqlServer with Version=5.0.14

05:28PM
Changed the location of the Data file to .DataAccess and deleted few files.

Changed the location of the Model file from base project to .Models class library
Added the project references to the main project of .DataAccess and .Model
Made changes in the file.
BULID SUCCEEDED!!!!

!!!GOT ERRORS!!!
using the bildin-fuctions the errors were removed.

05:30PM
Created a static details class called SD.cs in .Utility
modified the properties of the class.
Added the project references to the main project of all the class libraries.
Added the project references to the .DataAccess of .Utility and .Model

05:34PM
In the Areas folder added a new Area named 'Customer'
changed the route in Startup.cs. Moved and eddited few files.
When the page was run, my theme was removed and only welcome screen was shown.
Located _viewImport and _ViewStart to customer area.

PAGE WORKES PROPERLY!!

05:37PM
In the Areas folder added a new Area named 'Admin'
Edited the folder. 
Added brief info in ReadMe.txt which i will elaborate in the morning
Udated the GitHub repo.

************************
************************
!!PART 2!!
************************
************************

05:39PM
Staring with Part 2 of Assignment 2. Updating the README.txt file and building the solution before working on the assignment.
Ran the WebPage and see if there is any errors or no.
edited the .json file to make the changes as required

05:41PM
add-migration AddDefaultIdentityMigration
20220418214102_AddDefaultIdentityMigration
update-database

05:49PM
Added the category class and added data to it

6:00PM
add-migration AddCategoryToDb
but the migration was empty,
Added a line in the ApplicationDbContext in .DataAccess and then added the migration again
this time there was data and when I verified the table, I could see it in the SQL Explorer
Updated the Database

PM> update-database
Build started...
Build succeeded.
Done.

06:20PM 
Took a break!!!!

07:57PM
Back to coding....
Created a new folder in .DataAccess named Repository and it had another folder named IRepositroy

In IRepository 4 Interface were created naming
ICategoryRepository.cs
Repository.cs
SP_Call.cs
UnitOfWork.cs

each interface had indiviual Classes in Repository file naming:
CategoryRepository.cs
Repository.cs
SP_Call.cs
UnitOfWork.cs

08:08PM
added a line in Startup which will refer the file UnitOfWork and IUnitOfWork
Cleaned the solution and build it.

Build started...
========== Build: 0 succeeded, 0 failed, 4 up-to-date, 0 skipped ==========

08:14PM
In the main project, Areas<Admin<Controllers
CategoryController was created and edited as expected.
Reviwed the website given by prof. to correct my previous errors.

08:15PM
In the same admin folder a new folder was created and named Category
Added the new Index file and added data in it to make the site apealing

TOOK DINNER BREAK!!!
09:48PM
Made the changes in the navigation bar in layout file so with the click the website opens.

09:57PM
added the new Js file naming category.js 

10:04PM
A new Category Upsert View page is created where I can add new categories.
did some editing.

10:04PM
In the main project Views<Shared
_CreateAndBackToList and _EditAndBackToList button was created 
did some major edditing in many files to enable those buttons 
Added the validation
Added the alert message to ask the confirm of deleting the category
When Ok option is selected the new dialog box is displayed on top-right corner of the website saying the data has been deleted.

10:13PM
Checked my website for any errors
Cleaned and Bulid the project
Ran the webisite once before uploding it 

************************
************************
!!PART 3.1!!
************************
************************

11:22PM
PM> add-migration AddProductToDb
Build started...
Build failed.

tried many times but could not find the reason for errors and then I build the project
18 errors
corrected each error
and then again tried to apply the migration but failed 
build again and found one more error

I was about to get panic attack if it would have failed again but 
luckly i saw this command
PM> add-migration AddProductToDb
Build started...
Build succeeded.
To undo this action, use Remove-Migration.

!!THANK GOD!!

11:47PM
20220419034436_AddProductToDb

11:49PM
PM> update-database
Build started...
Build succeeded.
Done

verified the table made in SQL Explorer

PM> add-migration AddValidationToProduct
Build started...
Build succeeded.
To undo this action, use Remove-Migration.

PM> update-database
Build started...
Build succeeded.
Done.

Rebuild the solution and uploaded to github
========== Rebuild All: 4 succeeded, 0 failed, 0 skipped ==========

************************
************************
!!PART 3.2!!
************************
************************

2022/04/19
12:09AM
Updated the Readme file to eleborate what I have been doing in this assignment.
staring the part 3.2


Before starting the next part Cleaned and Bulid the Solution one more to check for any errors
========== Build All: 4 succeeded, 0 failed, 0 skipped ==========

12:40AM
Added Product Controller and CoverType Controller in the Areas>Admin>Controller to perform the CRUD operations.
Added the IWebHostEnironment call and its using statement

12:41AM
Create a ViewModel in the Models project to hold the Product object and select list for Category and CoverType
Modified the ProductVM class so it is public and installed the .Mvc.ViewFeatures pakage.

12:43AM
Added an Index View, Copied the data from The previous file and editied it a bit.
added CoverType.js, product.js
Modified the _Layout.cshtml to add a new link to Product.
Run the application and I could see the Product Table 

Part 3.2 done
Jumping to part part 3.3

************************
************************
!!PART 3.3!!
************************
************************

12:47AM
Created the Upsert .cs in Products and Modify in Areas>Admin>Views>Product
Added a rich text are inside Product with tiny.cloud

12:48AM
added the new Product folder and this folder will have images of each book that will be displayed on the homepage.
In the ProductController congigured the Product Uperst Post action

01:07AM
Checked for the errors.
Ran the application and test
My Index page is not working getting errors

01:15AM
added the data in the ReadMe file.

01:49AM
Did the changes as much I could do but my Index page would still not work.
Its late night right now. Planning on doing it tommorow.
would be conutinuing my project in the morning.
!!Good Night!!

************************
************************
!!PART 4!!
************************
************************
Had a wonderful night and after my routine sat on the table and working on the project.

12:49PM
verified each file in project and checked for any errors
In the main project, Admin<Controller
found few errors and fixed it

12:54PM
in the Area<Customer<View and in Admin<View
there were few lines missing and with the referance of the link provided by the prof.
corrected the files

01:03PM
in the View folder there was an error in the index page
fixed it!!!

01:14PM
Accidently added the ProductRepository.cs in the IRepository rather than in outer folder with other classes
As the File location changed, there had to be changes in the file as well

!! Had a emergency as I had to go to the Medical Clinic at the college for personal reason!!
would return back as soon as possible and work on project....

02:57PM
The main index page was not working propetrly had I was asked to display Product database on the Home Page
but once I checked evry file once again and build the project. I did not see any server errors.

03:28PM
Build the project with no errors.
Logged into the site and added the category list and Cover type list
Using the refernce of the other website, I gathered information about the three books
Added the database in my application
I could see the 3 books together displaying the information as per the need.
The website works perfectly fine

03:49PM
Added the Outside Readme file so I know what this project is about.
Added alot of the data in the README.txt file to elaborate my coding.
Bulid and Cleaned the project
========== Build All: 4 succeeded, 0 failed, 0 skipped ==========
========== Clean: 4 succeeded, 0 failed, 0 skipped ==========

************************
************************
!!PART 5!!
************************
************************
In this part I am asked to submit the link of my GitHub file of the project 
Made the Project Public.

Going to try to Publish my Web App using this link to study from
https://docs.microsoft.com/en-US/visualstudio/deployment/quickstart-deploy-aspnet-web-app?view=vs-2019&tabs=azure
....given by prof....
Not sure about publishing .. would ask prof for help!!!

2022/04/20
02:45PM
did few changes in my file so that is different. I did take help from the Website given But I made few changes at the lst momment to 
make my web page unique

