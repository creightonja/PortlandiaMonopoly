//controls the header with the player stats - playerStats.html
/*
portlandiaMonopoly.controller('PlayerStatCtrl', function PlayerStatCtrl($scope, $stateParams, GameFactory, CommChanceFactory, UtilitiesFactory) {
    $scope.players = Data.players;
});
*/
portlandiaMonopoly.controller('PlayerStatCtrl', function PlayerStatCtrl($scope, $stateParams) {
    $scope.players = Data.players;
});