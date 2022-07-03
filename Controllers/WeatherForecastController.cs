using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAL;
using Models;

namespace CoinApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CoinsController : ControllerBase
{
    private readonly ILogger<CoinsController> _logger;
    private Contexto _contexto;

    public CoinsController(ILogger<CoinsController> logger, Contexto contexto)
    {
        _logger = logger;
        _contexto = contexto;
    }

    [HttpGet(Name = "GetCoins")]
    public IEnumerable<Coins> Get()
    {
       return _contexto.Coins.AsNoTracking().ToList();
    }

     [HttpPost(Name ="PostCoin")]
    public async Task<ActionResult<Coins>> PostCoin(Coins coins){
        
        _contexto.Coins.Add(coins);
        await _contexto.SaveChangesAsync();
        return CreatedAtAction(nameof(PostCoin), coins);  
    } 

}
