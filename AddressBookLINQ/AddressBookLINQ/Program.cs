using System;
namespace AddressBookLINQ
{
    public class  Program
    {
        public static void Main(string[] args)
        {
            Contact contactData = new Contact();
            Contact contactData2 = new Contact();
            AddressBook addressBook = new AddressBook();

            addressBook.CreateDataTable();
            contactData.ID = 1;
            contactData.FirstName = "Rajvardhan";
            contactData.LastName = "Singh";
            contactData.PhoneNumber = 8439560765;
            contactData.Email = "rajvardhan.2627@gmail.com";
            contactData.Address = "Himalayan Colony";
            contactData.City = "Najibabad";
            contactData.State = "UP";
            contactData.zip = 246763;
            contactData.Type = "Family";
            addressBook.InsertintoDataTable(contactData);

            contactData2.ID = 2;
            contactData2.FirstName = "Kshitij";
            contactData2.LastName = "Puri";
            contactData2.PhoneNumber = 7012657852;
            contactData2.Email = "puri.kshitij@gmail.com";
            contactData2.Address = "IIT Road";
            contactData2.City = "Roorke";
            contactData2.State = "UK";
            contactData2.zip = 247001;
            contactData2.Type = "Friends";
            addressBook.InsertintoDataTable(contactData2);

            addressBook.Display();

        }
    }
}
