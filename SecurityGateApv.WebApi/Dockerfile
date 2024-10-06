#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
RUN apt-get update && apt-get install -y libgdiplus
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SecurityGateApv.WebApi/SecurityGateApv.WebApi.csproj", "SecurityGateApv.WebApi/"]
RUN dotnet restore "./SecurityGateApv.WebApi/./SecurityGateApv.WebApi.csproj"
COPY . .
WORKDIR "/src/SecurityGateApv.WebApi"
RUN dotnet build "./SecurityGateApv.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SecurityGateApv.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SecurityGateApv.WebApi.dll"]