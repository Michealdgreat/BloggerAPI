#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["BloggerAPI/BloggerAPI.csproj", "BloggerAPI/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]
COPY ["BlogConfig/BlogConfig.csproj", "BlogConfig/"]
COPY ["PresentationFacade/PresentationFacade.csproj", "PresentationFacade/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Query/Query.csproj", "Query/"]
RUN dotnet restore "./BloggerAPI/BloggerAPI.csproj"
COPY . .
WORKDIR "/src/BloggerAPI"
RUN dotnet build "./BloggerAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./BloggerAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BloggerAPI.dll"]