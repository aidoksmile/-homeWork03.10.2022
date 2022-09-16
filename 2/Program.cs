// Написать программу масштабирования фигуры Тут для тех кто далеко улетел, 
// чтобы задавались вершины фигуры списком (одной строкой) например: 
// "(0,0) (2,0) (2,2) (0,2)" коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5 
// В результате показать координаты, которые получатся. при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

Console.Write("Введите координаты вершин фигуры строкой вида: (0,0) (2,0) (2,2)...(0,2)   ");
string coordinates = Console.ReadLine();

string del1 = coordinates.Replace("(", "");
string del2 = del1.Replace(")", "");

string[] split = del2.Split(new Char[] { ' ' });

Console.Write("Введите коэффициент масштабирования:  ");
int k = int.Parse(Console.ReadLine());

Console.Write("Координаты вершин фигуры после масштабирования:");

for (int i = 0; i <= split.Length; i++)
{   
    string[] split1 = split[i].Split(new Char[] { ',' });
    Console.Write($"({(int.Parse(split1[0])) * k},{((int.Parse(split1[1])) * k)}) ");
}