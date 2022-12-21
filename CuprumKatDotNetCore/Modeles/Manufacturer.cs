using System;
using System.Collections.Generic;
using CuprumKatDotNetCore.Modeles;
namespace CuprumKatDotNetCore.Modeles;

public class Manufacturer : DbEntity
{
    
    public string? CompanyName { get; set; }
    public string? UrAddress { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? Ogrn { get; set; }
    public string? Inn { get; set; }
    public string? Okpo { get; set; }
    public string? Okved { get; set; }
    public string? CeoLname { get; set; }
    public string? CeoName { get; set; }
    public string? CeoSname { get; set; }
    public string? RepresLname { get; set; }
    public string? RespersName { get; set; }
    public string? RespersSname { get; set; }
    public string? RespersPhone { get; set; }
    public override string ToString()
    {
        return CompanyName.ToString();
    }
}
