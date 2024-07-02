FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR appchat

EXPOSE 5024
EXPOSE 80

COPY *.csproj ./

RUN dotnet restore

COPY . ./

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /appchat

COPY --from=build /appchat/out .

ENTRYPOINT ["dotnet", "ChatRoom.dll"]