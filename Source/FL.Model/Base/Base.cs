namespace FL.Model.Base
{
    public abstract class BaseModel
    {
        #region Properties
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }

        #endregion
    }
}
