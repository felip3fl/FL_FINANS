
using FL.Model.Base;

namespace FL.Point.Model
{
    public class EletronicPoint : BaseModel
    {
        public DateTime Date { get; set; }
        public EletronicPointType Type { get; set; }
    }
}
