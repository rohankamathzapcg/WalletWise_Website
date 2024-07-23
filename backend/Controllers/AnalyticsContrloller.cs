﻿using ExpenseTracker.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpenseTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalyticsController : ControllerBase
    {
        private readonly IAnalyticsRepository _analyticsRepository;

        public AnalyticsController(IAnalyticsRepository analyticsRepository)
        {
            _analyticsRepository = analyticsRepository;
        }

        [HttpGet("total-expense-today")]
        public async Task<IActionResult> GetTotalExpenseToday([FromQuery] string email, [FromQuery] int date, [FromQuery] int month, [FromQuery] int year)
        {
            var result = await _analyticsRepository.GetTotalExpenseTodayAsync(email, date, month, year);
            return Ok(result);
        }

        [HttpGet("total-income-today")]
        public async Task<IActionResult> GetTotalIncomeToday([FromQuery] string email, [FromQuery] int date, [FromQuery] int month, [FromQuery] int year)
        {
            var result = await _analyticsRepository.GetTotalIncomeTodayAsync(email, date, month, year);
            return Ok(result);
        }

        [HttpGet("total-expense-this-week")]
        public async Task<IActionResult> GetTotalExpenseThisWeek([FromQuery] string email, [FromQuery] int date, [FromQuery] int month, [FromQuery] int year)
        {
            var result = await _analyticsRepository.GetTotalExpenseThisWeekAsync(email, date, month, year);
            return Ok(result);
        }

        [HttpGet("total-income-this-week")]
        public async Task<IActionResult> GetTotalIncomeThisWeek([FromQuery] string email, [FromQuery] int date, [FromQuery] int month, [FromQuery] int year)
        {
            var result = await _analyticsRepository.GetTotalIncomeThisWeekAsync(email, date, month, year);
            return Ok(result);
        }

        [HttpGet("total-expense-by-month")]
        public async Task<IActionResult> GetTotalExpenseByMonth([FromQuery] string email, [FromQuery] int year, [FromQuery] int month)
        {
            var result = await _analyticsRepository.GetTotalExpenseByMonthAsync(email, year, month);
            return Ok(result);
        }

        [HttpGet("total-income-by-month")]
        public async Task<IActionResult> GetTotalIncomeByMonth([FromQuery] string email, [FromQuery] int year, [FromQuery] int month)
        {
            var result = await _analyticsRepository.GetTotalIncomeByMonthAsync(email, year, month);
            return Ok(result);
        }

        [HttpGet("total-expense-this-year")]
        public async Task<IActionResult> GetTotalExpenseThisYear([FromQuery] string email, [FromQuery] int year)
        {
            var result = await _analyticsRepository.GetTotalExpenseThisYearAsync(email, year);
            return Ok(result);
        }

        [HttpGet("total-income-this-year")]
        public async Task<IActionResult> GetTotalIncomeThisYear([FromQuery] string email, [FromQuery] int year)
        {
            var result = await _analyticsRepository.GetTotalIncomeThisYearAsync(email, year);
            return Ok(result);
        }

        [HttpGet("total-expense-by-category-today")]
        public async Task<IActionResult> GetTotalExpenseByCategoryToday([FromQuery] string email, [FromQuery] int date, [FromQuery] int month, [FromQuery] int year)
        {
            var result = await _analyticsRepository.GetTotalExpenseByCategoryTodayAsync(email, date, month, year);
            return Ok(result);
        }

        [HttpGet("total-expense-by-category-this-week")]
        public async Task<IActionResult> GetTotalExpenseByCategoryThisWeek([FromQuery] string email, [FromQuery] int date, [FromQuery] int month, [FromQuery] int year)
        {
            var result = await _analyticsRepository.GetTotalExpenseByCategoryThisWeekAsync(email, date, month, year);
            return Ok(result);
        }

        [HttpGet("total-expense-by-category-this-month")]
        public async Task<IActionResult> GetTotalExpenseByCategoryThisMonth([FromQuery] string email, [FromQuery] int month, [FromQuery] int year)
        {
            var result = await _analyticsRepository.GetTotalExpenseByCategoryThisMonthAsync(email, month, year);
            return Ok(result);
        }

        [HttpGet("total-expense-by-category-this-year")]
        public async Task<IActionResult> GetTotalExpenseByCategoryThisYear([FromQuery] string email, [FromQuery] int year)
        {
            var result = await _analyticsRepository.GetTotalExpenseByCategoryThisYearAsync(email, year);
            return Ok(result);
        }
    }
}