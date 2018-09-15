'use strict';

app.controller("CourseControler", function ($scope, bootstrappedData) {
    $scope.courses = bootstrappedData.courses;
});