using System.Collections;

namespace Task1
{
    public class WeekService: IService
    {
        public IEnumerable GetCollection()
        {
            DayOfWeek[] collection = new DayOfWeek[7];
            for (int i = 0; i < 7; i++)
            {
                collection[i] = (DayOfWeek)i;
            }
            return collection;
        }
    }
}
