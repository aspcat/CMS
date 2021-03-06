﻿angular.module('article-list',[])

.config(["$routeProvider",
($routeProvider) ->
  $routeProvider
  .when("/list/:channel/:group/:type/:query",
    templateUrl: "/Content/app/article/list/article-list.tpl.html"
    controller: 'ArticleListCtrl')
  .when("/list/:channel/:group",
    templateUrl: "/Content/app/article/list/article-list.tpl.html"
    controller: 'ArticleListCtrl')
  .when("/list/:channel",
    templateUrl: "/Content/app/article/list/article-list.tpl.html"
    controller: 'ArticleListCtrl')
  .when("/search/:key",
    templateUrl: "/Content/app/article/list/article-list.tpl.html"
    controller: 'ArticleListCtrl')
])

.controller('ArticleListCtrl',
["$scope","$translate","$routeParams","$location","Article", 
($scope,$translate,$routeParams,$location,Article) ->
  $scope.$parent.showBanner=false

  $scope.$parent.title=$routeParams.group ? $routeParams.channel ? "Search Result '#{$scope.key}'"
  $scope.currentPage =$routeParams.p ? 1

  $scope.params=
    channel:$routeParams.channel
    group:$routeParams.group
    key:$routeParams.key
    category:if $routeParams.type=='category' then $routeParams.query else ''
    tag:if $routeParams.type=='tag' then $routeParams.query else ''

  $scope.setPage = (pageNo) ->
    $location.search({p: pageNo})

  $scope.load = ->
    $scope.loading="Loading"
    filter='IsDeleted eq false'
    filter+=" and Group/Channel/Url eq '#{$scope.params.channel}'" if $scope.params.channel
    filter+=" and Group/Url eq '#{$scope.params.group}'" if $scope.params.group
    filter+=" and indexof(Title, '#{$scope.params.key}') gt -1" if $scope.params.key
    filter+=" and Categorys/any(category:category/Url eq '#{$scope.params.category}')" if $scope.params.category
    filter+=" and Tags/any(tag:tag/Name eq '#{$scope.params.tag}')" if $scope.params.tag
    Article.query
      $filter:filter
      $skip:($scope.currentPage-1)*10
    , (data)->
      scroll(0,0)
      $scope.list = data
      $scope.loading=""

  $scope.load $scope.currentPage
])