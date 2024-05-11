namespace GrammaWebapi;

public interface IWheatherServices
{
    Task<ResponseDto?> GetClima();

    Task<DepartamentoDto?> GetClimaPorDepartamento(int departamentoId);
}
