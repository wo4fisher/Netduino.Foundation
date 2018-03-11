using System;
using Microsoft.SPOT;

namespace Netduino.Foundation.GPIO
{
    public interface IDigitalPort : IPort
    {
        bool State { get; set; }
    }
}
