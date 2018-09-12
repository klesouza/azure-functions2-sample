FROM microsoft/dotnet:2.1-sdk

COPY ./ /code
WORKDIR /code
RUN dotnet restore --source https://www.nuget.org/api/v1 --packages .nuget/packages && \
    dotnet build --configuration Release --no-restore && \
    dotnet pack ./SampleAzureFunc.Docker --no-restore --configuration Release

CMD ["find", ".", "-name", "extensions.json"]