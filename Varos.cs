namespace Dolgozat1126
{
    internal class Varos
    {
        public string Nev { get; set; }
        public string Orszag { get; set; }
        public double Lakossag { get; set; }

        public Varos(string sor)
        {
            string[] s = sor.Split(';');
            Nev = s[0];
            Orszag = s[1];
            Lakossag = double.Parse(s[2]);
        }

        public override string ToString()
        {
            return $"{Nev} ({Orszag}) - {Lakossag:.00} millió fő";
        }
    }
}
