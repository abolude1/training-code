namespace HelloCsharp
{
  class Program
  {
    static void Main()
    {
      Console.Write("enter firstname: ");
      var firstName = System.Console.ReadLine(); //lazy instantiation is given based on content of ReadLine
      Console.Write("enter lastname: ");
      string lastName = System.Console.ReadLine(); //eagar instantiation. Datatype is explicit prior to content of ReadLine
      
      System.Console.WriteLine(firstName + "" + lastName);
      System.Console.WriteLine("{0} {1}", firstName, lastName);

      System.Console.ReadLine($"{firstName} {lastName}"");
    
      System.Console.ReadLine();
    }
  }    
}