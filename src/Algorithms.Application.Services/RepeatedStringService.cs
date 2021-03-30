namespace Algorithms.Application.Services
{
    public class RepeatedStringService : IRepeatedStringService
    {
        public long RepeatedString(string s, long n)
        {
            long size = s.Length;
            long repeated = n / size;
            long left = n - (size * repeated);
            int extra = 0;

            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (s[i] == 'a')
                    ++count;
            }

            for (int i = 0; i < left; i++)
            {
                if (s[i] == 'a')
                    ++extra;
            }

            repeated = (repeated * count) + extra;

            return repeated;
        }
    }
}
