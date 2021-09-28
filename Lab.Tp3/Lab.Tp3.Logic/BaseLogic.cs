using Lab.Tp7.Data;

namespace Lab.Tp7.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext context;
        public BaseLogic()
        {
            context = new NorthwindContext();
        }

    }
}
