using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Aluno
{
    public string Nome;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public double Soma()
    {
        return Nota1 + Nota2 + Nota3;
    }
    public bool Aprovado()
    {
        if (Soma() >= 60.0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public double Restante()
    {         
        if (Aprovado())
        {
            return 0.0;
        }
        else
        {
            return 60.0 - Soma();
        }
    }
}
