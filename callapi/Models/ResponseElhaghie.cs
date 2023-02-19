namespace callapi.Models
{
    public class ResponseElhaghie
    {
        public int id { get; set; }
        public int thirdpartyResponseId { get; set; }
        public int carGrpCod { get; set; }
        public int cntryCod { get; set; }
        public int disBdnYrNum { get; set; }
        public int disFnYrNum { get; set; }
        public int disFnYrPrcnt { get; set; }
        public int disLfYrNum { get; set; }
        public int disLfYrPrcnt { get; set; }
        public int disPrsnYrNum { get; set; }
        public int disPrsnYrPrcnt { get; set; }
        public int edrsCmpDocNo { get; set; }
        public string edrsTyp { get; set; }
        public string mtrnum { get; set; }
        public string plk { get; set; }
        public string shsNam { get; set; }
        public string usgCod { get; set; }
        public string vin { get; set; }
        public string vehSysCod { get; set; }
        public DateTime createDate { get; set; }
    }
}
