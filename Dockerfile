WORKDIR /app
FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["API/Agilistas.csproj", "API/"]
RUN dotnet restore "API/Agilistas.csproj"
COPY . .
WORKDIR "/src/API"
RUN dotnet build "Agilistas.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Agilistas.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Agilistas.dll"]
