# Preparando o ambiente

## Criando o banco de dados
Abra o terminal, navegue para a pasta onde baixou o projeto e execute o comando abaixo:
```
dotnet ef database update --project .\ContainRs.WebApp\ContainRs.WebApp.csproj --startup-project .\ContainRs.WebApp\ContainRs.WebApp.csproj
```

O comando dever� criar o banco de dados e as tabelas necess�rias para o funcionamento do projeto.