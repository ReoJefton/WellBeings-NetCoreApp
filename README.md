# WellBeings-NetCoreApp
WellBeings NetCoreApp

Steps to run web app:
1. Download source code zip file, extract it and open the solution in Visual Studio 2019 or clone the repository in Visual Studio 2019.
2. Build solution.
3. In the package manager console run the following commands to run migrations.
      PM> Add-Migration Initial -context WellBeings_NetCoreAppContext
      
      PM> Update-Database -context WellBeings_NetCoreAppContext
4. Run the solution to see the Website in the browser
5. Products page does not have products seed data. Click create button to add data.

Enjoy the Well Beings Ins .Net Core Web App!

