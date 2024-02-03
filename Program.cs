class Program
{   
    static void Main(string[] args)
    {
        const string CommandAddEmployee = "add";
        const string CommandShowEmployees = "show";
        const string CommandDeleteEmployee = "delete";
        const string CommandSearchEmplyee = "search";
        const string CommandExit = "exit";

        int defaultSize = 0;
        string[] employeeNames = new string[defaultSize];
        string[] employeePositions = new string[defaultSize];
        bool isRun = true;

        while(isRun)
        {
            Console.WriteLine("<---Консоль управления персоналом--->");
            Console.WriteLine($"{CommandAddEmployee} - Добавить нового сотрудника\n" +
                            $"{CommandShowEmployees} - Показать всех текущих сотрудников\n" +
                            $"{CommandDeleteEmployee} - Удалить сотрудника\n" +
                            $"{CommandSearchEmplyee} - Найти сотрудника по фамилии\n" +
                            $"{CommandExit} - Выход");

            string userInput = Console.ReadLine(); 
            
            switch(userInput)
            {
                case CommandAddEmployee:
                    AddEmployee(ref employeeNames, ref employeePositions);
                break;

                case CommandShowEmployees:
                    ShowEmployees(employeeNames, employeePositions);
                break;

                case CommandSearchEmplyee:
                    SearchEmployee(employeeNames, employeePositions);
                break;

                case CommandDeleteEmployee:
                    DeleteEmployee(ref employeeNames, ref employeePositions);
                break;

                case CommandExit:
                    isRun = false;
                break;

                default:
                    Console.WriteLine("Неверная команда!");
                break;
            }
            
            Console.ReadKey();
            Console.Clear();
        }
    }

    static string[] AddData(string[] array, string userInput)
    {
        string[] tempArray = new string[array.Length + 1];

        for(int i = 0; i < array.Length; i++)
        {
            tempArray[i] = array[i];
        }

        tempArray[tempArray.Length - 1] = userInput;
        array = tempArray;
        return array;
    }

    static string[] DeleteElementByIndex(string[] array, int skippedIndex)
    {
        string[] tempArray = new string[array.Length - 1];

        for(int i = 0; i < skippedIndex; i++)
        {
            tempArray[i] = array[i];
        }

        for(int i = skippedIndex + 1; i < array.Length; i++)
        {
            tempArray[i - 1] = array[i];
        }

        return tempArray;
    }

    static void AddEmployee(ref string[]names, ref string[]positions)
    {
        Console.WriteLine("Введите ФИО сотрудника: ");
        string userInput = Console.ReadLine();
        names = AddData(names, userInput);

        Console.WriteLine("Введите должность сотрудника: ");
        userInput = Console.ReadLine();
        positions = AddData(positions, userInput);
    }

    static void ShowEmployees(string[] names, string[]positions)
    {
        Console.WriteLine("Все текущие сотрудники:");
        
        for(int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"{i+1}  {names[i]} - {positions[i]}");
        }
    }

    static void DeleteEmployee(ref string[]names, ref string[]positions)
    {
        int newLength = names.Length - 1;
        
        Console.WriteLine("Укажите индекс сотрудника");
        string userInput = Console.ReadLine();

        if(newLength >= 0)
        {
            int employeeIndex;

            if(int.TryParse(userInput, out employeeIndex))
            {
                if(--employeeIndex >= 0)
                {
                    names = DeleteElementByIndex(names, employeeIndex);
                    positions = DeleteElementByIndex(positions, employeeIndex);
                }
                else
                {
                    Console.WriteLine("Неверно задан индекс!");
                }
            }
            else
            {
                Console.WriteLine("Необходимо указать целое число - индекс сотрудника");
            }
        }
        else
        {
            Console.WriteLine("База пуста! Удалить невозможно!");
        }
    }

    static void SearchEmployee(string[] names, string[] positions)
    {
        bool isFound = false;
        Console.WriteLine("Введите Фамилию сотрудника:");
        string lastName = Console.ReadLine();

        for(int i = 0; i < names.Length; i++)
        {
            if(lastName.ToLower() == ExtractLastName(names[i]).ToLower())
            {
                Console.WriteLine($"{i + 1} {names[i]} - {positions[i]}");
                isFound = true;
            }
        }

        if(isFound == false)
        {
            Console.WriteLine($"Сотрудник с фамилией {lastName} не найден!");
        }
    }

    static string ExtractLastName(string employeeName)
    {
        int firstIndex = 0;
        char spaceSymbol = ' ';
        int firstSpaceBetweenNames = employeeName.IndexOf(spaceSymbol);
        string employeeLastName = employeeName.Substring(firstIndex, firstSpaceBetweenNames);
        return employeeLastName;
    }
}