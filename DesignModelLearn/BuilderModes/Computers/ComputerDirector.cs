using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeLearn.BuilderModes.Computers
{
    class ComputerDirector
    {
        private IComputerBuilder _builder;
        public ComputerDirector(IComputerBuilder builder)
        {
            _builder = builder;
        }

        public Computer Construct()
        {
            _builder.BuildMainBoard();
            _builder.BuildCpu();
            _builder.BuildMemory();
            _builder.BuildHardDisk();
            _builder.BuildKeyBoard();
            if (_builder.HasDisplayDevice)
            {
                _builder.BuildDisplayDevice();
            }
            _builder.BuildMouse();

            return _builder.CreateComputer();
        }
    }
}
