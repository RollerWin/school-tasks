class Program
{
    const string commandAddEmployee = "add";
    const string commandShowEmployees = "show";
    const string commandDeleteEmployee = "delete";
    const string commandSearchEmplyee = "search";
    const string commandExit = "exit";
    
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
            case commandAddEmployee:
                Console.WriteLine("Введите ФИО сотрудника: ");
                userInput = Console.ReadLine();
                employeeNames = FillArray(employeeNames, userInput);

                Console.WriteLine("Введите должность сотрудника: ");
                userInput = Console.ReadLine();
                employeePositions = FillArray(employeePositions, userInput);
            break;

            case commandShowEmployees:
                Console.WriteLine("Все текущие сотрудники:");
                ShowEmployees(employeeNames, employeePositions);
            break;

            case commandSearchEmplyee:
                Console.WriteLine("Введите Фамилию сотрудника:");
                userInput = Console.ReadLine();
                SearchEmployee(employeeNames, userInput);
            break;

            case commandDeleteEmployee:
                Console.WriteLine("Укажите индекс сотрудника или фио целиком");
                userInput = Console.ReadLine();
                DeleteEmployee(ref employeeNames, ref employeePositions, userInput);
            break;

            case commandExit:
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
        Console.WriteLine($"{commandAddEmployee} - Добавить нового сотрудника\n" +
                        $"{commandShowEmployees} - Показать всех текущих сотрудников\n" +
                        $"{commandDeleteEmployee} - Удалить сотрудника\n" +
                        $"{commandSearchEmplyee} - Найти сотрудника по фамилии\n" +
                        $"{commandExit} - Выход");
    }

    static string[] FillArray(string[] array, string userInput)
    {
        string[] newArray = new string[array.Length + 1];

        CopyArrayToBigger(newArray, array);

        newArray[newArray.Length - 1] = userInput;
        array = newArray;
        return array;
    }

    static void CopyArrayToBigger(string[] newArray, string[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }
    }

    static void CopyArrayToSmaller(string[] newArray, string[] array, int skippedIndex)
    {
        int j = 0;

        for(int i = 0; i < array.Length; i++)
        {
            if(i != skippedIndex)
            {
                newArray[j++] = array[i];
            }
        }
    }

    static void ShowEmployees(string[] names, string[]positions)
    {
        for(int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"{i+1}  {names[i]} - {positions[i]}");
        }
    }

    static void DeleteEmployee(ref string[]names, ref string[]positions, string userInput)
    {
        int newLength = names.Length - 1;
        
        if(newLength >= 0)
        {
            int employeeIndex;

            bool canCopy = false;

            string[] newEmployeeNames = new string[newLength];
            string[] newEmployeesPositions = new string[newLength];

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
                    }
                }

                canCopy = true;
            }

            if(canCopy == true)
            {
                CopyArrayToSmaller(newEmployeeNames, names, employeeIndex);
                CopyArrayToSmaller(newEmployeesPositions, positions, employeeIndex);
                names = newEmployeeNames;
                positions = newEmployeesPositions;
            }
        }
        else
        {
            Console.WriteLine("База пуста! Удалить невозможно!");
        }
    }

    static void SearchEmployee(string[] names, string lastName)
    {
        bool isFound = false;

        for(int i = 0; i < names.Length; i++)
        {
            if(lastName.ToLower() == ExtractLastName(names[i]).ToLower())
            {
                Console.WriteLine(names[i]);
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
        int firstSpaceBetweenNames = employeeName.IndexOf(' ');
        string employeeLastName = employeeName.Substring(firstIndex, firstSpaceBetweenNames);
        return employeeLastName;
    }
}