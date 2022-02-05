pipeline {
    agent any
     triggers {
        githubPush()
      }
     environment {
      DOCKER_TAG = getVersion()
    }
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
               sh 'dotnet build WebApplication.sln --configuration Release --no-restore'
            }
         }
        stage('Test: Unit Test'){
           steps {
                sh 'dotnet test XUnitTestProject/XUnitTestProject.csproj --configuration Release --no-restore'
             }
          }
        stage('Publish'){
             steps{
               sh 'dotnet publish WebApplication/WebApplication.csproj --configuration Release --no-restore'
             }
        }
        stage('Docker Build'){
            steps{
                sh 'cd  /var/lib/jenkins/workspace/dotnet-pipe/WebApplication/ '
               // sh "chmod 777 /var/run/docker.sock"
                sh "docker build . -t krish2356/aspnet:${DOCKER_TAG}"
            }
        }
        stage('Deploy'){
             steps{
              // sh '''for pid in $(lsof -t -i:9090); do
                //       kill -9 $pid
             //  done'''
               sh 'cd WebApplication/bin/Release/netcoreapp3.1/publish/'
               sh 'cp -r /var/lib/jenkins/workspace/dotnet-pipe/WebApplication/bin/Release/netcoreapp3.1 /var/www/html/netcoreapp3.1/'
             }
        }        
    }
}
def getVersion(){
    def commitHash = sh label: '', returnStdout: true, script: 'git rev-parse --short HEAD'
    return commitHash
}
