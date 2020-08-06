using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
// 在这里添加 Actions,一个 action 方法可以返回视图、JSON数据，或者 200 OK和404 Not Found 之类的状态码。
//         localhost:5000/Home  -> Index()
// localhost:5000/Home/About   -> About()
// localhost:5000/Home/Contact -> Contact()
    

    public IActionResult Index(){
                // 从数据库获取 to-do 条目

        // 把条目置于 model 中

        // 使用 model 渲染视图
    }

    }
}
