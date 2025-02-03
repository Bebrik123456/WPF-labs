using System;

namespace WPF_labs.Models;

public class TaskModel
{
    
        public int? Id { get; set; } // айди но хзхз
        public string Name { get; set; } // название 
        public string Description { get; set; } // описание 
        public DateTime DateTime { get; set; } // дата и время создания(наверное созздания я хз какое там надо время)
        public int Status { get; set; } // статус задачи
        public int Type { get; set; } // тип задачи
    
}