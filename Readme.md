### Steps demonstrated
1. `docker run --name postgres-zoo -e POSTGRES_PASSWORD=mysecretpassword -p 5432:5432 -d postgres`
2. `dotnet ef migrations add InitialCreate`
3. `dotnet ef database update`
4. `dotnet ef migrations add AddOrderToAnimal`
5. `dotnet ef database update`