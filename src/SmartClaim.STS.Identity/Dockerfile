#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/SmartClaim.STS.Identity/SmartClaim.STS.Identity.csproj", "src/SmartClaim.STS.Identity/"]
COPY ["src/SmartClaim.Admin.EntityFramework.Shared/SmartClaim.Admin.EntityFramework.Shared.csproj", "src/SmartClaim.Admin.EntityFramework.Shared/"]
COPY ["src/SmartClaim.Admin.EntityFramework.SqlServer/SmartClaim.Admin.EntityFramework.SqlServer.csproj", "src/SmartClaim.Admin.EntityFramework.SqlServer/"]
COPY ["src/SmartClaim.Admin.EntityFramework.PostgreSQL/SmartClaim.Admin.EntityFramework.PostgreSQL.csproj", "src/SmartClaim.Admin.EntityFramework.PostgreSQL/"]
COPY ["src/SmartClaim.Shared/SmartClaim.Shared.csproj", "src/SmartClaim.Shared/"]
COPY ["src/SmartClaim.Admin.EntityFramework.MySql/SmartClaim.Admin.EntityFramework.MySql.csproj", "src/SmartClaim.Admin.EntityFramework.MySql/"]
RUN dotnet restore "src/SmartClaim.STS.Identity/SmartClaim.STS.Identity.csproj"
COPY . .
WORKDIR "/src/src/SmartClaim.STS.Identity"
RUN dotnet build "SmartClaim.STS.Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SmartClaim.STS.Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "SmartClaim.STS.Identity.dll"]