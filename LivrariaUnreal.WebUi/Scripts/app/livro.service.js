define([], function () {

    function livroService($http, $window) {
        var service = {};

        var url = '/api/Livro/';

        service.delete = function (data) {
            var headers = {
                'Content-Type': 'application/json; charset=utf-8'
            };
            return $http.delete(url, {
                data: data,
                headers: headers
            })
                .then(function (result) {
                    return result.data;
                });
        };

        return service;
    }

    livroService.$inject = ['$http', '$window'];

    return livroService;
});
