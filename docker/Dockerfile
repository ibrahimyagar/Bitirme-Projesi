# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies
COPY ["Classroom.csproj", "./"]
RUN dotnet restore "Classroom.csproj"

# Copy everything else and build
COPY . .
RUN dotnet build "Classroom.csproj" -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish "Classroom.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Create uploads directory
RUN mkdir -p /app/wwwroot/uploads/homeworks

# Copy published app
COPY --from=publish /app/publish .

# Set permissions
RUN chmod -R 755 /app/wwwroot/uploads

EXPOSE 8080
EXPOSE 8081

ENTRYPOINT ["dotnet", "Classroom.dll"]

