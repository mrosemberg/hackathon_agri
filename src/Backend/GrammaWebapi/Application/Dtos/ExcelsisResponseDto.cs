namespace GrammaWebapi;

using System;
using System.Collections.Generic;

public class ResponseDto
{
    public string Cod { get; set; }
    public double Message { get; set; }
    public List<DepartamentoDto> Departamento_list { get; set; }
}

public class DepartamentoDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public double Poblacion { get; set; }
    public CoordenadaDto Coord { get; set; }
    public List<PronosticoExtendidoDto> Pronostico_Extendido_List { get; set; }
}

public class CoordenadaDto
{
    public double Lat { get; set; }
    public double Lon { get; set; }
}

public class PronosticoExtendidoDto
{
    public DateTime FechaHoraTxt { get; set; }
    public string DiaText { get; set; }
    public MainDto Main { get; set; }
    public List<ClimaDto> Clima { get; set; }
    public VientoDto Viento { get; set; }
    public double Visibilidad { get; set; }
    public double Probabilidad_Precipitacion { get; set; }
    public LluviaDto Lluvia { get; set; }
}

public class MainDto
{
    public double Temp { get; set; }
    public double TempMin { get; set; }
    public double TempMax { get; set; }
    public double Humedad { get; set; }
}

public class ClimaDto
{
    public int Id { get; set; }
    public string Tipo { get; set; }
    public string Description { get; set; }
}

public class VientoDto
{
    public double Velocidad { get; set; }
    public double Direccion { get; set; }
}

public class LluviaDto
{
    public double Volumen1h { get; set; }
}