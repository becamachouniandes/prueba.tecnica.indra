

namespace prueba.tecnica.business
{
    public class ChallengeTwo
    {
        public int[] Test(int capacity,int space, int[] package)
        {
            int[] result = new int[2];

            int totalSpace = capacity - space;

            int max = 0;

            for(int i = 0; i< package.Length - 1 ; i++)
            {
                for(int j = i + 1; j < package.Length; j++)
                {
                    int value = package[i] + package[j];
                    if(value <= totalSpace && value >= max)
                    {
                        int packageMax = package[i] >= package[j] ? i : j;
                        int packageMin = package[i] >= package[j] ? j : i;

                        if ( value > max || package[packageMax] > result[0] )
                        {
                            result[0] = package[packageMax];
                            result[1] = package[packageMin];
                        }

                        max = value;
                    }
                }
            }

            return result;
        }
    }
}
