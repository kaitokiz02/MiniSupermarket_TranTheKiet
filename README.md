# 🛒 HỆ THỐNG QUẢN LÝ SIÊU THỊ MINI THỰC PHẨM CHAY AN LẠC

> **Môn học:** Lập trình Ứng dụng .NET Core (Mã môn: 229162)  
> **Buổi thực hành:** Buổi 1 - Xây dựng Web API quản lý danh mục và kết nối WinForms Client (CRUD)  
> **Phiên bản hiện tại:** Mở rộng quản lý sản phẩm, khách hàng, tài khoản, bán hàng POS và báo cáo doanh thu bằng SQL Server, EF Core, ADO.NET và JWT.

Ứng dụng hỗ trợ quản lý hoạt động bán lẻ tại siêu thị thực phẩm chay An Lạc. Từ chức năng CRUD danh mục ban đầu, dự án được mở rộng thành hệ thống Client - Server gồm Web API xử lý dữ liệu và ứng dụng WinForms phục vụ quản trị, quản lý kho, thu ngân.

---

## 🏗️ 1. Mô hình Kiến trúc Hệ thống (Client - Server)

Solution gồm hai project với trách nhiệm riêng:

* **`MiniSupermarket.API` (Backend):** ASP.NET Core Web API tiếp nhận yêu cầu HTTP, kiểm tra dữ liệu, xác thực người dùng, phân quyền và thực hiện nghiệp vụ với SQL Server.
* **`MiniSupermarket.WinForms` (Frontend Client):** Ứng dụng Windows Forms hiển thị màn hình đăng nhập, quản lý và quầy bán hàng. Client sử dụng `HttpClient` gửi, nhận JSON với API và hiển thị dữ liệu bằng `DataGridView`, biểu đồ, các thẻ thống kê.

```text
Người dùng: Admin / Cashier / Warehouse
                    │
                    ▼
        MiniSupermarket.WinForms
        Đăng nhập · Quản lý · POS · Báo cáo
                    │
                    │ HTTP + JSON
                    │ Authorization: Bearer <JWT>
                    ▼
           MiniSupermarket.API
        Controllers · DTOs · Xử lý nghiệp vụ
                    │
                    │ EF Core / ADO.NET
                    ▼
          SQL Server LocalDB
          Database: AnLacCriteriaDb
```

**Luồng xử lý điển hình:** Người dùng đăng nhập → API kiểm tra tài khoản và trả JWT → WinForms lưu phiên trong bộ nhớ → các yêu cầu tiếp theo gửi kèm token → API kiểm tra quyền, xử lý dữ liệu và trả kết quả.

WinForms truy cập dữ liệu thông qua API. Chuỗi kết nối SQL Server nằm ở Backend.

---

## 🛠️ 2. Công nghệ Sử dụng

| Thành phần | Công nghệ / thư viện | Mục đích |
|---|---|---|
| Ngôn ngữ và nền tảng | C#, .NET 8 | Xây dựng Backend và Client |
| Backend | ASP.NET Core Web API, Controllers | Cung cấp RESTful API |
| Truy cập dữ liệu | Entity Framework Core SQL Server 8.0.11, LINQ | CRUD, tìm kiếm, lọc, phân trang và ánh xạ quan hệ |
| Truy vấn trực tiếp | ADO.NET, `Microsoft.Data.SqlClient` | Tra cứu mã vạch, gọi stored procedure, giao dịch thanh toán |
| Cơ sở dữ liệu | SQL Server LocalDB | Lưu dữ liệu bền vững |
| Quản lý cấu trúc CSDL | EF Core Migrations | Tạo và cập nhật database |
| Xác thực và phân quyền | JWT Bearer, `PasswordHasher<User>` | Cấp token, băm mật khẩu, kiểm tra vai trò |
| Frontend | Windows Forms, `DataGridView`, `TableLayoutPanel` | Giao diện quản lý và bán hàng |
| Giao tiếp HTTP | `HttpClient`, `System.Net.Http.Json`, `async/await` | Gọi API và xử lý JSON bất đồng bộ |
| Biểu đồ | `System.Windows.Forms.DataVisualization` | Biểu đồ cột doanh thu theo ngày |
| Phụ thuộc biểu đồ | `System.Data.SqlClient` 4.9.1 | Cung cấp assembly mà thư viện biểu đồ cần khi chạy |
| Kiểm thử API | Swagger UI, Bearer Authorization | Gọi thử và kiểm tra API |
| Xuất dữ liệu | CSV UTF-8 có BOM | Mở danh sách sản phẩm và hóa đơn bằng Excel |

