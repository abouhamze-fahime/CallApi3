namespace callapi.Models
{
    public class ResponseKhesarat
    {
        public int Id { get; set; }

        public int ThirdpartyResponseId { get; set; }
        /// <summary>
        /// تاریخ شمسی اعلام حادثه
        /// </summary>
        public string HancDte { get; set; }
        /// <summary>
        /// تاریخ پرداخت خسارت
        /// </summary>
        public string HpayDte { get; set; }
        /// <summary>
        /// شماره حواله خسارت
        /// </summary>
        public string LosCmpDocNo { get; set; }
        /// <summary>
        /// نوع خسارت پرداختی
        /// </summary>
        public string LosTyp { get; set; }
        /// <summary>
        /// مبلغ خسارت
        /// </summary>
        public string PayAmnt { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
