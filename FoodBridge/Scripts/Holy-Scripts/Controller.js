var app = angular.module("FoodBridge", []);
app.controller('FoodBridgeController', function ($scope, FoodBridgeService) {


        $scope.toadminsignuppage = function () {
            window.location.href = 'FoodBridge/AdminSignup';
        }

        $scope.todonorsignuppage = function () {
            window.location.href = 'FoodBridge/DonorSignup';
        }

        $scope.torecipientsignuppage = function () {
            window.location.href = 'FoodBridge/RecipientSignup';
        }

        $scope.toorgregisterpage = function () {
            window.location.href = 'FoodBridge/OrgRegister';
        }
        
    
});
    
