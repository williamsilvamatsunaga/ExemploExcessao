using System.Linq.Expressions;
using System;

public class Excessao
{

    public double _saldo;
    public void SeTSaldo(double s)
    {
        

        try
        {
            if(s >= 0)
            {
                _saldo = s;
            }
            else
            {
                throw new Exception("O saldo não pode ser negativado!");
            }
            
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
