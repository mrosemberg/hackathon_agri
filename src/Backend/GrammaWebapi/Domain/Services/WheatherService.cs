namespace GrammaWebapi;

public class WheatherService : IWheatherServices
{
    public IExcelsisApiClient _excelsisApiClient { get; set; }
    public WheatherService(IExcelsisApiClient excelsisApiClient)
    {
        _excelsisApiClient = excelsisApiClient;
    }

    public async Task<ResponseDto?> GetClima()
    {
        return await _excelsisApiClient.ObtenerClima();
    }

    public async Task<DepartamentoDto?> GetClimaPorDepartamento(int departamentoId)
    {
        // Simula una llamada a un servicio externo o una base de datos
        var climaGeneral = await _excelsisApiClient.ObtenerClima();

        var response = climaGeneral.Departamento_list.FirstOrDefault(d => d.Id == departamentoId);

        return response;

        //return await _excelsisApiClient.ObtenerClima(departamentoId);
    }
}
