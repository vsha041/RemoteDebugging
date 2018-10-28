#Run this command to generate model classes from the DB

Scaffold-DbContext "Server=localhost;Database=Temp;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context ProductDbContext

#Run this command to update model classes from the DB
Scaffold-DbContext "Server=localhost;Database=Temp;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context DemoDbContext -Force
