
namespace HW
{
    class HW1
    {
        public static long QueueTime(int[] customers, int n) {
            int time = 0;
            int[] cashiers = new int[n];
            for (int i = 0; i < n; i++) {
                cashiers[i] = 0;
            }
            int queuelen;
            if (n > customers.Length)
            {
                queuelen = 0;
            }
            else {
                queuelen = customers.Length - n;
            }
            int queuenum;
            if (n > customers.Length)
            {
                queuenum = 0;
            }
            else
            {
                queuenum = n;
            }
            int count = 0;

            for (int i = 0; i < (n < customers.Length ? n : customers.Length); i++) {
                cashiers[i] = customers[i];
            }

            while (true) {
                time++;
                count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (cashiers[i] > 0)
                    {
                        cashiers[i]--;
                        if (cashiers[i] == 0)
                        {
                            if (queuelen == 0)
                            {
                                count++;
                            }
                            else
                            {
                                cashiers[i] = customers[queuenum++];
                                queuelen--;
                            }
                        }
                    }
                    else
                    {
                        if (queuelen == 0)
                        {
                            count++;
                        }
                        else
                        {
                            cashiers[i] = customers[queuenum++];
                            queuelen--;
                        }
                    }
                }
                if (count == n)
                    return time;
            }
        }
    }
}
