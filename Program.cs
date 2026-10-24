// Задание 1
// Console.WriteLine("Введите слово: ");
// string word = Console.ReadLine();
// int countA = 0;
// string lowerWord = word.ToLower();
// foreach (char c in lowerWord)
// {
//     if (c == 'а')
//     {
//         countA++;
//     }
// }
// Console.WriteLine($"Буква 'а' встречается: {countA} раз");

// Задание 2
// Console.WriteLine("Введите имя файла: ");
// string file = Console.ReadLine();
// string lowerFile = file.ToLower();

// if (lowerFile.EndsWith(".cs"))
// {
//     Console.WriteLine("Это файл C#");
// }
// else if (lowerFile.EndsWith(".png") || lowerFile.EndsWith(".jpg"))
// {
//     Console.WriteLine("Это изображение");
// }
// else
// {
//     Console.WriteLine("Неизвестный тип");
// }

// if (file.StartsWith("Lab"))
// {
//     Console.WriteLine("Это лабораторная работа");
// }

// if (lowerFile.Contains("test"))
// {
//     Console.WriteLine("Тестовый файл");
// }

// Задание 3
// Console.WriteLine("Введите фразу: ");
// string phrase = Console.ReadLine();
// Console.WriteLine(phrase.ToUpper());
// Console.WriteLine(phrase.Replace(" ", "_"));
// if (phrase.ToLower().Contains("стоп"))
// {
//     Console.WriteLine("Стоп-слово найдено!");
// }

// Задание 4
// Console.WriteLine("Введите дату в формате 2026-09-29: ");
// string date = Console.ReadLine();
// string year = date.Substring(0, 4);
// string month = date.Substring(5, 2);
// string day = date.Substring(8, 2);
// Console.WriteLine($"{day}.{month}.{year}");
// Console.WriteLine("Введите телефон из 11 цифр: ");
// string phone = Console.ReadLine();
// string code = phone.Substring(1, 3);
// string first = phone.Substring(4, 3);
// string second = phone.Substring(7, 2);
// string third = phone.Substring(9, 2);
// Console.WriteLine($"+7 ({code}) {first}-{second}-{third}");

// Задание 5
// Console.WriteLine("Введите строку для анализа: ");
// string text = Console.ReadLine();
// int spaces = 0;
// int vowels = 0;
// string vowelLetters = "аеёиоуыэюя";
// foreach (char c in text.ToLower())
// {
//     if (c == ' ')
//     {
//         spaces++;
//     }
//     if (vowelLetters.Contains(c))
//     {
//         vowels++;
//     }
// }
// Console.WriteLine($"Количество символов: {text.Length}");
// Console.WriteLine($"Количество пробелов: {spaces}");
// Console.WriteLine($"Количество гласных букв: {vowels}");

// Задание 6
// Console.WriteLine("Введите слово: ");
// string palindromeWord = Console.ReadLine();
// string reversed = "";
// for (int i = palindromeWord.Length - 1; i >= 0; i--)
// {
//     reversed += palindromeWord[i];
// }
// Console.WriteLine($"Перевёртыш: {reversed}");

// string lowerOriginal = palindromeWord.ToLower();
// string lowerReversed = reversed.ToLower();
// if (lowerOriginal == lowerReversed)
// {
//     Console.WriteLine("Это палиндром");
// }
// else
// {
//     Console.WriteLine("Это не палиндром");
// }

// Итоговая задача. «Проверка email»
// Console.WriteLine("Введите адрес электронной почты: ");
// string email = Console.ReadLine();
// bool isValid = true;
// string reason = "";

// if (email.Length < 5)
// {
//     isValid = false;
//     reason = "Длина меньше 5 символов";
// }
// int atCount = 0;
// foreach (char c in email)
// {
//     if (c == '@')
//     {
//         atCount++;
//     }
// }
// if (isValid && atCount != 1)
// {
//     isValid = false;
//     reason = "Символ @ должен быть ровно один";
// }
// if (isValid && (email.StartsWith("@") || email.EndsWith("@")))
// {
//     isValid = false;
//     reason = "Адрес не должен начинаться или заканчиваться на @";
// }
// if (isValid && email.Contains(" "))
// {
//     isValid = false;
//     reason = "В адресе есть пробелы";
// }
// string lowerEmail = email.ToLower();
// if (isValid && !(lowerEmail.EndsWith(".ru") || lowerEmail.EndsWith(".com")))
// {
//     isValid = false;
//     reason = "Адрес должен заканчиваться на .ru или .com";
// }

// if (isValid)
// {
//     Console.WriteLine("Адрес корректен");
//     Console.WriteLine(lowerEmail);
// }
// else
// {
//     Console.WriteLine("Адрес некорректен");
//     Console.WriteLine(reason);
// }

// Доп задание
using System.Text;
Console.WriteLine("Введите строку для удаления гласных: ");
string inputString = Console.ReadLine();
var sb = new StringBuilder();
string vowelsForRemove = "аейюуыэюяАЕЙЮУЫЭЮЯ";
foreach (char c in inputString)
{
    if (!vowelsForRemove.Contains(c))
    {
        sb.Append(c);
    }
}
Console.WriteLine(sb.ToString());