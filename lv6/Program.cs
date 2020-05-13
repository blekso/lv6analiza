using lv6.components;
using System;

namespace lv6
{
    class Program
    {

        static void Main()
        {
            //Zadatak1();
            //Zadatak2();
            //Zadatak3();
            //Zadatak4();
            //Zadatak5();
            //Zadatak6();
            Zadatak7();
        }

        static void Zadatak1()
        {
            Note note1 = new Note("Naslov1", "RandText1");
            Note note2 = new Note("Naslov2", "RandText2");
            Note note3 = new Note("Naslov3", "RandText3");
            Notebook notebook = new Notebook();
            notebook.AddNote(note1);
            notebook.AddNote(note2);
            notebook.AddNote(note3);

            Iterator iterator = new Iterator(notebook);
            iterator.First().Show();
            iterator.Current.Show();
            iterator.Next().Show();
        }

        static void Zadatak2()
        {
            Product product1 = new Product("Header1", 10);
            Product product2 = new Product("Header2", 20);
            Product product3 = new Product("Header3", 30);
            Box box = new Box();
            box.AddProduct(product1);
            box.AddProduct(product2);
            box.AddProduct(product3);

            ProductIterator iterator = new ProductIterator(box);
            iterator.First().Show();
            iterator.Current.Show();
            iterator.Next().Show();
        }
        //static void Zadatak3()
        //{
        //    CareTaker caretaker = new CareTaker();

        //    ToDoItem todoitem1 = new ToDoItem("Title1", "Text1", DateTime.Now);
        //    caretaker.AddState(todoitem1.StoreState());

        //    ToDoItem todoitem2 = new ToDoItem("Title2", "Text2", DateTime.Now);
        //    caretaker.AddState(todoitem2.StoreState());

        //    caretaker.ShowItems();
        //}
        static void Zadatak4()
        {
            CareTaker caretaker = new CareTaker();
            BankAccount bankaccount1 = new BankAccount("Mihael", "Koprivnica", 200);
            caretaker.AddState(bankaccount1.StoreState());

            BankAccount bankaccount2 = new BankAccount("Opet Mihael", "Koprivnica", 400);
            caretaker.AddState(bankaccount2.StoreState());

            caretaker.ShowItems();
        }

        static void Zadatak5()
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger =
                new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");
            logger.SetNextLogger(fileLogger);
            logger.Log("message", MessageType.WARNING);
        }

        static void Zadatak6()
        {
            StringChecker stringDigitChecker = new StringDigitChecker();
            StringLengthChecker stringLengthChecker = new StringLengthChecker();
            StringUpperCaseChecker stringUpperCaseChecker = new StringUpperCaseChecker();
            StringLowerCaseChecker stringLowerCaseChecker = new StringLowerCaseChecker();

            string stringtocheck = "Mihael1";

            stringDigitChecker.Set(stringLengthChecker, stringtocheck);
            stringLengthChecker.Set(stringUpperCaseChecker, stringtocheck);
            stringUpperCaseChecker.Set(stringLowerCaseChecker, stringtocheck);
            stringLowerCaseChecker.Set(stringtocheck);

            if (stringDigitChecker.Check("Mihael1")) Console.WriteLine("Success!");
        }

        static void Zadatak7()
        {
            
        }
    }
}
