using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImc;

public class IMC
{
    public double Peso { get; set; }
    public double Altura { get; set; }
    public double CalculadoraDeImc(double Peso,double  Altura)
    {
        return Peso / (Altura * Altura);
    }
}