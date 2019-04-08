using System.Collections;
using System.Collections.Generic;

namespace Composite
{
    public class Neuron : IEnumerable<Neuron>
    {
        public List<Neuron> In, Out;
        public float Value;

        public IEnumerator<Neuron> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return this;
        }
    }
}