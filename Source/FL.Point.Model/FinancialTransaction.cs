using FL.Model.Base;

namespace FL.Model
{
    public class FinancialTransaction : BaseModel
    {
        public string Bank { get; set; }
        public string Description { get; set; }
        public string Local { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public Double Value { get; set; }
        public string Details { get; set; }
    }
}