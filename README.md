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

## Screenshot #1
![LAB 1B - SportsStore-A Real Application (in-class)](https://user-images.githubusercontent.com/20195657/92675375-148d1400-f2d4-11ea-9e5c-6d8ea4e3f430.PNG)

***

## Screenshot #2 - End of Chapter 7 ASP.NET Core 3
![LAB 1B - SportsStore-A Real Application (in-class)(1)](https://user-images.githubusercontent.com/20195657/93005843-f3156d80-f509-11ea-8e71-191ed4e09872.PNG)
