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
               dotnetClean project: 'WebApplication.sln', sdk: 'dotnetsdk3.1'
            }
         }
    }
}
