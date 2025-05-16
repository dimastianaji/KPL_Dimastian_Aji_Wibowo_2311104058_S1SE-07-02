using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_dp
{
    public interface ICommand
    {
        void Execute();
    }

    public class Television
    {
        public void TurnOn()
        {
            Console.WriteLine("Television is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Television is off");
        }
    }

    public class TelevisionTurnOn : ICommand
    {
        private readonly Television _television;

        public TelevisionTurnOn(Television television)
        {
            _television = television;
        }

        public void Execute()
        {
            _television.TurnOn();
        }
    }

    public class TelevisionTurnOff : ICommand
    {
        private readonly Television _television;

        public TelevisionTurnOff(Television television)
        {
            _television = television;
        }

        public void Execute()
        {
            _television.TurnOff();
        }
    }

    public class RemoteTV
    {
        private ICommand? turnOn;
        private ICommand? turnOff;

        public void SetTurnOn(ICommand command)
        {
            turnOn = command;
        }

        public void SetTurnOff(ICommand command)
        {
            turnOff = command;
        }

        public void TurnOnTV()
        {
            turnOn?.Execute();
        }

        public void TurnOffTV()
        {
            turnOff?.Execute();
        }
    }
}