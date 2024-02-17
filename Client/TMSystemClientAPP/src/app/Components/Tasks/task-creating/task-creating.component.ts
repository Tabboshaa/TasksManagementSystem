import { Component, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { TaskEntity } from 'src/app/Model/Task.Model';
import { TasksService } from 'src/app/Services/tasks.service';
import { TasksListComponent } from '../tasks-list/tasks-list.component';

@Component({
  selector: 'app-task-creating',
  templateUrl: './task-creating.component.html',
  styleUrls: ['./task-creating.component.css']
})
export class TaskCreatingComponent implements OnInit {
  
  @ViewChild(TasksListComponent) TasksListComponent!: TasksListComponent;


  public TaskForm: FormGroup = new FormGroup({
    title: new FormControl<string>(''),
    description: new FormControl<string>(''),
    priority: new FormControl<string>(''),
    status: new FormControl<string>(''),
    assignedTo: new FormControl<string>(''),
    deadline: new FormControl<Date>(new Date())
  });

  constructor(private taskService: TasksService) { }

  ngOnInit(): void {
  }
  onFormSubmit(): void {
    if (this.TaskForm.valid) {
      debugger;
      const formData: TaskEntity = this.TaskForm.value;
      this.taskService.AddTask(formData).subscribe(response=>
        {
          console.log(response);
        });
      console.log(formData); 
    } else {
      console.log('Form is invalid. Please fill in all required fields.');
    }
  }
  
}
