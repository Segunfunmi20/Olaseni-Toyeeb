using System; 
class Solution{
    static void Main(String[]args){
        int i = 4; 
        double d = 4.0; 
        string s = "PolyIlaro "; 
        int num1;
        double num2; 
        string text; 
        Console.WriteLine("Enter an integer value"); 
        num1 = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Enter a double value"); 
        num2 = double.Parse(Console.ReadLine()); 
        Console.WriteLine("Enter the text: "); 
        text = Console.ReadLine();

        Console.WriteLine(num1 + i);
        Console.WriteLine(num2 + d); 
        Console.WriteLine(s + text);

    }
}
