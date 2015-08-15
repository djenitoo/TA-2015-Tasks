namespace Chef
{
    using System;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private void Peel(Vegetable vegetable)
        {
            throw new NotImplementedException();
        }

        private Carrot GetCarrot()
        {
            // TODO: Not implemented
            throw new NotImplementedException();
        }

        private Potato GetPotato()
        {
            // TODO: Not implemented
            throw new NotImplementedException();
        }

        private void Cut(Vegetable vegetable)
        {
            // TODO: Not implemented
            throw new NotImplementedException();
        }

        private Bowl GetBowl()
        {
            // TODO: Not implemented
            throw new NotImplementedException();
        }
    }
}
