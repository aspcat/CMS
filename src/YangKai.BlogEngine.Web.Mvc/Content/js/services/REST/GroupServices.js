﻿
angular.module("GroupServices", ["ngResource"]).factory("Group", [
  '$resource', function($resource) {
    return $resource("/odata/Group:id/:action", {
      id: '@id',
      action: '@action'
    }, {
      query: {
        method: "GET",
        params: {
          $orderby: 'Url',
          $inlinecount: 'allpages',
          $filter: 'IsDeleted eq false'
        }
      },
      edit: {
        method: "PUT"
      }
    });
  }
]);
