FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG TARGETARCH
WORKDIR /app

# Copy project file and restore as distinct layers
COPY --link *.csproj .
RUN dotnet restore -a $TARGETARCH

# Copy source code and publish app
COPY --link /. .
RUN dotnet publish -a $TARGETARCH --no-restore -o /app


# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
EXPOSE 5197
ENV ASPNETCORE_HTTP_PORTS=5197
WORKDIR /app
COPY --link --from=build /app .
USER $APP_UID
ENTRYPOINT ["dotnet", "aspnetapp5.dll"]


## Help: https://learn.microsoft.com/en-us/dotnet/core/docker/build-container?tabs=linux&pivots=dotnet-9-0
## Help: https://github.com/dotnet/dotnet-docker/blob/main/samples/aspnetapp/Dockerfile