﻿namespace Wincubate.CS7x.Data
{
    public enum SoftwareArchitectLevel
    {
        AssociateJunior,
        Senior,
        Lead
    }

    public class SoftwareArchitect : Employee
    {
        public SoftwareArchitectLevel? Level { get; set; }
        public int VisioDrawingsProduced { get; set; }
    }
}
