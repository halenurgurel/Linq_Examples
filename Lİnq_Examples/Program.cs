//Rastgele 10 adet sayıdan oluşan bir liste oluşturunuz. Bu liste üzerinden aşağıdaki linq sorgularını çalıştırarak konsol ekranına istenilenleri yazdırınız.

//numbers listesinde rastgele 10 tane sayı tanımladık

Random rand = new Random(); //rastgele sayı üretici

List<int> numbers = new List<int>(); //Listemizi tanımladık.

for ( int i = 0; i < 10; i++) //for ile 10 tane sayı alacağımızı bildirerek döndürdük.
{
    numbers.Add(rand.Next(-50, 50)); //sayıların -50 ve 50 aralığında olması gerektiğini belirttik.
}

//Rastgele sayıları tanımlıyoruz.

Console.Write("Tüm Sayılar: ");
foreach ( var allNumbers in numbers)
{
    Console.Write($"{allNumbers} ");
}

Console.WriteLine(" ");
Console.WriteLine(" ");

//Çift olan sayılar
Console.Write("Çift Sayılar: ");

var evenNumbers = numbers.Where(number => number % 2 == 0);

foreach (var number in evenNumbers)
{
    Console.Write($"{number} ");
}

Console.WriteLine(" ");
Console.WriteLine(" ");


//Tek olan sayılar
Console.Write("Tek Sayılar: ");

var oddNumbers = numbers.Where(number => number % 2 != 0);

foreach (var number in oddNumbers)
{
    Console.Write($"{number} ");
}

Console.WriteLine(" ");
Console.WriteLine(" ");



//Negatif sayılar
Console.Write("Negatif Sayılar: ");

var negativeNumbers = numbers.Where(number => number < 0);

foreach (var number in negativeNumbers)
{
    Console.Write($"{number} ");
}

Console.WriteLine(" ");
Console.WriteLine(" ");


//Pozitif sayılar
Console.Write("Pozitif Sayılar: ");

var positiveNumbers = numbers.Where(number => number > 0);

foreach (var number in positiveNumbers)
{
    Console.Write($"{number} ");
}

Console.WriteLine(" ");
Console.WriteLine(" ");


//15'den büyük ve 22'den küçük sayılar
Console.Write("15'den büyük 22'den küçük sayılar: ");

var specificNumbers = numbers.Where(number => number > 15 && number < 22);

foreach (var number in specificNumbers)
{
    Console.Write($"{number} ");
}

Console.WriteLine(" ");
Console.WriteLine(" ");



//Listedeki her bir sayının karesi
Console.Write("Listedeki sayıların karesi: ");

var squareNumbers = numbers.Select(number => number * number);

foreach (var number in squareNumbers)
{
    Console.Write($"{number} ");
}

Console.WriteLine(" ");
Console.WriteLine(" ");


