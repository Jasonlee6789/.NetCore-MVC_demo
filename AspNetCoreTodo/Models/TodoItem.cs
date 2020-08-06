using System;

namespace AspNetCoreTodo.Models
{
//这个类定义了每个待办事项都要保存的内容：一个 ID、一个标题或者名称、
//该事项是否已经完成，以及截至日期是什么时候。每行定义了这个类的一个属性：
public Guid Id{get;set;}
public bool IsDone {get;set;}
public string  Title {get;set;}
public DateTimeOffset? DueAt {get;set;}


}