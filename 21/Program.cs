Console.WriteLine("Введите координату точки XA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки ZA: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки YB: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки ZB: ");
int zb = Convert.ToInt32(Console.ReadLine());
double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
   double xc = (xb - xa) * (xb - xa);
   double yc = (yb - ya) * (yb - ya);
   double zc = (za - zb) * (za - zb);
   double result = Math.Sqrt(xc + yc + zc);
   return result;
}
double res = Distance(xa, ya, za, xb, yb, zb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);