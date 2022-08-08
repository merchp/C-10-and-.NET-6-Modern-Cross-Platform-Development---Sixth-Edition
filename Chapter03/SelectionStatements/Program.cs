using static System.Console; 

string passsword = "runningshot";
if (passsword.Length < 8)
{
    WriteLine("Password must be at least 8 characters long.");
}
else
{
    WriteLine("Password is valid.");
}

object o = 32;
int j = 4;
if (o is int i)
{
    WriteLine($"{i} * {j} = {i * j}");
}
else
{
    WriteLine("o is not an integer");
}

int number = (new Random()).Next(1, 7);
WriteLine($"The random number is {number}");
switch (number)
{
    case 1:
        WriteLine("One");
        break; // jumps to end of switch statement
    case 2: 
        WriteLine("Two");
        goto case 1;
    case 3: // multiple case section
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default case");
        break;
} // end of switch statement
WriteLine("End of switch");
A_label:
WriteLine("Reached the end of the switch.");

string path = @"/Users/chrishaunbyrom/Documents/C-10-and-dotNET-6-Modern-Cross-Platform-Development---Sixth-Edition/Code/Chapter03";
Write ("Press R for read-only, W for write-only");
ConsoleKeyInfo keyInfo = ReadKey(true);
WriteLine();
Stream? s;
if (keyInfo.Key == ConsoleKey.R)
{
   s = File.Open(
         Path.Combine(path, "file.txt"),
         FileMode.OpenOrCreate,
         FileAccess.Read);
}
else
{
    s = File.Open(
         Path.Combine(path, "file.txt"),
         FileMode.OpenOrCreate,
         FileAccess.Write);
}
string message;
switch (s)
{
    case FileStream writeableFile when s.CanWrite:
        message = "The stream is a file that I can write to.";
        break;
    case FileStream readOnlyFile:
        message = "The stream is a read-only file.";
        break;
    case MemoryStream ms:
        message = "The stream is a memory address.";
        break;
    default: //always evalute last despite its current position.
        message = "The stream is some other type.";
        break;  
    case null:
        message = "The stream is null.";
        break;
}
WriteLine(message);

message = s switch
{
    FileStream writeableFile when s.CanWrite
        => "The stream is a file that I can write to.",
    FileStream readOnlyFile
        => "The stream is a read-only file.",
    MemoryStream ms 
        => "The stream is a memory address.",
    null
    => "The stream is some other type.",
    _
    => "The stream is null."
};
WriteLine(message);