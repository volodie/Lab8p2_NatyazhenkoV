
//Создать классы "Директор", "Рабочий", "Бухгалтер".
//Реализовать интерфейс с методом, который печатает название должности и имплементировать этот метод в созданные класс

using JobTitle;

internal class Program
{
    private static void Main(string[] args)
    {

        var director = new Director();
        var worker = new Worker(); 
        var accountant = new Accountant();
        director.PrintJobTitile("Director");
        worker.PrintJobTitile("Worker");
        accountant.PrintJobTitile("Accountant");
    }
}