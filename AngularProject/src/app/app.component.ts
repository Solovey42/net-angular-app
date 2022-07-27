import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
})
export class AppComponent {
    public employees?: Employee[];

  constructor(http: HttpClient) {
      http.get<Employee[]>('/main').subscribe(result => {
      this.employees = result;
    }, error => console.error(error));
  }

  title = 'AngularProject';
}

interface Employee {
  department: string;
  name: string;
  surname: string;
  patronymic: string;
  birthday: Date;
  dateOfEmployment: Date;
  salary: number;
}