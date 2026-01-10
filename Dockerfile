FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

RUN dotnet tool install --global dotnet-ef --version 8.0.0
ENV PATH="$PATH:/root/.dotnet/tools"

WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

COPY SO.Api/*.csproj SO.Api/
COPY SO.Domain/*.csproj SO.Domain/
COPY SO.Service/*.csproj SO.Service/
COPY SO.Infra/*.csproj SO.Infra/
COPY SO.Shared/*.csproj SO.Shared/

RUN dotnet restore SO.Api/SO.Api.csproj

COPY . .

RUN dotnet build SO.Api/SO.Api.csproj -c Release -o /app/build
RUN dotnet publish SO.Api/SO.Api.csproj -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "SO.Api.dll"]
