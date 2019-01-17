import { Employee } from "../Models/Employee";
import { AdminVM } from "../ViewModels/AdminVM";

export class AdminFunctions{
        public constructor() { }
        public AdminProperties: AdminVM = new AdminVM();
        public buildEmployee = (): void => {
                let employee = new Employee("", "", "", "", "", true);
        }
        public getActivityValue = (): boolean => {
            return this.AdminProperties.IS_ACTIVE as boolean;
        }
}