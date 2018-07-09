FROM microsoft/dotnet:2.1.0-runtime

ARG TARBALL=VMS.Requisitons.tar.gz
RUN mkdir /app
ADD $TARBALL /app/
ENV ASPNETCORE_URLS http://*:5000
EXPOSE 5000
WORKDIR /app
ENTRYPOINT ["dotnet", "./VMS.Requisitons.dll"]