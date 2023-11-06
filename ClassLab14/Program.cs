using ClassLab14;

//IntList list = new IntList();
//list.Add(1);
//list.Add(2);
//list.Add(100);
//list.GetAll();

//StringList list = new StringList();

//list.Add("Oruc");
//list.Add("Semed");
//list.Add("Nurlan");

//list.GetAll();

//PersonList list = new PersonList();

//list.Add(new Person { Id = 1, Name = "Test1", Surname = "Test1"});
//list.Add(new Person { Id = 2, Name = "Test2", Surname = "Test2" });
//list.Add(new Person { Id = 3, Name = "Test3", Surname = "Test13" });

//list.GetAll();

//DataList<int> datas = new();
//datas.Add(5);
//datas.Add(10);

//datas.Add(20);

//datas.GetAll();

//DataList<string> stringList = new();
//stringList.Add("sdsd");
//stringList.Add("dsdsd");

//stringList.GetAll();

//DataList<Person> students = new();
//students.Add(new Person { Id = 1, Name = "Test1", Surname = "Test1" });
//students.Add(new Person { Id = 2, Name = "Test2", Surname = "Test12" });

//var res = students.GetAll();
//foreach (var item in res) 
//{
//    Console.WriteLine(item.Name);

//}

//List<Person> people = new List<Person>();

//people.Add(new Person { Id = 1, Name = "Test1", Surname = "Test1" });

//foreach (Person person in people) 
//{
//    Console.WriteLine(person.Name);
//}

//Repository<string> repo1 = new Repository<string>();
//Repository<int> repo2 = new Repository<int>();
//Repository<bool> repo3 = new Repository<bool>();
//Repository<Person> repo4 = new Repository<Person>();

//Repository<Person,BaseEntity> test = new Repository<Person,BaseEntity>();

//DataList<string> words = new DataList<string>();

//words.Add("Salam1");
//words.Add("Salam2");
//words.Add("Salam3");


//var datas = words.GetAll();

//foreach (var item in datas) 
//{
//    Console.WriteLine(item);
//}

//Repository<Person> repository = new Repository<Person>();
//repository.Add(new Person { Id = 1, Name = "Test1", Surname = "Test1" });


//Repository<Student> repository1 = new();

int paymentType = "Cash";

int tp = 2;
static void CheckPaymentType(int type) 
{
    switch (type) 
    {
        case nameof(PaymentType.Card):
            Console.WriteLine("With Card");
            break;
        default:
            break;
    
    
    }

    if (type == PaymentType.Card.ToString())
    {
        Console.WriteLine("With card");
    }
    else if (type == PaymentType.Cash.ToString()) 
    {
        Console.WriteLine("With Cash");


    }
    else
    {
        Console.WriteLine("Paymetn type is wrong");

    }

    CheckPaymentType(paymentType);
        


}













