using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CuprumKatDotNetCore.Modeles;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CuprumKatDotNetCore.Modeles;

public abstract class DbEntity
{
    [Key] public int Id { get; set; }
}
