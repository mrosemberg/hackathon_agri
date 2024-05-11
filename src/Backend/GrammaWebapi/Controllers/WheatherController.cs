using Microsoft.AspNetCore.Mvc;

namespace GrammaWebapi;

[ApiController]
[Route("[controller]")]
public class WheatherController : ControllerBase
{
    private readonly IWheatherServices _wheatherServices;

    public WheatherController(IWheatherServices wheatherServices)
    {
        _wheatherServices = wheatherServices;
    }

    [HttpGet("clima")]
    public async Task<IActionResult> GetClima()
    {
        var clima = await _wheatherServices.GetClima();
        if (clima != null)
        {
            return Ok(clima);
        }
        return NotFound("No se encontró información del clima.");
    }

    [HttpGet("departamentos")]
    public IActionResult GetDepartamentos()
    {
        var departamentos = Enum.GetValues(typeof(Departamento))
                                .Cast<Departamento>()
                                .Select(d => new
                                {
                                    Id = (int)d,
                                    Nombre = d.ToString()
                                })
                                .ToList();

        return Ok(departamentos);
    }

    [HttpGet("clima/{departamentoId}")]
    public async Task<IActionResult> GetClimaPorDepartamento(int departamentoId)
    {
        var departamento = await _wheatherServices.GetClimaPorDepartamento(departamentoId);
        if (departamento != null)
        {
            return Ok(departamento);
        }
        return NotFound($"No se encontró información del clima para el departamento con ID: {departamentoId}.");
    }
}
