using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeLearn.BuilderModes.Computers
{
    interface IComputerBuilder
    {
        void BuildCpu();
        void BuildMemory();
        void BuildHardDisk();
        void BuildKeyBoard();
        void BuildMainBoard();
        void BuildDisplayDevice();
        void BuildMouse();

        bool HasDisplayDevice { get; set; }
        Computer CreateComputer();
    }
}
