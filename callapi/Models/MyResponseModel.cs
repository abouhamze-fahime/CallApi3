namespace callapi.Models
{
    public class MyResponseModel
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int thirdPartyRequestId { get; set; }
        public int? carGrpCod { get; set; }
        public int? cmpCod { get; set; }
        public string cmpNam { get; set; }
        public string cntryCod { get; set; }
        public int? disFnYrNum { get; set; }
        public int? disFnYrPrcnt { get; set; }
        public int? disLfYrNum { get; set; }
        public int? disLfYrPrcnt { get; set; }
        public int? disPrsnYrNum { get; set; }
        public int? disPrsnYrPrcnt { get; set; }
        public int? discBdnYrNum { get; set; }
        public string fndCst { get; set; }
        public string hbgnDte { get; set; }
        public string hendDte { get; set; }
        public string hisuDte { get; set; }
        public string insNam { get; set; }
        public string lastCmpCod { get; set; }
        public string lastCmpDocNo { get; set; }
        public string mtrNum { get; set; }
        public string ntnlId { get; set; }
        public string plcyUnqCod { get; set; }
        public string plk { get; set; }
        public string prdDte { get; set; }
        public string prntCmpDocNo { get; set; }
        public string shsNum { get; set; }
        public string typPlcy { get; set; }
        public string usgCod { get; set; }
        public string usgNam { get; set; }
        public string vin { get; set; }
        public string vehNam { get; set; }
        public string vehSysCod { get; set; }
        public DateTime createDate { get; set; }
        public List<ResponseElhaghie> responseElhaghie { get; set; }
        public List<ResponseKhesarat> responseKhesarat { get; set; }
    }
}
