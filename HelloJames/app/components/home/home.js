(function () {
	'use strict';

	angular
		.module('baseApp')
		.controller('homeCtrl', homeCtrl);

	homeCtrl.$inject = ['$scope', 'exampleFactory'];
	function homeCtrl($scope, exampleFactory) {
		$scope.text = 'Hello James';
		$scope.mydata = null;
		$scope.myList = null;

		$scope.post = function () {
			var request = {
				foo: ["These", "Strings", "Are", "Posted", "And", "Returned"],
				bar: true
			}
			exampleFactory.examplePost(request).then(function (resp) {
				$scope.myList = resp.data;
			});
		}

		function init() {
			exampleFactory.exampleGet().then(function (resp) {
				$scope.mydata = resp.data;
			});
		}

		init();
	}
})();