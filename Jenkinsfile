pipeline {
    agent any
    
    stages {
        stage('Restore packages'){
           steps{
               sh 'dotnet restore WebApplication.sln'
            }
         }        
        stage('Clean'){
           steps{
               sh 'dotnet clean WebApplication.sln --configuration Release'
            }
         }
        stage('Build'){
           steps{
               sh 'dotnet build WebApplication.sln --configuration Release'
            }
         }
        stage('Test: Unit Test'){
           steps {
                sh 'dotnet test XUnitTestProject\XUnitTestProject.csproj --configuration Release'
             }
          }
        stage('Publish'){
             steps{
               sh 'dotnet publish WebApplication\WebApplication.csproj --configuration Release'
             }
        }
        stage('Deploy'){
             steps{
               sh 'dotnet WebApplication\bin\Release\netcoreapp3.1\publish\WebApplication.dll --urls="http://104.128.91.189:9090" --ip="104.128.91.189" --port=9090'
             }
        }        
    }
}
