using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task14._3._3
{
    // Доработайте вашу телефонную книгу из задания 14.2.10 предыдущего юнита так,
    // чтобы контакты телефонной книги были отсортированы сперва по имени, а затем по фамилии.
    class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            var sortedPhoneBook = phoneBook
                .OrderBy(pb => pb.Name)
                .ThenBy(pb => pb.LastName);
         
            foreach (var item in sortedPhoneBook)
                Console.WriteLine($"{item.Name} {item.LastName}: телефон - {item.PhoneNumber}, E-mail - {item.Email}");
            Console.ReadKey();
        }
    }
}
