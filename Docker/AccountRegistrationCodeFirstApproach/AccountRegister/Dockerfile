#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["AccountRegister/AccountRegister.csproj", "AccountRegister/"]
RUN dotnet restore "AccountRegister/AccountRegister.csproj"
COPY . .
WORKDIR "/src/AccountRegister"
RUN dotnet build "AccountRegister.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AccountRegister.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AccountRegister.dll"]