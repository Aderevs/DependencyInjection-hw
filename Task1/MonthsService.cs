using System.Collections;

namespace Task1
{

    public class MonthsService: IService
    {
        public IEnumerable GetCollection()
        {
            var collection = new Month[12];
            for(int i = 0; i < 12; i++)
            {
                collection[i] = (Month)i;
            }
            return collection;
        }
    }
}
