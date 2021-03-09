# TheOfficeFurnitureWarehouse

**Database commands**
* dotnet-ef migrations add initialcreate -s ../TheOfficeFurnitureWarehouse.csproj
* dotnet-ef database update -s ../TheOfficeFurnitureWarehouse.csproj
* dotnet-ef database drop -s ../TheOfficeFurnitureWarehouse.csproj


**Further general improvements:**
* Localization (language and conventions)
* Error messages for the user interface
* Error handling and logging
* Unit tests

**Performance improvements:**
* Implement service and repository methods asynchronously
* Display a progress indicator while the client is waiting for a response from the server