namespace BankProj;

public class Bank // Класс відповідно до варіанту 
{
    public string Name { get; set; } //Деякі поля відповідно до лаб 1
    public string Address { get; set; }
    private static int id = 0;  // Статичне поле лаб 2
    private int currentBankId;  // Поточний номер банку

    public Bank(string Name, string Address)
    {
        this.Name = Name;
        this.Address = Address;
        id++; // Збільшення на 1 при створенні нового банку 
        currentBankId = id; //Присвоєння айди певному банку
    }
    public int GetBankId() => currentBankId; //Повернути айді банку
    public static int NumberOfBanks() => id; //Повернути кількість банків
}
