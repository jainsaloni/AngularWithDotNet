import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { City } from '../models/city';
import { Employee } from '../models/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  baseUrl = 'employee/';

  constructor(private http: HttpClient) { }

  getCityList(): Observable<City[]> {
    return this.http.get<City[]>(this.baseUrl + 'GetCityList');
  }

  getEmployees(): Observable<Employee[]> {
    return this.http.get<Employee[]>(this.baseUrl);
  }

  getEmployeeById(id: number): Observable<Employee> {
    return this.http.get<Employee>(this.baseUrl + 'GetById/' + id);
  }

  saveEmployee(employee: Employee): Observable<any> {
    return this.http.post(this.baseUrl, employee);
  }

  updateEmployee(employee: Employee): Observable<any> {
    return this.http.put(this.baseUrl, employee);
  }

  deleteEmployee(id: number): Observable<any> {
    return this.http.delete(this.baseUrl + 'DeleteById/' + id);
  }
}
