FROM microsoft/aspnetcore:1.1

MAINTAINER Yovi Oktofianus

# Set Docker remote API address
ENV DOCKER_REMOTE_API="unix:///var/run/docker.sock"

# Set ASP.NET Core environment variables
ENV ASPNETCORE_URLS="http://*:5050"
ENV ASPNETCORE_ENVIRONMENT="Production"

# Set user/pass
ENV DOCKERDASH_USER="admin"
ENV DOCKERDASH_PASSWORD="changeme"

# Copy files to app directory
COPY /release /app

# Set working directory
WORKDIR /app

# Open port
EXPOSE 5050/tcp

HEALTHCHECK CMD curl --fail http://localhost:5050/home/healthcheck || exit 1

# Run
ENTRYPOINT ["dotnet", "DockerDash.dll"]