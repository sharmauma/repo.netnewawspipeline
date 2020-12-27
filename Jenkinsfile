pipeline {
    agent any
    tools {
        dotnetsdk
    }
    stages {
        stage('Restore packages') {
            steps {
                sh "dotnet restore WebApplication\\WebApplication.csproj"
            }
        }
        stage('Clean'){
            steps{
                sh "dotnet clean WebApplication\\WebApplication.csproj"
            }
        }        
        stage('Build'){
           steps{
              sh "dotnet build WebApplication\\WebApplication.csproj --configuration Release"
            }
         }
        stage('Test: Unit Test'){
           steps {
             sh "dotnet test XUnitTestProject\\XUnitTestProject.csproj"
             }
          }
        stage('Publish'){
             steps{
               sh "dotnet publish WebApplication\\WebApplication.csproj "
             }
        }
    }
}
