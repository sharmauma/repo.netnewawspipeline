pipeline {
    agent any
    tools {
      dotnetsdk 'dotnetsdk3.1'
    }
    stages {
        stage('Clean'){
           steps{
               dotnetClean project: 'WebApplication.sln', sdk: 'dotnetsdk3.1'
            }
         }
        stage('Restore packages'){
           steps{
               dotnetRestore project: 'WebApplication.sln', sdk: 'dotnetsdk3.1'
            }
         }
        stage('Build'){
           steps{
               dotnetBuild project: 'WebApplication.sln', sdk: 'dotnetsdk3.1'
            }
         }
        stage('Test: Unit Test'){
           steps {
                dotnetTest project: 'XUnitTestProject\\XUnitTestProject.csproj', sdk: 'dotnetsdk3.1'
             }
          }
        stage('Publish'){
             steps{
               dotnetPublish project: 'WebApplication\\WebApplication.csproj', sdk: 'dotnetsdk3.1'
             }
        }
    }
}
