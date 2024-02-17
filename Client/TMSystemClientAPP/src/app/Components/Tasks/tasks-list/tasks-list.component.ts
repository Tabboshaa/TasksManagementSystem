import { Component, OnInit } from '@angular/core';
import { TaskEntity } from 'src/app/Model/Task.Model';
import { TasksService } from 'src/app/Services/tasks.service';

@Component({
  selector: 'app-tasks-list',
  templateUrl: './tasks-list.component.html',
  styleUrls: ['./tasks-list.component.css']
})
export class TasksListComponent implements OnInit {
  
  tasks: TaskEntity[] = [];

  constructor(private taskService: TasksService) { }

  ngOnInit(): void {
      this.getAllTasks();
  }
  getAllTasks() {
    debugger;
    this.taskService.getAllTasks().subscribe(
      (response: TaskEntity[]) => { 
        this.tasks = response;
      }
    );
  }
  deleteTask(id:string)
  {
    debugger;
    this.taskService.deleteTask(id).subscribe();
  }

}
