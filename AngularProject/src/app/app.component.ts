import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

import { DataService } from './data.service';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    providers: [DataService]
})
export class AppComponent {
    newEmployee: Employee = new Employee();

    public employees?: Employee[];

    public departments?: Department[];

    tableMode: boolean = true;

    constructor(private dataService: DataService) { }

    ngOnInit() {
        this.loadEmployees();
        this.loadDepartments();
    }

    loadEmployees() {
        this.dataService.getEmployees()
            .subscribe((data: Employee[]) => this.employees = data);
    }

    loadDepartments() {
        this.dataService.getDepartments()
            .subscribe((data: Department[]) => this.departments = data);
    }

    save() {
        if (this.newEmployee.id == null) {
            this.dataService.createEmployee(this.newEmployee)
                .subscribe((data: Employee) => this.employees.push(data));
        } else {
            this.dataService.updateEmployee(this.newEmployee)
                .subscribe(data => this.loadEmployees());
        }
        this.cancel();
    }
    editEmployee(employee: Employee) {
        this.newEmployee = employee;
    }
    cancel() {
        this.newEmployee = new Employee();
        this.tableMode = true;
    }
    delete(employee: Employee) {
        this.dataService.deleteEmployee(employee.id)
            .subscribe(data => this.loadEmployees());
    }
    add() {
        this.cancel();
        this.tableMode = false;
    }

    title = 'AngularProject';
}

export class Employee {
    id?: number;
    department: string;
    name: string;
    birthday: Date;
    dateOfEmployment: Date;
    salary: number;
}

export class Department {
    id?: number;
    name: string;
}