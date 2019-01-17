export class Employee {
    public constructor(modelLogin: string, modelName: string, modelSurname: string, modelEmail: string, modelPass: string, isActiveModel: boolean)
    {
        this.login = modelLogin;
        this.name = modelName;
        this.surname = modelSurname;
        this.email = modelEmail;
        this.password = modelPass;
        this.isActive = isActiveModel;
    }

        login: string;
        name: string;
        surname: string;
        email: string;
        password: string;
        isActive: boolean;
    }
