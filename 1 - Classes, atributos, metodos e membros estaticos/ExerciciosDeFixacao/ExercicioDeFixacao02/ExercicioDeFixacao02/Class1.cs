﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

public class  Funcionario
{
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido()
    {
        return SalarioBruto - Imposto;
    }
    public void AumentarSalario(double porcentagem)
    {
        SalarioBruto += SalarioBruto * (porcentagem/ 100.0);
    }

    public override string ToString()
    {
        return Nome
            + ", $"
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
    }
}
