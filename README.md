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

##
