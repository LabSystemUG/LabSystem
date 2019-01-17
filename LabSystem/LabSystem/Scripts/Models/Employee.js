"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Employee = /** @class */ (function () {
    function Employee(modelLogin, modelName, modelSurname, modelEmail, modelPass, isActiveModel) {
        this.login = modelLogin;
        this.name = modelName;
        this.surname = modelSurname;
        this.email = modelEmail;
        this.password = modelPass;
        this.isActive = isActiveModel;
    }
    return Employee;
}());
exports.Employee = Employee;
//# sourceMappingURL=Employee.js.map