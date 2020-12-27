pipeline {
    agent any

    stages {
        stage('Restore packages') {
            steps {
                bat "dotnet restore WebApplication\\WebApplication.csproj"
            }
        }
        stage('Clean'){
            steps{
                bat "dotnet clean WebApplication\\WebApplication.csproj"
            }
        }        
        stage('Build'){
           steps{
              bat "dotnet build WebApplication\\WebApplication.csproj --configuration Release"
            }
         }
        stage('Test: Unit Test'){
           steps {
             bat "dotnet test XUnitTestProject\\XUnitTestProject.csproj"
             }
          }
        stage('Publish'){
             steps{
               bat "dotnet publish WebApplication\\WebApplication.csproj "
             }
        }
    }
}
