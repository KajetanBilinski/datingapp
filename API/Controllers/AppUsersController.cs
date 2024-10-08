using System;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class AppUsersController(DataContext context) : BaseApiController
{

    [AllowAnonymous]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetAppUsers()
    {
        var appUsers = await context.AppUsers.ToListAsync();

        return Ok(appUsers);
    }

    [Authorize]
    [HttpGet("{id:int}")]
    public async Task<ActionResult<AppUser>> GetAppUser(int id)
    {
        var appUser = await context.AppUsers.FindAsync(id);

        if(appUser == null) return NotFound();

        return appUser;
    }
}
