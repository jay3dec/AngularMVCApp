/// <reference path="angular.js" />

var app = angular.module('EmployeeApp', []);


app.controller('test', function ($scope) {
    $scope.hello = "hello";
});