using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
        // 在这里添加 Actions
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
