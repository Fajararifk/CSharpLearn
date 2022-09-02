// abstract adalah blue print atau template untuk superclass(parent class), parent class akan mewarisi attribute dan method dari abstract class.
// ABSTRACT == INTERFACE, dimana akan di implementasikan di subclass.
// abstack punya attibute
// interface hanya kumpulan method

// CONTOH
// COBA BIKIN OBJEK MAKHLUK YG TAPI SETIAP MAKHLUK MEMIILIKI NAMA,

// HARUS ADA SUPER PARENT CLASS NYA

//CONTOH
// VEHICLE  ==> ABSTRACT CLASS
// ADA BAHAN BAKAR DAN CHICLETYPE DI VEHICLE
// CAR AND PLANE ==> PARENT CLASS DARI TAXI DAN CESSNA
//

using static System.Console;
using Day5;

Person person = new Customer("Yuli", "Ayu", "yuli@gmail.com", new DateTime(1998, 4, 24), "131-001");
Customer cust1 = new Customer("Rini", "Marlina", "rini@gmail.com", new DateTime(1999, 9, 30), "131-002"); // BISA ANTARA KEDUANYA
Customer cust2 = new Customer("Widi", "Amalia", "widi@gmail.com", new DateTime(1999, 8, 4), "131-003");

var listOfCustomer = new List<Person> { person, cust1, cust2};
foreach (var item in listOfCustomer)
{
    WriteLine(item);
}
