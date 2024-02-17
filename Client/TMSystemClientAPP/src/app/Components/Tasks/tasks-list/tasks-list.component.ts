import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-tasks-list',
  templateUrl: './tasks-list.component.html',
  styleUrls: ['./tasks-list.component.css']
})
export class TasksListComponent implements OnInit {
  tasks: any[] = [
    { 
      title: 'Task 1',
      description: 'Description for task 1',
      priority: 'High',
      status: 'Pending',
      deadline: new Date('2024-02-20'),
      assignedTo: 'John Doe'
    },
    // Add more sample tasks here if needed
  ];

  constructor() { }

  ngOnInit(): void {
  }
  selectedTask: any;

  showTaskDetails(task: any): void {
    this.selectedTask = task;
  }

  deleteTask(task: any): void {
    const index = this.tasks.findIndex(t => t.id === task.id);
    if (index !== -1) {
      this.tasks.splice(index, 1);
      this.selectedTask = null; // Reset selected task after deletion
    }
  }

}
