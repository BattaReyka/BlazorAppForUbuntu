# Используем официальный .NET SDK для сборки приложения
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Копируем файлы проекта и восстанавливаем зависимости
COPY ["PraktikumsAufgabe/PraktikumsAufgabe.csproj", "PraktikumsAufgabe/"]
COPY ["PraktikumsAufgabe.Client/PraktikumsAufgabe.Client.csproj", "PraktikumsAufgabe.Client/"]

RUN dotnet restore "PraktikumsAufgabe/PraktikumsAufgabe.csproj"

# Копируем весь код и публикуем серверный проект
COPY . .
WORKDIR /source/Praktikumsaufgabe
RUN dotnet publish "PraktikumsAufgabe.csproj" -c Release -o /app/publish

# Используем официальный .NET Runtime для запуска
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "PraktikumsAufgabe.dll"]
