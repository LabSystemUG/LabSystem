import { Employee } from "../Models/Employee";
//import { jq } from "../typings/jquery/jquery";
export class AdminVM {
     public IS_ACTIVE: boolean;


    constructor() {

        this.IS_ACTIVE = $('#employee-isactive').val();
           
    }




}