// See https://aka.ms/new-console-template for more information

using System;
using Generics;
class Program
{
    static void Main()
    {
        // 1st question
        MyStack<int> stack = new MyStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine($"Popped last element: {stack.Pop()}");
        Console.WriteLine($"Count: {stack.Count()}");
        
        // 2nd question
        MyList<string> myList = new MyList<string>();
        myList.Add("Rakesh");
        myList.Add("DJ");
        Console.WriteLine($"Contains Name Rakesh: {myList.Contains("Rakesh")}"); 
        Console.WriteLine($"Contains Name Ra-esh: {myList.Contains("Rake-sh")}");
        //Should return exception and console message

        myList.Remove(0);
        Console.WriteLine($"check if 'Rakesh' there after removing: {myList.Contains("Rakesh")}"); 
        
        
        // 3rd question
        
        GenericRepository<User> repository = new GenericRepository<User>();
        User user1 = new User { Id = 0, Name = "Rakesh" };
        User user2 = new User { Id = 1, Name = "DJ" };

        repository.Add(user1);
        repository.Add(user2);

        Console.WriteLine($"Entities count: {repository.GetAll().Count()}"); 
        foreach (var user in repository.GetAll())
        {
            Console.WriteLine(user.Id);
        }
        
        Console.WriteLine($"Entity with ID 1: {repository.GetById(1)?.Id}"); 

        repository.Remove(user1);
        Console.WriteLine($"Total after removal: {repository.GetAll().Count()}"); 
        repository.Save();
        
        
    }
}
