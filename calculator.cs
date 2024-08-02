using System;

class Program
{
    static void Main()
    {
        double num1, num2;
        string operation;

        Console.WriteLine("Basit Hesap Makinesi");
        Console.WriteLine("--------------------");

        // İlk sayıyı al
        Console.Write("Birinci sayıyı girin: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        // İkinci sayıyı al
        Console.Write("İkinci sayıyı girin: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // İşlemi al
        Console.Write("Yapmak istediğiniz işlemi seçin (+, -, *, /): ");
        operation = Console.ReadLine();

        double result = 0;
        bool isValidOperation = true;

        // İşlem seçimine göre hesaplama yap
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                // Bölme işlemi için sıfıra bölme kontrolü yap
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Hata: Sıfıra bölme hatası!");
                    isValidOperation = false;
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem seçimi.");
                isValidOperation = false;
                break;
        }

        // Sonucu göster
        if (isValidOperation)
        {
            Console.WriteLine("Sonuç: " + result);
        }

        Console.WriteLine("Hesaplama tamamlandı. Çıkmak için bir tuşa basın.");
        Console.ReadKey();
    }
}
