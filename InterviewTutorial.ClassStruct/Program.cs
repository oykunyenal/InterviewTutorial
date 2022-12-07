// Class - reference type
// Struct - value type
// Struct cannot be null while assigning (UserStruct userStruct == null) cannot happen.

/*
              1) Assignments
              2) Interface implentation
              3) Struct cannot be null, can be nullable
              4) Parameterless constructor ( Array calls parameterless ) (C# 10 made it possible)
              5) Pass to method to change the value
              6) What if a struct references itself
              Performance - Should be tested
                - Arrays
                  Struct one array container. Easy to find the object and null
                  Object can be distributed
                - Struct memory problem
                  - when too many object to copy/pass parameter
            */

public class Program
{
    static void Main(string[] args)
    {
        //Assignment();
        //InterfaceImplementation();
        ChangeValueTest();
    }

    
    /// <summary>
    // struct interface ile implement edildiğinde reference type gibi davranır.
    /// </summary>
    private static void InterfaceImplementation()
    {
        IUser user = new UserClass();
        user.ID = 1;
        IUser user2 = user;
        user2.ID = 10;

        IUser userStruct = new UserStruct();
        userStruct.ID = 1;
        IUser userStruct2 = userStruct;
        userStruct2.ID = 10;

        Console.WriteLine("---------userclass => "+user2.ID);
        Console.WriteLine("---------userstruct => "+userStruct2.ID);

    }
    private static void Assignment()
    {
        var userClass = new UserClass();
        userClass.ID = 1;

        var userClass2 = userClass;
        userClass2.ID = 10;


        Console.WriteLine("----------" + userClass2.ID);
    }

    private static void ChangeValueTest()
    {
        var userClass = new UserClass();
        userClass.ID = 10;
        ChangeValue(userClass);

        var userStruct = new UserStruct();
        userStruct.ID = 10;
        ChangeValue(userStruct);

        Console.WriteLine($"UserClass.ID: {userClass.ID}");
        Console.WriteLine($"UserStruct.ID: {userStruct.ID}");
    }
    public static void ChangeValue(UserClass user)
    {
        user.ID = -1;
    }

    public static void ChangeValue(UserStruct user)
    {
        user.ID = -1;
    }
    public class UserClass : IUser
    {
        public int ID { get; set; }
        public string? FullName { get; set; }
    }

    public struct UserStruct:IUser
    {
        public int ID { get; set; }
        public string? FullName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public interface IUser
    {
        public int ID { get; set; }
        public string? FullName { get; set;}
    }
}

