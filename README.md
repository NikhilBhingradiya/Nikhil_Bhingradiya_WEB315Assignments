# Nikhil_Bhingradiya_WEB315Assignments
 
* dotnet new webapp -o NikhilsGameathon
* dotnet watch

* dotnet tool install --global dotnet-ef
* dotnet tool install --global     dotnet-aspnet-codegenerator
* dotnet add package Microsoft.EntityFrameworkCore.Design
* dotnet add package Microsoft.EntityFrameworkCore.SQLite
* dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
* dotnet-aspnet-codegenerator razorpage -m Games -dc RazorPagesGamesContext -udl -outDir Pages/Games --referenceScriptLibraries -sqlite
* dotnet ef migrations add InitialCreate