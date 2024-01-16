using System.Text;
using GroupingOfPeople.Classes;

int counter=0;
int puse=0;
string str ;
bool Countinue= true;
while (Countinue)
{
try
{
 Console.WriteLine("Specify the maximum number of members in a group. >>> ");
 byte Count =Convert.ToByte(Console.ReadLine());
 Console.WriteLine("Define members and seprate with ( , Or . Or -) . >>> ");
str=(Console.ReadLine()??"");
string[] spearator = { ",", ".","-" }; 
string[] Members = str.Split(spearator,100,StringSplitOptions.TrimEntries); 
int group= (int)Members.Length / Count ; 
int ungroup=(int)Members.Length % Count;
Console.BackgroundColor=ConsoleColor.Green;
Console.Write($"Create {group} Group .");
Console.BackgroundColor=ConsoleColor.Red;
if (ungroup>0)
{
Console.Write($"A group has {ungroup} members.\n");
}
Console.ResetColor();
List<int> ints = RandomUnicNumber.Generate(Members.Length-1,Members.Length);
StringBuilder strbld =new();
for (int a = 0; a < group; a++)
{
    
    strbld.Append($"\nGroup{a+1} : ");
    

    while (puse<Count)
    {
        strbld.Append(Members[ints[counter]]+" , ");
        counter++;
        puse++;
    }
      strbld.Append("\n");
      puse=0;
      if (a==group-1 && ungroup>0)
      {
        
        strbld.Append($"\nGroup{a+2} : ");
       
        for (int b = 0; b < ungroup; b++)
        {
         strbld.Append(Members[ints[counter]]+" , ");
         counter++;
        }
         Console.ResetColor();
        strbld.Append("\n");
      }
}
   Console.WriteLine(strbld);
   Console.WriteLine("Do it one more time. >>> (y/n)");
   string unpuse=Convert.ToString(Console.ReadLine()??"");
    unpuse=unpuse.ToLower();
   if (unpuse=="y")
   {
    Countinue=true;
    counter=0;
    puse=0;
    str="" ;
   }else{
    Countinue=false;
   }
}
catch (Exception e)
{
    Console.WriteLine($"Erro is : {e.Message}");
    Countinue=true;
}
}

