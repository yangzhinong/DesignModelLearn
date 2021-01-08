using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModeLearn.BuilderModes.Computers
{
    class MacbookBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();
        public MacbookBuilder()
        {
            _computer = new Computer();
            HasDisplayDevice = true;
        }
        public bool HasDisplayDevice { get; set; }

        public void BuildCpu()
        {
            _computer.Cpu = "Mac Cpu";
        }

        public void BuildDisplayDevice()
        {
            _computer.DisplayDevice = "17";
        }

        public void BuildHardDisk()
        {
            _computer.HardDisk = "Ssd 1G";
        }

        public void BuildKeyBoard()
        {
            _computer.KeyBoard = "ddd";
        }

        public void BuildMainBoard()
        {
            _computer.MainBoard = "unkown";
        }

        public void BuildMemory()
        {
            _computer.Memory = "pc3200 16G";
        }

        public void BuildMouse()
        {
            _computer.Mouse = "none";
        }

        public Computer CreateComputer()
        {
            return _computer;
        }
    }
}
