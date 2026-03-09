using DbOperationsWithEfCoreApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEfCoreApp.Controllers
{
    [Route("api/languages")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public LanguagesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllLanguages()
        {
            //var result = _appDbContext.Languages.ToList();
            //var result = (from languages in _appDbContext.Languages
            //              select languages).ToList();

            //var result = await _appDbContext.Languages.ToListAsync();

            var result = await (from languages in _appDbContext.Languages
                          select languages).ToListAsync();


            return Ok(result);
        }
    }
}
