var baseApp = angular.module("baseApp", ["ngRoute"]);

baseApp.config(['$routeProvider', '$locationProvider',
	function ($routeProvider, $locationProvider) {
		$routeProvider.when('/', {
			templateUrl: "app/components/home/home.html",
			controller: "homeCtrl",
			label: 'Home'
		})
			.when("/home", {
				templateUrl: "app/components/home/home.html",
				controller: "homeCtrl",
				label: 'Home'
			})
			.otherwise({
				redirectTo: "/home"
			});
		$locationProvider.html5Mode(true);
	}
]);