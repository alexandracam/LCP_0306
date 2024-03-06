// MIS 3013 001
// March 6, 2024
// Alexandra Camarena
// 113568154

Console.WriteLine("Void fucntion");

// define a function, will print out string for the specified times 
// void function

void PrintStrings(string str, int times)
{
    for (int i = 0; i < times; i = i + 1)
    {
        Console.WriteLine(str);
    }
}

PrintStrings("MIS3013", 20);