"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Employee_1 = require("../Models/Employee");
var AdminVM_1 = require("../ViewModels/AdminVM");
var AdminScripts = /** @class */ (function () {
    function AdminScripts() {
        var _this = this;
        this.AdminProperties = new AdminVM_1.AdminVM();
        this.buildEmployee = function () {
            var employee = new Employee_1.Employee("", "", "", "", "", true);
        };
        this.getActivityValue = function () {
            return _this.AdminProperties.IS_ACTIVE;
        };
    }
    return AdminScripts;
}());
exports.AdminScripts = AdminScripts;
//# sourceMappingURL=AdminScripts.js.map