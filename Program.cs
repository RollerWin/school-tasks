class Program
{   
    const string CommandAddEmployee = "add";
    const string CommandShowEmployees = "show";
    const string CommandDeleteEmployee = "delete";
    const string CommandSearchEmplyee = "search";
    const string CommandExit = "exit";

    static void Main(string[] args)
    {
        int defaultSize = 0;
        string[] employeeNames = new string[defaultSize];
        string[] employeePositions = new string[defaultSize];
        bool isRun = true;

        while(isRun)
        {
            ShowMenu();
            HandleUserInput(ref employeeNames, ref employeePositions, ref isRun);
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void HandleUserInput(ref string[] employeeNames, ref string[] employeePositions, ref bool isRun)
    {
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
    } 

    static void ShowMenu()
    {
        Console.WriteLine("<---Консоль управления персоналом--->");
        Console.WriteLine($"{CommandAddEmployee} - Добавить нового сотрудника\n" +
                        $"{CommandShowEmployees} - Показать всех текущих сотрудников\n" +
                        $"{CommandDeleteEmployee} - Удалить сотрудника\n" +
                        $"{CommandSearchEmplyee} - Найти сотрудника по фамилии\n" +
                        $"{CommandExit} - Выход");
    }

    static string[] FillArray(string[] array, string userInput)
    {
        string[] newArray = new string[array.Length + 1];

        for(int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }

        newArray[newArray.Length - 1] = userInput;
        array = newArray;
        return array;
    }

    static string[] DeleteElementByIndex(string[] array, int skippedIndex)
    {
        string[] newArray = new string[array.Length - 1];

        for(int i = 0; i < skippedIndex; i++)
        {
            newArray[i] = array[i];
        }

        for(int i = skippedIndex + 1; i < array.Length; i++)
        {
            newArray[i - 1] = array[i];
        }

        return newArray;
    }

    static void AddEmployee(ref string[]names, ref string[]positions)
    {
        Console.WriteLine("Введите ФИО сотрудника: ");
        string userInput = Console.ReadLine();
        names = FillArray(names, userInput);

        Console.WriteLine("Введите должность сотрудника: ");
        userInput = Console.ReadLine();
        positions = FillArray(positions, userInput);
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
        
        Console.WriteLine("Укажите индекс сотрудника или фио целиком");
        string userInput = Console.ReadLine();

        if(newLength >= 0)
        {
            int employeeIndex;
            bool canCopy = false;

            if(int.TryParse(userInput, out employeeIndex))
            {
                if(--employeeIndex >= 0)
                {
                    canCopy = true;
                }
                else
                {
                    Console.WriteLine("Неверно задан индекс!");
                }
            }
            else
            {
                for(int i = 0; i < names.Length; i++)
                {
                    if(names[i] == userInput)
                    {
                        employeeIndex = i;
                        Console.WriteLine($"Найден сотрудник под индексом {employeeIndex + 1}");
                        canCopy = true;
                    }
                    else
                    {
                        Console.WriteLine("Сотрудник с таким ФИО не найден!");
                    }
                }
            }

            if(canCopy == true)
            {
                names = DeleteElementByIndex(names, employeeIndex);
                positions = DeleteElementByIndex(positions, employeeIndex);
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