using System;
using DS_SEM_3.Generators.Exponential;

namespace DS_SEM_3.Generators.Erlang;

public class ErlangDist
{
    private ExponentialDist _expDist;
    private int _k;

    public ErlangDist(Random seedGenerator, int k, double lambda)
    {
        if (k <= 0)
            throw new ArgumentException("Parameter k musí byť väčší ako 0.");

        _expDist = new ExponentialDist(seedGenerator, lambda);
        _k = k;
    }

    public double GenerateNext()
    {
        double sum = 0.0;

        for (int i = 0; i < _k; i++)
        {
            sum += _expDist.GenerateNext();
        }

        return sum;
    }
}