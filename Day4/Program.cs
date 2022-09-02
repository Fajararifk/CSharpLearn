using Day3;

Day3.MyCollection.InitList();
MyCollection.InitStack();
MyCollection.InitDictionary();
MyCollection.InitHashSet();
MyCollection.InitQueue();

// DECLARE LIST<T>

var list = new List<string> { "Asep", "Budi", "Charlie" };
var student = MyCollection.GetStudent(ref list);

foreach (var item in student)
{
    Console.WriteLine($"{item}");
}

var numbers = new List<int> { 1, 2, 3, 4, 5, 6 } ;
var myNumber = MyCollection.GetStudent(ref numbers);
foreach (var item in myNumber)
    Console.WriteLine(item);
