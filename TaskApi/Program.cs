using MyApp;

//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddOpenApi();
//builder.Services.AddControllers();

//var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
//    app.MapOpenApi();
//}

//app.UseHttpsRedirection();
//app.MapControllers();

// This code WILL run on application startup
string input = "dotnet";
string reversed = StringReverser.Reverse(input);

Console.WriteLine(reversed);


int[] arr = { 1, 2, 3, 1, 2, 3, 5, 3, 5, 6, 8 };
int[] arr2 = { 1, 2, 3,5,4,7 };
string str = "madam";
string str3 = "Programming";

FindDuplicate.dupArr(arr);

RemoveDuplicates.Removedup(arr);
Console.Write("Below is from LINQ query based");
RemoveDuplicates.RmvDup(arr);
Console.WriteLine("Below is finding Second Largest Number");
SecondLargest.largestNum(arr2);
Console.WriteLine("Below is from LINQ query based");
SecondLargest.largestSecond(arr2);
Console.WriteLine("Palindrome check");
var res = Palindrome.isPalindrome(str);
Console.WriteLine(res);
Console.WriteLine("Character Counts");
var resp = CountChars.CountingChars(str3);

foreach(var kv in resp)
{
    Console.WriteLine($"{kv.Key} : {kv.Value}");
}

//app.Run();
