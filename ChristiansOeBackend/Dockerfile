FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ChristiansOeBackend/ChristiansOeBackend.csproj", "ChristiansOeBackend/"]
RUN dotnet restore "ChristiansOeBackend/ChristiansOeBackend.csproj"
COPY . .
WORKDIR "/src/ChristiansOeBackend"
RUN dotnet build "ChristiansOeBackend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ChristiansOeBackend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ChristiansOeBackend.dll"]
