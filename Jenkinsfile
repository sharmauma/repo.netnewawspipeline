pipeline {
    agent any
    tools {
      dotnetsdk 'dotnetsdk3.1'
    }
    stages {
        stage('Clean'){
           steps{
               dotnetClean configuration: 'Release', project: 'WebApplication.sln'
            }
         }
        stage('Restore packages'){
           steps{
               dotnetRestore project: 'WebApplication.sln', sdk: 'dotnetsdk3.1'
            }
         }
        stage('Build'){
           steps{
               dotnetBuild project: 'WebApplication.sln'
            }
         }
        stage('Test: Unit Test'){
           steps {
                dotnetTest project: 'XUnitTestProject\\XUnitTestProject.csproj'
             }
          }
        stage('Publish'){
             steps{
               dotnetPublish project: 'WebApplication\\WebApplication.csproj'
             }
        }
    }
}
