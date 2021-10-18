#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["portfolio.csproj", "sq009portfolio/"]

RUN dotnet restore "sq009portfolio/portfolio.csproj"

COPY . .

WORKDIR "/src"


RUN dotnet build "portfolio.csproj" -c Release -o /app/build

#RUN dotnet ef database update

FROM build AS publish
RUN dotnet publish "portfolio.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app


COPY --from=publish /src/Portfolio.db .
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "sd009Portfolio.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet portfolio.dll