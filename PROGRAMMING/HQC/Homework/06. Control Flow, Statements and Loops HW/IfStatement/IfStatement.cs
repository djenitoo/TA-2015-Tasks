namespace IfStatement
{
    public class IfStatement
    {
      private const int MinX = 0;
      private const int MaxX = 0;
      private const int MinY = 0;
      private const int MaxY = 0;

        public static void Main()
        {
            Potato potato = new Potato();
            if (potato != null && potato.HasBeenPeeled && potato.IsHealty)
            {
                Cook(potato);
            }

            int x = 0;
            int y = 0;
            bool isValidX = MinX <= x && x <= MaxX;
            bool isValidY = MinY <= y && y <= MaxY;
            bool shouldVisitCell = true;

            if (shouldVisitCell && isValidX && isValidY)
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            // TODO: Implement this method
            throw new System.NotImplementedException();
        }

        private static void Cook(Potato potato)
        {
            // TODO: Implement this method
            throw new System.NotImplementedException();
        }
    }
}
