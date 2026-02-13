# Todo List Backend API (.NET 8)

Repository ini berisi implementasi REST API untuk aplikasi Todo List berbasis .NET 8 yang saya kerjakan sebagai bagian dari persyaratan Technical Test Backend Intern. API ini dikembangkan menggunakan ASP.NET Core Web API dengan Entity Framework Core serta menggunakan SQLite sebagai database.

---

## Tech Stack

- **Framework:** .NET 8 (ASP.NET Core)
- **Database:** SQLite
- **ORM:** Entity Framework Core
- **Documentation:** Swagger UI

---

## Getting Started

## Ikuti langkah-langkah berikut untuk menjalankan project ini di local.

### 1. Clone Repository

```bash
git clone https://github.com/hasnamaytanaya/hasnamaytanaya_todolist.git
cd hasnamaytanaya_todolist
```

---

### 2. Install Dependencies & Setup Database

Project ini menggunakan SQLite. Anda perlu melakukan restore package dan update database (_migration_) agar file `todos.db` terbentuk otomatis.

#### Restore NuGet Packages

```bash
dotnet restore
```

#### Install EF Core Tools (Jika Belum Ada)

```bash
dotnet tool install --global dotnet-ef
```

#### Update Database (Generate todos.db)

```bash
dotnet ef database update
```

---

### 3. Run Application

```bash
dotnet run
```

Jika berhasil, terminal akan menampilkan output seperti berikut:

```bash
Building...
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5xxx
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
```

---

### 4. Buka Dokumentasi API (Swagger)

Setelah aplikasi berjalan, buka browser dan akses:

```bash
http://localhost:5xxx/swagger
```

> 📌 Ganti `5xxx` dengan port yang muncul pada terminal
> Contoh: `http://localhost:5020/swagger`

---

## 📌 API Endpoints Reference

| Method | Endpoint                   | Deskripsi                              |
| ------ | -------------------------- | -------------------------------------- |
| GET    | `/api/todos`               | Mengambil semua daftar Todo            |
| GET    | `/api/todos/{id}`          | Mengambil detail Todo berdasarkan ID   |
| POST   | `/api/todos`               | Membuat Todo baru                      |
| PUT    | `/api/todos/{id}/complete` | Mengubah status Todo menjadi Completed |
| DELETE | `/api/todos/{id}`          | Menghapus Todo                         |

---

## Contoh Request

### Create Todo

```http
POST /api/todos
Content-Type: application/json
```

```json
{
  "title": "Belajar ASP.NET Core Web API"
}
```

---

## Contoh Response (Success)

```json
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "title": "Belajar ASP.NET Core Web API",
  "isCompleted": false,
  "createdAt": "2026-02-13T10:00:00.000Z"
}
```

---

## Project Structure

```bash
hasnamaytanaya_todolist/
├── Controllers/
│   └── TodoController.cs    # Logic API Endpoint
├── Data/
│   └── AppDbContext.cs      # Konfigurasi Database (EF Core)
├── Migrations/
│   └── ...InitialCreate.cs  # History Skema Database (EF Migration)
├── Models/
│   └── Todo.cs              # Entity / Schema Database
├── appsettings.json         # Connection String SQLite
├── Program.cs               # Main Entry Point & Services
└── README.md                # Dokumentasi Project

```
