# Để chạy project cần copy bên dưới để cài đặt các công cụ EF và package trong Terminal (View > Terminal) hoặc console (Tools > NuGet > Console)
## Đây là project AspNet Core 6.0 (chỉ chạy được trên vs *2022* có modify ASP.NET and Web development) 
## Lưu ý nếu lỗi có thể thử:
- Bấm **Clear all NuGet Storage** để xóa hết package ( Tools > NuGet > Setting > General)
- Check sql sever xem đã có AgentManagerDb chưa, nếu chưa hãy chạy lệnh này **dotnet ef database update**

## Copy dưới đây
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

Copy tới dòng này luôn không thì phải enter mới chạy được lệnh cuối
