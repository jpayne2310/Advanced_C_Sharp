# Advanced_C_Sharp
Lab #1 - Structures and Classes
Part 1 – Within the code for our form, we want to create a “Person” structure that contains the following values: First Name, Middle Name, Last Name, Street1, Street 2, City, State, Zip, Phone, Email.  Build a form that includes labels, textboxes, and a button that allows the user to fill out the form and click the button to fill the structure based on the form’s data.  Use a Message Box or “Feedback” Label to confirm that data was stored within a structure variable.
Part 2 – Copy the project from part 1 to a new project called “Class”.  Open the “Class” project. Convert the structure to a class, making all the properties/variables public.  Test to see if this code works fine with the form.  Once the form works fine with the class, go into the button’s click event and make it so that the First Name has the word “Poopy” concatenated with it.  (This is to show you the weakness of developing public properties/variables within classes.
Lab #2
We have two parts of this project:
Part 1 – Using the program from assignment #1, make all the properties of the class “private”.  Can you 
access/change those values within the class anymore?  Why?  Generate the Sets/Gets (Accessors/Mutator methods) that allow us to gather private data from the class as well as allow us to modify class data if the form data is valid.
Part 2 – Move the class definition to a separate Class file.  This will allow us to use it within other C# and ASP.NET projects
Lab #3
1)First and last names are required.
2) bool IsValidLength(string strTemp, int intLength) -> Checks to see if a string is exactly a specified length. (State)
3) bool IsWithinRange(string strTemp, int intMinLen, int intMaxLen) -> Checks to see if the length of the string is within the minimum and maximum lengths allowed. (Country)
4) bool IsWithinRange(int intTemp, , int intMinLen, int intMaxLen) -> Checks to see if the value of the temporay variable is between the minimum and maximum values allowed.
5)  bool IsValidEmail(string strEmail) -> Checks to see if an email is in the valid format that an email address should be in.  (Email)

Lab #4
The basic gist of Assignment #4:
Part 1 – Build a Constructor for your person form class that initializes the zip code textbox to a local zip code by default. Bonus (5 points): Read the default Zip Code from a text file.
Part 2 – Create a new class that inherits from the person class and build appropriate properties, methods, and constructors for this new class.  Add a new property and field, such as Facebook Page.  (It is your choice on what new field you would like to use.)
Part 3 - Most C# applications implement databases for displaying data on the window.  This week, within class we developed a database table that mimics the class/object we developed for the form.  We also added a record in this table using minimal information from the form (First Name and Last Name). Complete the Insert function so that all form/class information is stored within a data record.

SE 255 (Adv. C#) : Mid-Term Project: Fall 2014
You need to build a new windows program to work as an Appointment Manager.  You will need to build a form and a class to manage the following:Start Date and Time (DateTime)Ending Date and Time (DateTime)Who (String, 50)Where (String, 30)Comments (String)The Appointment class file should contain the above as Private properties with Public accessors andmutators.The windows form should utilize textboxes (single line and multi-line) as well as TimeDate Pickers.The Validator class must be used to make sure that the StartDateTime is before the EndDateTime andthat the Who and Where fields cannot be left blank.  All validation feedback should be displayed in aFeedback label.  If all validation criteria is met, you can display the appointment data in the Feedbacklabel instead. (You may need to add a method or two to the Validator class to make all this feasible.)At the end of last week, we just learned the basics of connecting to a DB and adding a record to a table.Implement the code within your Appointment class file to connect to a DB table and add the appointment as a record, if the data is valid.
Option #2:  You need to build a new windows program to work as a Project of Your Choice.  You will need to build a form and a class to manage the data.  You must include at least one instance of each ofthe following variable types:String/TextDateTimeInteger or Double
Assignment #5:        Due: Saturday Week 7

Lab #6
• Create a basic query that gathers all results from a database table
• Create a database query that utilizes form data to narrow the search results• Utilize a DataGrid to display query results
• Utilize the DataGrid’s events and properties to query the database for one specific record
• Utilize a DataReader to populate a form with the results of a single-record query• Understand and explain various uses of the drill-down search process

Because most C# applications implement databases for finding/displaying data, we need a mechanism for pulling up all appropriate data or narrowing down the search, with the intent of narrowing it down from many records to one specific record.  Think of the last time you went to Amazon.com, Ebay, Barnes & Noble, or one of your other favorite online stores.  You may have wanted to find a Star Wars book, but did not know the title, so you
searched for “Star Wars” and now you had a list of items that were related to Star Wars, without having
to sift thru every item on the site.  Then, you scrolled thru the list of items till you found an item that seems to match what you are looking for and click its link to open a new webpage that gives you all the fine details of this one particular item.  We want to do something similar with our project.Create a search page that allows the user to enter some search criteria to narrow down the results to one or a handful.  Within the results, add a link that calls the editor page with the specific ID of the item that you want to view all information on.  When the editor page is opened with and ID attached to it, pull up the specific results and display it within the editor form.
Lab #7
• Create a query that will allow the user to edit and update existing data within a database table
• Create a query that deletes one or more records from a database table.
• Utilize a search query before deleting records in order to reduce errors
• Modify the Graphical User Interface (GUI) through code in order to make the program more
intuitive for the user.
The basic gist of Assignment #6:
Now that we can find data, we may need to update it or possibly delete it.We want to add two buttons and methods that allow the user to either update a record within the editoror delete the current record.Utilize the different form constructors to decide which options (buttons) should be visible to the users atthe appropriate times.

SE 255 (Adv. C#) : Final
Directions:  You need to return to your Mid-Term and continue your work on an AppointmentManager.  You will need to build a form and a class to manage the following:Start Date and Time (DateTime)Ending Date and Time (DateTime)Who (String, 50)Location (String, 30)Comments (String)The Appointment class file should contain the above as Private properties with Public accessors and mutators.  The windows form should utilize textboxes (single line and multi-line) as well as TimeDatePickers. (You can use any valid component to get Dates and Times.)The Validator class must be used to make sure that the StartDateTime is before the EndDateTime and that the Who and Where fields cannot be left blank.  All validation feedback should be displayed in a Feedback label.  If all validation criteria is met, you can display the appointment data in the Feedbacklabel instead. (You may need to add a method or two to the Validator class to make all this feasible.)
NEW MATERIAL:
• Implement the code within your Appointment class file to connect to a DB table and add the
appointment as a record, if the data is valid. (SQL Server)• Create a Drill-Down Search allowing the user to type data in to narrow search results.  
• Allow the user to click a row of the data grid to bring up all of that record’s data in the editor
form.• Allow the user to delete that specific record giving appropriate feedback• Allow the user to Update that record, once validated, giving appropriate feedback• Protect the program by requiring a database-driven login process.• Bonus: (10 points) Use a Combo Box filled with Persons and their ID’s for Appointments.
