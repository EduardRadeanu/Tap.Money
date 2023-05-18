using Microsoft.AspNetCore.Mvc;
using TAPPPPPP.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TAPPPPPP.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportExpensesController : ControllerBase
    {
        private static readonly string[] Expenses = new[]
        {
            "Cafea", "Supermarket", "Fuel", "Restaurant"
        };

        private readonly ILogger<ReportExpensesController> _logger;
        private readonly List<Expense> _expenses;
        private IEnumerable<Expense> expenses;

        public ReportExpensesController(ILogger<ReportExpensesController> logger)
        {
            _logger = logger;
            _expenses = new List<Expense>();
        }

        [HttpGet]
        public IEnumerable<Expense> Get()
        {
            expenses = _expenses;
            return expenses;
        }


        [HttpPost]
        public IActionResult AddExpense([FromBody] Expense expense)
        {
            _expenses.Add(expense);
            return Ok(_expenses);
        }
    }
}
