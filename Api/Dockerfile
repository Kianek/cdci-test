# Stage 1
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
LABEL maintainer="yourmom@gmail.com"

WORKDIR /app
COPY *csproj /app
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

# Stage 2
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app/out .
EXPOSE 5000
ENTRYPOINT ["dotnet", "Api.dll"]