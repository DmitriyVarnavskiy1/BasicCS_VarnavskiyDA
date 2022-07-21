//Написать программу преобразования десятичного числа в двоичное

int n=16;//1111
string s="";
while (n!=0)
{
    s=(n%2)+s;    
    n/=2;//n=n/2
}
System.Console.WriteLine(s);

