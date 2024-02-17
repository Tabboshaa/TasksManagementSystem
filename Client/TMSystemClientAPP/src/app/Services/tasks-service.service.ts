import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TasksServiceService {

  constructor(private http:HttpClient) { }
  baseUrl="https://localhost:7041/api/tasks"; 

  getAllTasks(): Observable<Task[]>
  {
    return this.http.get<Task[]>(this.baseUrl);
  }
}
