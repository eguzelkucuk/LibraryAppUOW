var app = angular.module("UserListApp", []);
app.controller("UserLisController", function ($scope, $http) {
    $http.get('http://localhost:58938/api/userlist/getall').
    success(function (data, status, headers, config) {
        $scope.userlist = data;
    })
    .error(function (data, status, headers, config) {
        alert("Kayıt Çekilemedi!");
    });
});

var app = angular.module("SignInApp", []);
app.controller("SignInController", function ($scope, $http) {
    $http.get('http://localhost:58938/api/userlist/getall').
    success(function (data, status, headers, config) {
        $scope.userlist = data;
    })
    .error(function (data, status, headers, config) {
        alert("Kayıt Çekilemedi!");
    });
});