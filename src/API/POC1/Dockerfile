FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["POC1/POC1.csproj", "POC1/"]
RUN dotnet restore "POC1/POC1.csproj"
COPY . .
WORKDIR "/src/POC1"
RUN dotnet build "POC1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "POC1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "POC1.dll"]