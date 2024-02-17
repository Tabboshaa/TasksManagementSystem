export interface TaskEntity {
    id:string;
    title: string;
    description: string;
    deadline: Date;
    priority: string; 
    status: string; 
    assignedTo: string;
}