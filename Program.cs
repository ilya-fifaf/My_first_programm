string text = Console.ReadLine();
int[] letter = new int [33];
char[] letters = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
string[] words = text.Split(new char[] { ' ', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
foreach (string word in words)
{
    for (int i = 0; i < word.Length; i++)
    {
        switch (word[i])
        {
            case 'а': letter[0]++; break;
            case 'б': letter[1]++; break;
            case 'в': letter[2]++; break;
            case 'г': letter[3]++; break;
            case 'д': letter[4]++; break;
            case 'е': letter[5]++; break;
            case 'ё': letter[6]++; break;
            case 'ж': letter[7]++; break;
            case 'з': letter[8]++; break;
            case 'и': letter[9]++; break;
            case 'й': letter[10]++; break;
            case 'к': letter[11]++; break;
            case 'л': letter[12]++; break;
            case 'м': letter[13]++; break;
            case 'н': letter[14]++; break;
            case 'о': letter[15]++; break;
            case 'п': letter[16]++; break;
            case 'р': letter[17]++; break;
            case 'с': letter[18]++; break;
            case 'т': letter[19]++; break;
            case 'у': letter[20]++; break;
            case 'ф': letter[21]++; break;
            case 'х': letter[22]++; break;
            case 'ц': letter[23]++; break;
            case 'ч': letter[24]++; break;
            case 'ш': letter[25]++; break;
            case 'щ': letter[26]++; break;
            case 'ъ': letter[27]++; break;
            case 'ы': letter[28]++; break;
            case 'ь': letter[29]++; break;
            case 'э': letter[30]++; break;
            case 'ю': letter[31]++; break;
            case 'я': letter[32]++; break;
        }
    }
}
for (int i = 0; i < letter.Length; i++)
{
    if (letter[i] % 10 == 1 && letter[i] % 100 != 11)
    {
        Console.WriteLine($"{letters[i]}-{letter[i]} раз");
    }
    else if (letter[i] % 10 >= 2 && letter[i] % 10 <= 4 && !(letter[i] % 100 >= 12 && letter[i] % 100 <= 14))
    {
        Console.WriteLine($"{letters[i]}-{letter[i]} раза");
    }
    else
    {
        Console.WriteLine($"{letters[i]}-{letter[i]} раз");
    }
}
