'use strict';
app.controller('indexController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {

    $scope.logOut = function () {
        authService.logOut();
        $location.path('/index');
    }

    $scope.authentication = authService.authentication;

    // -- login --
    $scope.loginData = {
        userName: "",
        password: ""
    };

    $scope.message = "";

    $scope.login = function () {

        authService.login($scope.loginData).then(function (response) {

            $location.path('/dashboard'); 
           

            //window.location.href = "/Index.cshtml/dashboard";

        },
            function (err) {
                $scope.message = "Error login";
                //$scope.message = err.error_description;
            });
    };
    // -- login --


}]);