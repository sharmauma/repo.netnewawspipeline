pipeline {
    agent any
    stages {
        stage('Build'){
           steps{
               dotnetClean configuration: 'Release', project: 'WebApplication.sln'
            }
         }
    }
}
