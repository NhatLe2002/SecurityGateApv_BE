pipeline {
    agent any

    stages {
        stage('Git Checkout') {
            steps {
                checkout scmGit(branches: [[name: '*/Master']], extensions: [], userRemoteConfigs: [[url: 'https://github.com/NhatLe2002/SecurityGateApv_BE.git']])
            }
        }
        stage('Docker Build') {
            agent any
            steps {
                sh 'docker build -t apv_be -f SecurityGateApv.WebApi/Dockerfile .'
            }
        }
        stage('Docker Check Exist Container') {
            agent any
            steps {
                script{
                def inspectExitCode = sh script: "docker inspect apvsecurity", returnStatus: true
                if (inspectExitCode == 0) {
                    sh "docker stop apvsecurity"
                    sh "docker rm apvsecurity"
                    } 
                else{

                    }
                }
            }
        }
        stage('Docker deploy') {
            agent any
            steps {
                sh 'docker run -d --name "apvsecurity" --restart=always -p 8081:8080 apv_be'
            }
        }
        stage('Docker Delete Dangling Image') {
            agent any
            steps {
                sh "docker image prune -f"
            }
        }
    }
}
