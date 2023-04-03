using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Task
{
    [Header("Task Properties")] 
    public string id;
    public string name;
    public Task prevTask;
    public Task nextTask;
    public TaskState state;
    public TaskStateText text;

    public Task(string name, Task prevTask = null, Task nextTask = null, TaskState state = TaskState.NOT_STARTED)
    {
        this.id = DateTime.Now.Millisecond.ToString();
        this.name = name;
        this.prevTask = prevTask;
        this.nextTask = nextTask;
        this.state = state;
    }
}
