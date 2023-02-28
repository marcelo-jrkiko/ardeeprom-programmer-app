namespace ArdEepromProgrammer
{
    public class ProgrammerVerifyResult
    {
        public bool IsOkay { get; set; }
        public string EEPROM_HASH { get; set; }
        public string COMPARE_HASH { get; set; }
    }
}