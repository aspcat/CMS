﻿angular.module("GalleryServices", ["ngResource"])
.factory "Gallery", ['$resource',($resource) ->
  $resource "/odata/Gallery:id/:action", {id:'@id',action:'@action'},
    query:
      method: "GET"
      params:
        $orderby:'CreateDate desc'
    update:
      method: "PUT"
]