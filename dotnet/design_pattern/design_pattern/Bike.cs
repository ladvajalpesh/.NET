namespace design_pattern {
    internal class Bike : Interface1 {
        private readonly int _wheels;
        public Bike() {
            this._wheels = 2;
        }
        public int numberofwheels() {
            return this._wheels;
        }

        public string vihical() {
            return "Bike";
        }
    }
}
