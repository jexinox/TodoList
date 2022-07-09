using Microsoft.AspNetCore.Mvc;
using TodoList.Utils;

namespace TodoList.Controllers;

[Route("/api/todo")]
public class TodoController : Controller
{
    [HttpGet]
    public IActionResult ReadTodo(TodoPaginationParameters parameters)
    {
        throw new NotImplementedException();
    }
}