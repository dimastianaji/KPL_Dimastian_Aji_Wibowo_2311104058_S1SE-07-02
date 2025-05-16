using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_dp
{
    public interface IAmericanPlug
    {
        void Plugin();
    }

    public class IndonesianPlug
    {
        public void Sambungkan()
        {
            Console.WriteLine("Colokan Indonesia tersambung");
        }
    }

    public class PlugAdaptor : IAmericanPlug
    {
        private readonly IndonesianPlug _plug;

        public PlugAdaptor(IndonesianPlug plug)
        {
            _plug = plug;
        }

        public void Plugin()
        {
            Console.WriteLine("Menggunakan adapter colokan Indonesia ke Mamarika");
            _plug.Sambungkan();
        }
    }
}