set "sonar_url=http://localhost:9000"
set "sonar_token=sqp_6a2cbb0249932773dc562a14646876e90030f5e0"
set "sonar_project=sonar-demo"
dotnet sonarscanner begin /k:"%sonar_project%" /d:sonar.host.url="%sonar_url%"  /d:sonar.token="%sonar_token%"
dotnet build
dotnet sonarscanner end /d:sonar.token="%sonar_token%"