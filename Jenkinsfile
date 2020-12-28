pipeline {
    agent any
    tools {
      dotnetsdk 'dotnetsdk3.1'
    }
    stages {
        stage('Clean'){
           steps{
               dotnetClean project: 'WebApplication\\WebApplication.csproj', sdk: 'dotnetsdk3.1'
            }
         }
    }
}
