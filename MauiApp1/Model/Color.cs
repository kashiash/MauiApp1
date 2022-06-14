namespace MauiApp1.Model
{
    internal class Color
    {
        private double limitToScope(double x)
        {
            if (x < 0.0) return 0.0;
            else if (x > 1.0) return 1.0;
            else return x;
        }
        private double r, g, b;
        public double R
        {
            get => limitToScope(r);
            set { r = value; }
        }
        public double G
        {
            get => limitToScope(g);
            set { g = value; }
        }
        public double B
        {
            get => limitToScope(b);
            set { b = value; }
        }



        public Color(double r, double g, double b)
        {
            this.R = r;
            this.G = g;
            this.B = b;
        }
        public static Color Black { get; } =
            new Color(0.0, 0.0, 0.0);
    }
}