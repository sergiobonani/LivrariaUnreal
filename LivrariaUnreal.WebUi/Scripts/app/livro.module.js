requirejs([
    'angular',
    inject('livro.service'),
    inject('livro.controller')
], function (
    angular,
    livroService,
    livroController,
    ) {

    var module = angular.module('app.cadastro.livro', [])
        .controller('livroController', livroController)
        .service('livroService', livroService).config(function (blockUIConfigProvider);

        bootstrapModule(module.name);
    });
