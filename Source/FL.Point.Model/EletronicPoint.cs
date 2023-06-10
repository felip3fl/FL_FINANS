
using FL.Model.Base;

namespace FL.Point.Model
{
    public class EletronicPoint : BaseModel
    {
        public DateTime Date { get; set; }
        public EletronicPointType Type { get; set; }

        //EF Relation
        protected EletronicPoint()
        { 
        }
            
        //public EletronicPoint(DateTime date, EletronicPointType type)
        //{
        //    Date = date;
        //    Type = new EletronicPointType(type);
        //}
    }
}
