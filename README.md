## Chỉ cần cài đặt công cụ EF và package bên dưới trong Terminal (ở thẻ View) hoặc console (cửa Nuget ở thẻ Tools)
# Dự án chạy bằng visual studio

dotnet tool install --global dotnet-ef

dotnet add package Microsoft.EntityFrameworkCore --version 6.0.20

dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.20

dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.20

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration --version 6.0.15

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 6.0.15

dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.20

dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 6.0.20

dotnet add package Microsoft.AspNetCore.Identity.UI --version 6.0.20

dotnet ef database update
