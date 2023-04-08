namespace MFM;

public class jalase8
{
    public void find1399th()
        {
            int count = 0;
            int number = 1;
            while (count < 1400) 
            {
                if (p(number))
                {
                    count++;
                
                }
        
                number++;
            }
            Console.WriteLine(--number);
        }

        public bool p(int n)
        {
            if (n == 1)
            {
                return (true);
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return (false);
                }
            
            }

            return (true);
        }
    
}