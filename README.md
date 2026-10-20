# SchoolABJ

موقع مدرسة علي بن جاسم الثانوية — Ali Bin Jassim Bin Mohammad Al Thani Secondary School for Boys

**Live site (GitHub Pages):** https://khalidosh2025.github.io/SchoolABJ/

---

## Repository contents

| Path | Description |
|------|-------------|
| `SchoolABJ.sln` | Visual Studio 2022 solution |
| `SchoolABJ/` | ASP.NET Core **Blazor Server** project (`net8.0`, `Microsoft.NET.Sdk.Web`) |
| `SchoolABJ/Pages/` | Razor pages — `Home.razor` (public site), `Login.razor`, `Index.razor`, `ClassVisitsTabs.razor` |
| `SchoolABJ/Shared/` | Layouts, navigation menu, tab state |
| `SchoolABJ/Data/` | `EmpService.cs` (SQL Server access), weather services |
| `SchoolABJ/wwwroot/` | Static assets — CSS, JS, images, video, fonts |
| `docs/` | The **static** build published to GitHub Pages |

## The application (Blazor Server)

The real application is a server-side Blazor app backed by SQL Server:

```bash
cd SchoolABJ
dotnet restore
dotnet run
```

Update the connection string in `SchoolABJ/appsettings.json` before running against a database.

Publish for a web server with:

```bash
dotnet publish -c Release -o publish
```

## GitHub Pages

GitHub Pages can only host static content, so the `docs/` folder contains a
**static** version of the site: the public home page and login screen, with all
CSS / JS / images / video from `wwwroot/`. Asset paths were rewritten to be
relative to the `/SchoolABJ/` base path.

Pages is served from the `main` branch, `/docs` folder.

```bash
# after changing the site, refresh the static copy in docs/
# then push - GitHub Pages rebuilds automatically
```

## Stack

- ASP.NET Core Blazor Server (.NET 8)
- Dapper + Microsoft.Data.SqlClient (SQL Server)
- Bootstrap 4, jQuery, Font Awesome, Owl Carousel, Slick Slider
