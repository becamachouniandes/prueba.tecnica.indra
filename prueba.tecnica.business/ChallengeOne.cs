
using System.Linq;

namespace prueba.tecnica.business
{
    public class ChallengeOne
    {
        public bool[] Test(bool[] houses, int days)
        {
            bool[] result = new bool[houses.Length];

            if (days > 0)
            {
                for (int d = 0; d < days; d++)
                {
                    for (int house = 0; house < houses.Length; house++)
                    {
                        if (house == 0)
                        {
                            result[0] = houses[1];
                        }
                        else if (house == houses.Length - 1)
                        {
                            result[houses.Length - 1] = houses[houses.Length - 2];
                        }
                        else
                        {
                            result[house] = houses[house - 1] != houses[house + 1];
                        }
                    }

                    houses = result.ToArray();
                }
            }

            return result;
        }
    }
}
