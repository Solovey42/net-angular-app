import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Employee } from './app.component';

@Injectable()
export class DataService {

    private url = "/company";

    constructor(private http: HttpClient) {
    }

    getEmployees() {
        return this.http.get(this.url + '/employees');
    }

    getDepartments() {
        return this.http.get(this.url + '/departments');
    }

    getEmployee(id: number) {
        return this.http.get(this.url + '/employees/' + id);
    }

    createEmployee(employee: Employee) {
        return this.http.post(this.url + '/employees', employee);
    }

    updateEmployee(employee: Employee) {

        return this.http.put(this.url + '/employees', employee);
    }

    deleteEmployee(id: number) {
        return this.http.delete(this.url + '/employees/' + id);
    }
}