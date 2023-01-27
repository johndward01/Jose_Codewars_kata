var height = Height(7);
Console.WriteLine(height);


static string Height(int n)
{
    double catInHat = 2_000_000;
    double sum = 2_000_000;
    if (n == 0)
    {
        return catInHat.ToString();
    }

    sum += double.Parse(Height(n - 1)) / 2.5 ;

    return $"{sum:N3}";

}