#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["projeto-contabil/projeto-contabil.csproj", "projeto-contabil/"]
RUN dotnet restore "projeto-contabil/projeto-contabil.csproj"
COPY . .
WORKDIR "/src/projeto-contabil"
RUN dotnet build "projeto-contabil.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "projeto-contabil.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "projeto-contabil.dll"]