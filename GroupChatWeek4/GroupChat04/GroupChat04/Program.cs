namespace GroupChat04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HAND:         Score: 0        Aces: 0
            //Hand: A(11)       Score: 11   Aces: 1
            //Hand: A(11),6     Score: 17   Aces: 1
            //Hand: A(1),6,8   Score: 15    Aces: 0.
            //when score > 21 and aces > 0 subtract 10 from score and 1 from aces

            //Hand: A(1),6,8,10   Score: 25 Aces: 0

            //Hand: Score: 0 Aces: 0
            //Hand: A(11)   Score: 11   Aces: 1
            //Hand: A(1),A(11)     Score: 12   Aces: 1
            //Hand: A(1),A(1), 10  Score: 12   Aces: 0

            //Print(20, 7);
            DrawTable();

            while (true)
            {
                //Print(10, 5);
                DrawTable();

                int num = 0;
                switch (num)
                {
                    case 0:
                        continue;
                    default:
                        break;
                }
            }
        }

        static void DrawTable()
        {
            //Print(10, 5);
        }
    }
}