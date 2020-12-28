pipeline {
    agent any
    tools {
      dotnetsdk 'dotnetsdk3.1'
    }
    stages {
        stage('Restore packages'){
           steps{
               dotnetRestore project: 'WebApplication.sln', sdk: 'dotnetsdk3.1'
            }
         }        
        stage('Clean'){
           steps{
               dotnetClean project: 'WebApplication.sln', sdk: 'dotnetsdk3.1', configuration: 'Release'
            }
         }
        stage('Build'){
           steps{
               dotnetBuild project: 'WebApplication.sln', sdk: 'dotnetsdk3.1', configuration: 'Release'
            }
         }
        stage('Test: Unit Test'){
           steps {
                dotnetTest project: 'XUnitTestProject\\XUnitTestProject.csproj', sdk: 'dotnetsdk3.1', configuration: 'Release'
             }
          }
        stage('Publish'){
             steps{
               dotnetPublish project: 'WebApplication\\WebApplication.csproj', sdk: 'dotnetsdk3.1', configuration: 'Release'
             }
        }
        stage('Deploy'){
             steps{
               sh 'dotnet WebApplication\\bin\\Release\\netcoreapp3.1\\publish\\WebApplication.dll --urls="http://104.128.91.189:9090" --ip="104.128.91.189" --port=9090'
             }
        }        
    }
}
