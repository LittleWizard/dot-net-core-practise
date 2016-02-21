(function() {
'use strict';

    angular
        .module('app')
        .controller('RunnersController', ControllerController);

    ControllerController.$inject = ['$http'];
    function ControllerController($http) {
        var vm = this;
        vm.runners = [];

        activate();

        function activate() { 
            $http.get('api/runner')
            .then(function(response) {
                vm.runners = response.data;
            })
            .catch(function(err) {
                console.log(err);
            })
        }
    }
})();