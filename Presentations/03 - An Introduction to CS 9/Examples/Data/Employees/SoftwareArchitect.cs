namespace Wincubate.CS8.Data
{
    public class SoftwareArchitect : Employee
    {
        public Level? Level { get; set; }
        public int VisioDrawingsProduced { get; set; }

        public SoftwareArchitect(
            string firstName,
            string lastName,
            Level? level = default,
            int visioDrawingsProduced = 0
        ) : base(firstName, lastName)
        {
            Level = level;
            VisioDrawingsProduced = visioDrawingsProduced;
        }
    }
}
