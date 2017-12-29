FROM microsoft/aspnetcore:2.0
ARG source
COPY ${source}/PublishOutput /pegasusweb/
WORKDIR C:\\pegasusweb
EXPOSE 80
ENTRYPOINT ["dotnet","PegasusWeb.dll"]
