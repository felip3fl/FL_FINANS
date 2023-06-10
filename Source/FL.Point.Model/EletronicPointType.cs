using FL.Model.Base;

namespace FL.Point.Model
{
    public class EletronicPointType : BaseModel
    {
        public string Name { get; set; }

        //Contrutor do EF
        protected EletronicPointType()
        {

        }

        public EletronicPointType(string name)
        {
            name = Name;
        }
    }
}
