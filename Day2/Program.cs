using Day2;
using static System.Console;

/*
 * //ArrayClass.IntroArray();

// CALL METHOD FUNCTION DARI RETURN
//int[] n = { 10, 20, 40, 50 };
//var myArray = ArrayClass.InitArrayInt(n});
*//*var myArray = ArrayClass.InitArrayInt(new int[] {10,20,40,50});

ArrayClass.DisplayArray(myArray);*//*

var myRandom = ArrayClass.InitArrayRandom(20);

ArrayClass.DisplayArray(myRandom);
WriteLine();
WriteLine($"Total Sum Random dari adalah {ArrayClass.FindSumElement(myRandom)}");
WriteLine();
WriteLine($"Nilai Terbesar dari array ini adalah {ArrayClass.FindLargestElement(myRandom)}");
WriteLine($"Nilai Terkecil dari array ini adalah {ArrayClass.FindSmallestElement(myRandom)}");
WriteLine($"Nilai Terbesar Kedua dari array ini adalah {ArrayClass.GreatestSecond(myRandom)}");
// COPY ARRAY
Console.WriteLine("=================COPY==================");
int[] newArray = new int[myRandom.Length];
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = myRandom[i];
}
WriteLine();
ArrayClass.DisplayArray(newArray);
WriteLine();
var randomArray = new int[myRandom.Length];
Array.Copy(newArray, 0, randomArray, 0, newArray.Length);
// SORT ARRAY;
Console.WriteLine("\n=================REVERSED==================\n");
Array.Reverse(newArray);
ArrayClass.DisplayArray(newArray);

Console.WriteLine("\n=================SORT==================\n");
Array.Sort(newArray);
ArrayClass.DisplayArray(newArray);
*/
/*Day2.Matrix.InitMatrix();
var myMatrix = Day2.Matrix.FillRandomMatrix(5, 5);
Day2.Matrix.DisplayMatrix(myMatrix);*/
WriteLine();
//diagonal
//var diagonal = Matrix.MatrixDiagonal(5, 5);
//Matrix.DisplayMatrix(diagonal);
//Matrix.DisplayMatrix(diagonal);

/*var randomDiagonal = Matrix.MatrixDiagonalRandom(5, 5);
Matrix.DisplayMatrix(randomDiagonal);*/

/*var box = Matrix.MatrixBox(7, 7);
Matrix.DisplayMatrix(box);*/

/*var box2 = Matrix.MatrixBox2(8, 8);
Matrix.DisplayMatrix(box2);*/

int[] arr = { 5, 2, 30, 12, 10, 5, 2, 10, 5 };

var muncul = Matrix.MunculBerapa(arr);

/*int[] arr = { 1, 5, 3, 7, 8, 5, 1 };
var duplicate = Matrix.Duplicate(arr);*/

char[,] scores = new char[,] {
    { 'A', 'B', 'A', 'C', 'C', 'D', 'E', 'E', 'A', 'D' } ,
    { 'D', 'B', 'A', 'B', 'C', 'A', 'E', 'E', 'A', 'D' } ,
    { 'E', 'D', 'D', 'A', 'C', 'B', 'E', 'E', 'A', 'D' } ,
    { 'C', 'B', 'A', 'E', 'D', 'C', 'E', 'E', 'A', 'D' } ,
    { 'A', 'B', 'D', 'C', 'C', 'D', 'E', 'E', 'A', 'D' } ,
    { 'B', 'B', 'E', 'C', 'C', 'D', 'E', 'E', 'A', 'D' } ,
    { 'B', 'B', 'A', 'C', 'C', 'D', 'E', 'E', 'A', 'D' } ,
    { 'E', 'B', 'E', 'C', 'C', 'D', 'E', 'E', 'A', 'D' } ,
};

char[] keys = new char[] { 'D', 'B', 'D', 'C', 'C', 'D', 'A', 'E', 'A', 'D' };

//var siswa = Day2.Matrix.Student(scores, keys);


ReadLine();