using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IMC{
    public double CalculadoraDeImc(double Peso, double Altura)
    {
        return Peso / (Altura * Altura);
    }
}