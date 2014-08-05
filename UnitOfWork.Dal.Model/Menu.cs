namespace UnitOfWork.Dal.Model
{
    public class Menu
    {
        public virtual int MenuId { get; set; }
        public virtual string ItemName { get; set; }
        public virtual float Price { get; set; }
        public virtual Category Category { get; set; }
    }
}