**Dữ liệu của phiên bản hiện tại được lưu trong SQL Server.** Các thao tác nghiệp vụ sử dụng kết hợp EF Core và ADO.NET.

---

## 📂 3. Cấu trúc Solution

```text
AnLac_RESTful_WebAPI/
│
├── MiniSupperMakert-TranTheKiet.sln       # Solution gồm API và WinForms
├── README.md                            # Tài liệu tổng quan và hướng dẫn chạy
├── README_HUONG_DAN.md                   # Hướng dẫn phiên bản tiêu chí 11–50
├── TIEU_CHI_11_50.md                     # Đối chiếu tiêu chí, kịch bản demo, vấn đáp
│
├── MiniSupermarket.API/                  # Backend ASP.NET Core Web API
│   ├── Controllers/
│   │   ├── AuthController.cs            # Đăng nhập và cấp JWT
│   │   ├── CategoriesController.cs      # CRUD và tìm kiếm danh mục
│   │   ├── ProductsController.cs        # CRUD sản phẩm, phân trang, mã vạch
│   │   ├── CustomersController.cs       # Danh sách, tra cứu và thêm khách hàng
│   │   ├── OrdersController.cs          # Thanh toán và tra cứu hóa đơn
│   │   ├── ReportsController.cs         # Dashboard, doanh thu, top 5, CSV
│   │   └── UsersController.cs           # Tạo tài khoản, đặt mật khẩu, khóa/mở khóa
│   ├── Models/
│   │   ├── Category.cs
│   │   ├── Product.cs
│   │   ├── Customer.cs
│   │   ├── User.cs
│   │   ├── Order.cs
│   │   └── OrderDetail.cs
│   ├── DTOs/                            # Dữ liệu đầu vào/đầu ra của API
│   ├── Data/
│   │   ├── SupermarketDbContext.cs      # DbSet, quan hệ, cấu hình và dữ liệu mẫu
│   │   ├── PracticeDatabase.cs          # Tạo procedure, chuẩn bị tài khoản demo
│   │   └── CheckoutService.cs           # Nghiệp vụ thanh toán trong transaction
│   ├── Database/
│   │   ├── Reports.sql                 # Procedure báo cáo ngày/khoảng ngày
│   │   └── Orders.sql                  # Script SQL hỗ trợ cấu trúc hóa đơn
│   ├── Migrations/                      # Migration ban đầu và ModelSnapshot
│   ├── Properties/launchSettings.json   # Profile chạy và cổng API
│   ├── appsettings.json                 # Chuỗi kết nối, cấu hình JWT
│   ├── appsettings.Development.json     # Cấu hình tài khoản khởi tạo Development
│   └── Program.cs                       # DI, migrations, Swagger và middleware
│
├── MiniSupermarket.WinForms/             # Frontend Windows Forms
│   ├── Program.cs                       # Khởi động tại FormLogin
│   ├── FormLogin.cs                     # Giao diện đăng nhập
│   ├── FormMainShell.cs                 # Sidebar, phân quyền, nhúng form con
│   ├── FormCategoryManagement.cs        # Quản lý danh mục
│   ├── FormProductManagement.cs         # Quản lý sản phẩm và tồn kho
│   ├── FormCustomerManagement.cs        # Quản lý khách hàng
│   ├── FormUserManagement.cs            # Quản trị tài khoản
│   ├── FormPOS.cs                       # Quét mã vạch và giỏ hàng
│   ├── FormPOS.Payment.cs               # Khách thành viên, đổi điểm, tiền thừa
│   ├── FormQuickReport.cs               # Dashboard và biểu đồ doanh thu
│   ├── SessionManager.cs               # Phiên đăng nhập và ApiClientService
│   └── CsvExport.cs                     # Tải và lưu CSV
│
└── verification/
    └── integration.py                   # Script kiểm thử HTTP và nghiệp vụ bán hàng
```

