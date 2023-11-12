#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5003

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["API_Students_Informations/API_Students_Informations.csproj", "API_Students_Informations/"]
COPY ["API_Students_Informations.Application/API_Students_Informations.Application.csproj", "API_Students_Informations.Application/"]
COPY ["API_Students_Informations.Domain/API_Students_Informations.Domain.csproj", "API_Students_Informations.Domain/"]
COPY ["API_Students_Informations.Repository/API_Students_Informations.Repository.csproj", "API_Students_Informations.Repository/"]
RUN dotnet restore "API_Students_Informations/API_Students_Informations.csproj"
COPY . .
WORKDIR "/src/API_Students_Informations"
RUN dotnet build "API_Students_Informations.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API_Students_Informations.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API_Students_Informations.dll"]