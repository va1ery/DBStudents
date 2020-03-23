"# DBStudents" 

Commands to create Model:
>dotnet add package Microsoft.EntityFrameworkCore.Sqlite
>dotnet add package Microsoft.EntityFrameworkCore.Design
>dotnet ef dbcontext scaffold "Data Source=DBStudents.db" Microsoft.EntityFrameworkCore.Sqlite -o Models

Commands to create database:
>dotnet ef migrations add InitialCreate
>dotnet ef database update