Các form còn có tệp `.Designer.cs` và `.resx` đi kèm để quản lý giao diện, tài nguyên.

---

## ✨ 4. Các Chức năng Chính

### 4.1. Đăng nhập và phân quyền

* Kiểm tra tên đăng nhập, mật khẩu và trạng thái hoạt động của tài khoản.
* Băm, xác minh mật khẩu bằng `PasswordHasher<User>`.
* Cấp JWT có thời hạn 2 giờ, chứa tên đăng nhập và vai trò.
* Lưu token, tên tài khoản, vai trò trong `SessionManager` ở bộ nhớ Client.
* Hiển thị menu và chọn màn hình mặc định theo vai trò.
* Đăng xuất xóa phiên và trở về màn hình đăng nhập.
* API sử dụng `[Authorize]` và `[Authorize(Roles = "...")]` để kiểm tra quyền khi xử lý yêu cầu.

### 4.2. Quản lý danh mục và sản phẩm

* Danh mục: xem danh sách, thêm, sửa, xóa, tìm theo tên.
* Chặn xóa danh mục khi còn sản phẩm thuộc danh mục đó.
* Sản phẩm: quản lý mã vạch, tên, đơn giá, số lượng tồn và nhóm hàng.
* Tìm sản phẩm theo tên/mã vạch và lọc theo danh mục.
* API sản phẩm hỗ trợ `page`, `pageSize`, trả tổng bản ghi qua header `X-Total-Count`.
* Hiển thị tên nhóm hàng trong danh sách sản phẩm.
* Cảnh báo bằng màu đối với sản phẩm có tồn kho **≤ 10**.

### 4.3. Khách hàng và tài khoản

* Xem, tìm khách theo tên hoặc số điện thoại tại Client; thêm khách hàng mới.
* Tra cứu thành viên theo số điện thoại, hiển thị hạng thẻ và điểm thưởng.
* Admin xem danh sách tài khoản, tạo tài khoản, đặt lại mật khẩu, khóa/mở khóa.
* API danh sách người dùng chỉ trả thông tin quản lý tài khoản, không trả mật khẩu hoặc hash.

### 4.4. Bán hàng tại quầy (POS)

* Nhập/quét mã vạch và nhấn **Enter** để thêm sản phẩm.
* Quét lại cùng sản phẩm để tăng số lượng; kiểm tra số lượng với tồn kho.
* Chọn khách thành viên hoặc khách vãng lai.
* Tính tổng tiền, giảm giá từ điểm thưởng, số tiền phải trả và tiền thừa.
* Các nút tiền nhanh đặt số tiền khách đưa: **Vừa đủ**, **50.000**, **100.000**, **200.000**, **500.000**.
* **F8:** đưa con trỏ về ô mã vạch. **F9:** thanh toán.
* Lưu hóa đơn, chi tiết hóa đơn, trừ kho và cập nhật điểm trong cùng một `SqlTransaction`.
* Khi có lỗi trong giao dịch, thực hiện rollback.

**Quy tắc điểm thưởng:**

```text
Tiền giảm giá    = Số điểm đổi × 1.000 đồng
Thực thu        = Tổng tiền hàng − Tiền giảm giá
Điểm nhận thêm  = Phần nguyên của (Thực thu / 10.000 đồng)
Tiền thừa       = Tiền khách đưa − Thực thu
```

Chỉ thành viên mới được đổi/tích điểm. Điểm đổi phải nằm trong số điểm hiện có và không làm giảm giá vượt tổng tiền hàng.

### 4.5. Báo cáo và xuất dữ liệu

