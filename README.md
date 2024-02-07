# WellBeings-NetCoreApp
WellBeings NetCoreApp

Steps to run web app:
1. Download source code zip file, extract it and open the solution in Visual Studio 2019 or clone the repository in Visual Studio 2019.
2. Build solution.
3. In the package manager console run the following commands to run migration Initial(Comment out seed code before doing this - OnModelCreating method in ...\Data\WellBeings_NetCoreAppContext.cs).

         PM> Add-Migration Initial -context WellBeings_NetCoreAppContext
      
         PM> Update-Database -context WellBeings_NetCoreAppContext
   
5. Run the solution to see the Website in the browser
6. Optional step - Products page does not have products seed data. Click create button to add data or run migration Initial2 to seed data(Uncomment out seed code before doing this - OnModelCreating method in ...\Data\WellBeings_NetCoreAppContext.cs).

         PM> Add-Migration Initial2 -context WellBeings_NetCoreAppContext
      
         PM> Update-Database -context WellBeings_NetCoreAppContext
   
Enjoy the Well Beings Ins .Net Core Web App!
<img src="https://github.com/ReoJefton/WellBeings-NetCoreApp/blob/master/WellBeings%20NetCoreApp/wwwroot/images/S1new.png" />
<img src="https://github.com/ReoJefton/WellBeings-NetCoreApp/blob/master/WellBeings%20NetCoreApp/wwwroot/images/S2new.png" />
<img src="https://github.com/ReoJefton/WellBeings-NetCoreApp/blob/master/WellBeings%20NetCoreApp/wwwroot/images/S3new.png" />

