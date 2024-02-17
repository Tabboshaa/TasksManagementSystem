import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { TaskEntity } from '../Model/Task.Model';

@Injectable({
  providedIn: 'root'
})
export class TasksService{

  constructor(private http:HttpClient) { }
  baseUrl="https://localhost:7041/api/tasks"; 

  getAllTasks(): Observable<TaskEntity[]>
  {
    return this.http.get<TaskEntity[]>(this.baseUrl);
  }
  AddTask(taskEntity : TaskEntity): Observable<TaskEntity>{
    return this.http.post<TaskEntity>(this.baseUrl,taskEntity);
  }
  deleteTask(id:string): Observable<TaskEntity>
  {
    return this.http.delete<TaskEntity>(this.baseUrl+'/'+id);
  }
}