* Dashboard gồm: doanh thu hôm nay, tổng số hóa đơn toàn hệ thống, khách mới hôm nay và số sản phẩm tồn kho ≤ 10.
* Biểu đồ cột doanh thu từng ngày trong khoảng ngày được chọn, tối đa 367 ngày tính cả hai đầu.
* Top 5 sản phẩm bán chạy theo tổng số lượng bán trong toàn bộ thời gian.
* Báo cáo ngày và doanh thu sử dụng stored procedure; tính ngày theo giờ Việt Nam UTC+7.
* Xuất sản phẩm, hóa đơn ra CSV UTF-8 có BOM để mở bằng Excel.

---

## 🗄️ 5. Cơ sở Dữ liệu

Database mặc định: **`AnLacCriteriaDb`**, trên instance **`(localdb)\MSSQLLocalDB`**.

| Bảng | Nội dung |
|---|---|
| `Categories` | Nhóm hàng và mô tả |
| `Products` | Mã vạch, tên, giá, tồn kho, danh mục |
| `Customers` | Thông tin thành viên, số điện thoại, hạng thẻ, điểm thưởng |
| `Users` | Tài khoản, hash mật khẩu, vai trò, trạng thái hoạt động |
| `Orders` | Thông tin hóa đơn, thu ngân, tiền hàng, giảm giá, thực thu |
| `OrderDetails` | Sản phẩm, tên tại thời điểm bán, số lượng và đơn giá |

Các quan hệ chính: `Category` có nhiều `Product`; `Order` có nhiều `OrderDetail`; hóa đơn có thể gắn với khách hàng thành viên. Mã vạch, tên đăng nhập và số điện thoại khách hàng có unique index.

Khi API khởi động, `Program.cs` gọi `Database.Migrate()` để áp dụng migration. Bộ dữ liệu khởi tạo gồm **15 nhóm hàng, 45 sản phẩm, 15 khách hàng và 15 tài khoản mẫu**. Trong môi trường Development, các tài khoản mẫu chưa có hash được băm mật khẩu và kích hoạt; tài khoản `admin` được tạo thêm nếu chưa tồn tại và có cấu hình mật khẩu khởi tạo.

---

## 🚀 6. Hướng dẫn Cài đặt và Chạy Dự án

### Bước 1: Chuẩn bị môi trường

* Windows để chạy ứng dụng WinForms.
* Visual Studio 2022 có hỗ trợ .NET 8, cài hai workload **ASP.NET and web development** và **.NET desktop development**.
* .NET SDK hỗ trợ build target .NET 8.
* SQL Server Express LocalDB có instance `MSSQLLocalDB`, hoặc một SQL Server hoạt động được với chuỗi kết nối tương ứng.
* Kết nối đến nguồn NuGet để khôi phục các package khi build lần đầu.

Mở **`MiniSupperMakert-TranTheKiet.sln`**. Các lệnh bên dưới chạy từ thư mục chứa solution, hai project và tệp README này.

### Bước 2: Kiểm tra kết nối SQL Server

Trong `MiniSupermarket.API/appsettings.json`, cấu hình mặc định là:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=AnLacCriteriaDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

Đây là phần cấu hình kết nối được trích ra; giữ các mục cấu hình khác đang có trong tệp. Nếu dùng SQL Server Express hoặc instance khác, thay `Server` và thông tin xác thực cho phù hợp.

Có thể kiểm tra LocalDB bằng PowerShell:

```powershell
sqllocaldb info MSSQLLocalDB
sqllocaldb start MSSQLLocalDB
```

Sử dụng database `AnLacCriteriaDb` theo cấu hình hiện tại. Database cũ `AnLacMiniMarketDb` không được tự chuyển dữ liệu sang; việc chuyển từ database tạo bằng `EnsureCreated` sang migrations cần được xử lý riêng.

### Bước 3: Restore và build solution

```powershell
dotnet restore MiniSupperMakert-TranTheKiet.sln
dotnet build MiniSupperMakert-TranTheKiet.sln --no-restore
```

### Bước 4: Chạy Backend (Web API)

**Trong Visual Studio:**

