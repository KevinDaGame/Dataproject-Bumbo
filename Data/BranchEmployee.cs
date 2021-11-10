namespace Data
{
    public class BranchEmployee
    {
        public int Id { get; set; }
        public Branch Branch { get; set; }
        public Employee Employee { get; set; }
        public string NFCId { get; set; }
        public int Scale { get; set; }
    }
}