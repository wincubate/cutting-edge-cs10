namespace Wincubate.CS8.Data
{
    public class SoftwareEngineer : Employee
    {
        public SoftwareEngineer(
            string firstName, 
            string lastName, 
            Level? level = default,
            int codeLinesProduced = 0
        ) : base( firstName, lastName )
        {
            Level = level;
            CodeLinesProduced = codeLinesProduced;
        }

        public Level? Level { get; set; }
        public int CodeLinesProduced { get; set; }
    }
}