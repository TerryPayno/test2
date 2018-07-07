(function () {
  'use strict';

  angular
    .module('baseApp')
		.factory('exampleFactory', exampleFactory);

	exampleFactory.$inject = ['$http'];
	function exampleFactory($http) {
    
		exampleFactory.examplePost = function(request) {
      return $http.post('api/example/examplepost', request);
    }

		exampleFactory.exampleGet = function () {
			return $http.get('api/example/exampleget');
    }

		return exampleFactory;
  }
})();