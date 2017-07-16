var app = angular.module('app', []);
app.controller('livroController', ['$scope', '$http', livroController]);

function livroController($scope, $http, livroService) {

    $scope.addMode = false;

    $http.get('/api/livro/').then(function (data) {
        $scope.livros = data.data;
    }, function (error) {
        $scope.error = "Não foi possivel completar a operação!";
    });

    $scope.toggleEdit = function () {
        this.livro.editMode = !this.livro.editMode;
    };

    $scope.toggleAdd = function () {
        $scope.addMode = !$scope.addMode;
    };

    $scope.addLivro = function () {
        var livro = this.livro;
        $http.post('/api/Livro/', livro).then(function (data) {
            alert("Salvo com sucesso");
            $scope.addMode = false;
            $scope.livros.push(data.data);
        }, function (error) {
            var mensagem = "Não foi possivel completar a operação!"
            if (error.data) {
                mensagem = error.data.Message
            }
            $scope.error = mensagem;
        });
    };

    $scope.editLivro = function () {
        var livro = this.livro;
        $http.put('/api/Livro/', livro).then(function (data) {
            alert("Salvo com sucesso");
            livro.editMode = false;
        }, function (error) {
            var mensagem = "Não foi possivel completar a operação!"
            if (error.data) {
                mensagem = error.data.Message
            }
            $scope.error = mensagem;
        });
    };

    $scope.deleteLivro = function () {
        var Id = this.livro.Id;
        $http.delete('/api/Livro/' + Id).then(function (data) {
            alert("Removido com sucesso");
            $.each($scope.livros, function (i) {
                if ($scope.livros[i].Id === Id) {
                    $scope.livros.splice(i, 1);
                    return false;
                }
            });
        }, function (error) {
            var mensagem = "Não foi possivel completar a operação!"
            if (error.data) {
                mensagem = error.data.Message
            }
            $scope.error = mensagem;
        });
    };

}