1. Nhấp chuột phải vào project **MiniSupermarket.API** → **Set as Startup Project**.
2. Chọn profile **http** ở thanh chạy, tương ứng với `Properties/launchSettings.json`.
3. Nhấn **F5** hoặc **Ctrl + F5**.
4. Chờ API khởi tạo database và bắt đầu lắng nghe.
5. Mở Swagger tại [http://localhost:5142/swagger](http://localhost:5142/swagger).

**Hoặc chạy bằng terminal:**

```powershell
dotnet run --project MiniSupermarket.API --launch-profile http
```

| Địa chỉ | Giá trị mặc định |
|---|---|
| Máy chủ API | `http://localhost:5142` |
| Base URL nghiệp vụ | `http://localhost:5142/api/` |
| Swagger UI | `http://localhost:5142/swagger` |
| Đăng nhập | `POST http://localhost:5142/api/auth/login` |

Profile `http` đặt môi trường `Development`, bật Swagger và chuẩn bị tài khoản thực hành.

### Bước 5: Chạy Frontend (WinForms Client)

1. Giữ API đang chạy.
2. Nhấp chuột phải **MiniSupermarket.WinForms** → **Debug** → **Start new instance**.
3. Đăng nhập bằng tài khoản trong mục 7.
4. Kiểm tra màn hình và menu tương ứng với vai trò.

Nếu chạy terminal, mở terminal thứ hai tại thư mục solution:

```powershell
dotnet run --project MiniSupermarket.WinForms
```

Client hiện gọi `http://localhost:5142/api/`. Khi thay cổng API, cập nhật `BaseAddress` tại cả `MiniSupermarket.WinForms/SessionManager.cs` và `MiniSupermarket.WinForms/FormCategoryManagement.cs`.

### Bước 6: Cấu hình chạy đồng thời hai project (tùy chọn)

Trong cấu hình startup của solution, đặt cả API và WinForms ở trạng thái **Start**, chọn profile **http** cho API. API cần khởi động xong trước khi bấm đăng nhập trên Client. Nếu cấu hình cũ còn tham chiếu profile `https`, chuyển sang `http` có trong `launchSettings.json`.

---

## 🔐 7. Tài khoản Thực hành và Phân quyền

Thông tin dưới đây áp dụng với dữ liệu mới khởi tạo trong môi trường **Development**:

| Tài khoản | Mật khẩu mẫu | Vai trò | Màn hình mặc định | Menu WinForms |
|---|---|---|---|---|
| `admin` | `AnLac@2026Demo!` | Admin | Báo cáo | Toàn bộ chức năng |
| `admin01` | `123456` | Admin | Báo cáo | Toàn bộ chức năng |
| `cashier01` | `123456` | Cashier | POS | Bán hàng POS |
| `ware01` | `123456` | Warehouse | Sản phẩm | Danh mục và Sản phẩm |

Các tài khoản mẫu khác: `admin02`, `admin_backup`, `supervisor`, `cashier02` đến `cashier06`, `ware02` đến `ware05`, cùng mật khẩu khởi tạo `123456`.

Mật khẩu khởi tạo của `admin` nằm tại `BootstrapAdmin:Password` trong `appsettings.Development.json`. Thay cấu hình này không đặt lại mật khẩu của tài khoản `admin` đã tồn tại. Tài khoản đã được đổi mật khẩu hoặc khóa sẽ giữ nguyên trạng thái trong database.

Phân quyền API được kiểm tra riêng với menu: API khách hàng cho phép `Admin,Cashier`, dù menu riêng của Cashier hiện chỉ có POS; API hóa đơn cho Cashier xem hóa đơn của chính mình. API báo cáo và quản trị người dùng chỉ dành cho Admin.

---

## 🧪 8. Kiểm thử trên Swagger UI

### 8.1. Đăng nhập lấy JWT

1. Mở Swagger, chọn **POST `/api/Auth/login`**.
2. Nhấn **Try it out** và nhập:

```json
{
  "username": "admin01",
  "password": "123456"
}
```

3. Nhấn **Execute**, kiểm tra phản hồi `200 OK` có `success`, `token`, `role`.
4. Sao chép giá trị `token`, nhấn **Authorize**, dán riêng chuỗi token. Swagger sử dụng scheme HTTP Bearer và tự gắn tiền tố `Bearer`.
5. Gọi thử **GET `/api/Products`** hoặc **GET `/api/categories`**.

### 8.2. Thử CRUD danh mục

Gửi **POST `/api/categories`** bằng quyền Admin hoặc Warehouse:

```json
{
  "categoryName": "Nhóm hàng thực hành",
  "description": "Danh mục dùng để kiểm tra thêm, sửa, xóa"
}
```

Ghi lại `categoryId` vừa tạo. Dùng ID đó để gọi `GET /api/categories/{id}`, `PUT /api/categories/{id}` và `DELETE /api/categories/{id}`. Với PUT, gửi cùng cấu trúc JSON và đổi tên/mô tả. Kiểm tra tìm kiếm bằng `GET /api/categories/search?keyword=thực`.

### 8.3. Thử thanh toán

Tra cứu `GET /api/Products/barcode/000001` để kiểm tra giá và tồn hiện tại, sau đó gửi **POST `/api/orders/checkout`**:

```json
{
  "customerPhone": null,
  "cashReceived": 20000,
  "redeemedPoints": 0,
  "items": [
    {
      "productId": 1,
      "quantity": 1,
      "unitPrice": 15000
    }
  ]
}
```

Ví dụ dùng sản phẩm mẫu `000001`, giá khởi tạo 15.000 đồng. Thay ID/giá theo dữ liệu thực tế nếu đã chỉnh sửa. Giao dịch thành công sẽ tạo hóa đơn và trừ tồn kho thật.

### 8.4. Kiểm tra mã trạng thái HTTP

| Mã | Ý nghĩa / tình huống điển hình |
|---|---|
| `200 OK` | Đọc dữ liệu, đăng nhập hoặc xử lý thành công |
| `201 Created` | Tạo danh mục, sản phẩm hoặc khách hàng thành công |
| `204 No Content` | Cập nhật/xóa danh mục hoặc sản phẩm thành công |
| `400 Bad Request` | Dữ liệu không hợp lệ, thiếu kho/điểm/tiền, xóa nhóm còn sản phẩm |
| `401 Unauthorized` | Thiếu/sai/hết hạn JWT hoặc thông tin đăng nhập không hợp lệ |
| `403 Forbidden` | Đã đăng nhập nhưng không có quyền cho API được gọi |
| `404 Not Found` | Không tìm thấy tài nguyên tương ứng |
| `409 Conflict` | Trùng mã vạch hoặc xung đột được API xử lý |

---

## 🌐 9. Danh sách API Chính

Các đường dẫn dưới đây nối với `http://localhost:5142`. Bảng dùng cách viết thường; Swagger có thể hiển thị `Auth`, `Products`, `Users` theo tên controller.

| Nhóm | Phương thức | Endpoint | Chức năng | Quyền |
|---|---|---|---|---|
| Đăng nhập | POST | `/api/auth/login` | Kiểm tra tài khoản, cấp JWT | Công khai |
| Danh mục | GET | `/api/categories` | Danh sách nhóm hàng | Đã đăng nhập |
| Danh mục | GET | `/api/categories/{id}` | Chi tiết nhóm hàng | Đã đăng nhập |
| Danh mục | GET | `/api/categories/search?keyword=...` | Tìm theo tên | Đã đăng nhập |
| Danh mục | POST / PUT / DELETE | `/api/categories` hoặc `/api/categories/{id}` | Thêm / sửa / xóa | Admin, Warehouse |
| Sản phẩm | GET | `/api/products?search=...&categoryId=1&page=1&pageSize=20` | Tìm, lọc và phân trang | Đã đăng nhập |
| Sản phẩm | GET | `/api/products/{id}` | Chi tiết sản phẩm | Đã đăng nhập |
| Sản phẩm | GET | `/api/products/barcode/{barcode}` | Tra cứu mã vạch bằng ADO.NET | Đã đăng nhập |
| Sản phẩm | POST / PUT / DELETE | `/api/products` hoặc `/api/products/{id}` | Thêm / sửa / xóa | Admin, Warehouse |
| Khách hàng | GET / POST | `/api/customers` | Danh sách / thêm khách | Admin, Cashier |
| Khách hàng | GET | `/api/customers/phone/{phone}` | Tra cứu thành viên | Admin, Cashier |
| Hóa đơn | POST | `/api/orders/checkout` | Thanh toán | Admin, Cashier |
| Hóa đơn | GET | `/api/orders` | Tối đa 100 hóa đơn mới nhất trong phạm vi quyền | Admin, Cashier |
| Hóa đơn | GET | `/api/orders/{id}` | Chi tiết hóa đơn trong phạm vi quyền | Admin, Cashier |
| Báo cáo | GET | `/api/reports/dashboard-summary` | Bốn chỉ số tổng quan | Admin |
| Báo cáo | GET | `/api/reports/daily?date=2026-11-05` | Tổng hóa đơn và thực thu một ngày | Admin |
| Báo cáo | GET | `/api/reports/revenue?from=2026-11-01&to=2026-11-05` | Doanh thu từng ngày | Admin |
| Báo cáo | GET | `/api/reports/best-sellers` | Top 5 sản phẩm bán chạy | Admin |
| Xuất CSV | GET | `/api/reports/export/products` | Danh sách sản phẩm | Admin |
| Xuất CSV | GET | `/api/reports/export/orders` | Danh sách hóa đơn | Admin |
| Tài khoản | GET / POST | `/api/users` | Danh sách / tạo tài khoản | Admin |
| Tài khoản | PUT | `/api/users/{id}/reset-password` | Đặt mật khẩu mới | Admin |
| Tài khoản | PUT | `/api/users/{id}/toggle-lock` | Khóa hoặc mở khóa | Admin |

Với CRUD, POST gọi đường dẫn tập hợp; PUT và DELETE gọi đường dẫn có `{id}`. Phân trang sản phẩm yêu cầu `page ≥ 1`, `1 ≤ pageSize ≤ 500`.

---

## ✅ 10. Kịch bản Thực hành và Kiểm thử

### 10.1. Thao tác trên WinForms

1. **Admin:** đăng nhập `admin01`, kiểm tra màn hình báo cáo và toàn bộ menu.
2. **Danh mục:** thêm nhóm thử, sửa tên, tìm kiếm rồi xóa khi nhóm chưa có sản phẩm.
3. **Sản phẩm:** thêm sản phẩm có mã vạch mới, sửa giá/tồn, tìm tên và lọc danh mục. Đặt tồn kho bằng 10 để kiểm tra màu cảnh báo.
4. **Khách hàng:** tìm một thành viên mẫu, ghi lại số điện thoại và số điểm hiện có.
5. **Cashier:** đăng xuất, đăng nhập `cashier01`; kiểm tra chỉ có menu POS.
6. **Bán hàng:** quét `000001` hai lần. Với giá mẫu 15.000 đồng, tổng là 30.000 đồng; nhập khách đưa 50.000 đồng, kiểm tra tiền thừa 20.000 đồng.
7. **Điểm thưởng:** chọn thành viên trước khi thanh toán. Nếu không đổi điểm, hóa đơn 30.000 đồng được cộng 3 điểm. Ở hóa đơn tiếp theo, đổi 1 điểm để giảm 1.000 đồng.
8. **Kiểm tra sai dữ liệu:** thử giỏ trống, thiếu tiền, quá tồn kho hoặc thiếu điểm; đối chiếu hóa đơn, kho và điểm sau giao dịch thất bại.
9. **Warehouse:** đăng nhập `ware01`, kiểm tra có Danh mục/Sản phẩm và không có menu báo cáo, quản trị tài khoản.
10. **Báo cáo:** Admin chọn khoảng ngày chứa giao dịch vừa tạo, đối chiếu doanh thu thực thu, top sản phẩm và tệp CSV.

Các bước trên là kịch bản kiểm tra cần thực hiện trên dữ liệu chạy thực tế; thao tác bán hàng sẽ thay đổi hóa đơn, tồn kho và điểm.

### 10.2. Script kiểm thử tích hợp

`verification/integration.py` sử dụng Python và thư viện chuẩn để kiểm tra JWT, phân quyền, mã vạch, tìm kiếm, thanh toán, đổi điểm, rollback, báo cáo và CSV.

Script hiện đặt `base = 'http://localhost:5248/api/'`. Để dùng API mặc định ở cổng 5142, sửa dòng `base` trong script thành:

```python
base = 'http://localhost:5142/api/'
```

Giữ API đang chạy rồi thực hiện:

```powershell
python verification/integration.py
```

Script tạo một khách hàng và hai hóa đơn kiểm thử, đồng thời thay đổi tồn kho/điểm. Script giữ dữ liệu sau khi chạy; mỗi lần chạy có thể phát sinh thêm dữ liệu. Dùng database thực hành riêng khi cần kiểm thử lặp lại.

---

## 🔧 11. Một số Lỗi Thường gặp và Cách Xử lý

| Hiện tượng | Cách kiểm tra / xử lý |
|---|---|
| WinForms không kết nối được máy chủ | Chạy API trước, mở Swagger tại cổng 5142; đối chiếu `BaseAddress` của Client với địa chỉ API thực tế. |
| API chạy bằng IIS Express nhưng Client không kết nối | Chọn profile `http` để dùng cổng 5142; IIS Express có cổng riêng trong `launchSettings.json`. |
| Visual Studio chọn profile `https` không còn tồn tại | Chuyển profile của API sang `http`, kể cả cấu hình chạy nhiều project. |
| Đăng nhập `admin` không đúng mật khẩu mẫu | `admin` dùng mật khẩu khởi tạo riêng trong `appsettings.Development.json`; `admin01` mới dùng `123456`. Tài khoản đã đổi mật khẩu giữ mật khẩu trong database. |
| Tài khoản mẫu không đăng nhập được ở lần khởi tạo đầu | Chạy profile `http` ở `Development` để bước băm mật khẩu/kích hoạt dữ liệu mẫu được thực hiện; kiểm tra tài khoản có bị khóa hay không. |
| Thiếu `System.Data.SqlClient, Version=4.6.0.0` sau đăng nhập Admin | Biểu đồ báo cáo cần assembly này. Project WinForms đã khai báo package `System.Data.SqlClient` 4.9.1. Dừng debug, restore NuGet và build lại để thư viện được đưa vào thư mục chạy. |
| Không kết nối được LocalDB | Kiểm tra đã cài LocalDB, instance `MSSQLLocalDB` và quyền kết nối của tài khoản Windows; đối chiếu `DefaultConnection`. |
| Lỗi bảng đã tồn tại khi áp dụng migration | Kiểm tra có trỏ nhầm database cũ tạo bằng `EnsureCreated` hay không; dùng database theo cấu hình hoặc lập kế hoạch chuyển dữ liệu. |
| API trả `401` | Đăng nhập lại và gắn JWT mới; token có thời hạn 2 giờ. |
| API trả `403` | Dùng tài khoản có vai trò được phép; kiểm tra nhóm quyền trong bảng API. |
| Build báo tệp DLL/EXE đang được sử dụng | Dừng phiên debug và đóng ứng dụng đang chạy trước khi build lại. |
| Báo cáo trống | Chọn khoảng ngày có hóa đơn; hệ thống báo cáo theo ngày Việt Nam. Database mới chưa bán hàng có thể chưa có doanh thu. |

Lệnh restore/build lại WinForms:

```powershell
dotnet restore MiniSupermarket.WinForms
dotnet build MiniSupermarket.WinForms --no-restore
```

---


## 👨‍💻 13. Tác giả

* **Họ tên sinh viên:** Trần Thế Kiệt
* **Mã sinh viên:** 2124110132
* **Lớp học phần:** CCQ2411D
* **Môn học:** Lập trình Ứng dụng .NET Core (229162)
* **Đề tài:** Hệ thống quản lý siêu thị mini thực phẩm chay An Lạc
