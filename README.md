# GusStoreSln
Pro ASP.NET 3 SportStore Tutorial


## Create Solution and Projects

    dotnet new globaljson --sdk-version 3.1.101 --output GusStoreSln/OutdoorProducts
    dotnet new web --no-https --output GusStoreSln/OutdoorProducts --framework netcoreapp3.1
    dotnet new sln -o GusStoreSln
    dotnet sln GusStoreSln add GusStoreSln/OutdoorProducts 
    dotnet new xunit -o GusStoreSln/OutdoorProducts.Tests --framework netcoreapp3.1
    dotnet sln GusStoreSln add GusStoreSln/OutdoorProducts.Tests 
    dotnet add GusStoreSln/OutdoorProducts.Tests reference GusStoreSln/OutdoorProducts 

## Chapter 7 ASP.NET Core 3 - Screenshot #1
![LAB 1B - SportsStore-A Real Application (in-class)](https://user-images.githubusercontent.com/20195657/92675375-148d1400-f2d4-11ea-9e5c-6d8ea4e3f430.PNG)

***

## End of Chapter 7 ASP.NET Core 3 - Screenshot #2 
![LAB 1B - SportsStore-A Real Application (in-class)(1)](https://user-images.githubusercontent.com/20195657/93005843-f3156d80-f509-11ea-8e71-191ed4e09872.PNG)

***

## Chapter 8 ASP.NET Core 3 - Select Category Screenshot

![LAB 2A - SportsStore-Navigation(ch8-CategorySelect)](https://user-images.githubusercontent.com/20195657/93552010-3580e500-f924-11ea-9b74-0d61dea7b029.PNG)

***

## Your Cart page Screenshot
![LAB 2A - SportsStore-Navigation(ch8-YourCart)](https://user-images.githubusercontent.com/20195657/93552024-3b76c600-f924-11ea-99a4-32f1cadf3fd0.PNG)

***

## Unit-Tests Screenshot
![LAB 2A - SportsStore-Navigation(ch8-tests)](https://user-images.githubusercontent.com/20195657/93552031-3f0a4d00-f924-11ea-84a2-32e320e3de68.PNG)
