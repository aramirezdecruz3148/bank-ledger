# 💰 Bank Ledger Console Application 💰
For my first C# application I created a simple bank ledger cli that can:

* Create a new account
* Login
* Record a deposit
* Record a withdrawal
* Check balance
* See transaction history
* Log out

## Running the Program
I used ```dotnet``` to create: ```dotnet new console``` and run: ```dotnet run``` the build. To keep the application simple and free of a database,
user/transaction information is written to an xml file within the build: ```bank-ledger:\bank-database.xml```. You can run the program and
sign-in with the existing user in the xml file database to test the functionality, or create a new user.

## Improvements
As this is my first C# application, there are plenty of improvements that I would like to make, including:
* Adding a testing suite 
* Creating logic to protect against false/incorrect user input
* Review syntax and casing standards/practises for C# and ensure I am employing them
* Create a UI for the application and be able to run it both on the web and in the console
* Streamline some of the xml read/write code into separate methods
* As of now, you can only create and sign-in a single user, each time a new one is created it will override the previous in the xml file.
Ideally, I would love to solve this so the xml file can store a record of multiple users. Perhaps through implementing a Session class that 
would employ the sign-in/log-out methods and apply any actions (deposit, withdrawl, etc) only to the currently logged-in user
