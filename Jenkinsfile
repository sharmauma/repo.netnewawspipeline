pipeline {
    agent any
    tools {
      dotnetsdk 'dotnetsdk3.1'
    }
    stages {
        stage('Build'){
           steps{
               dotnetClean configuration: 'Release', project: 'WebApplication.sln'
            }
         }
    }
}
