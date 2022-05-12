using System;

class Program {
  public static void Main (string[] args) {
    string command;
    string user = Environment.UserDomainName;
    Console.WriteLine($"Welcome to Next TERM Alpha 1, {user}!");
    while (true==true)
    {
      string cwd = System.AppContext.BaseDirectory;
      Console.Write($"{cwd}:$ ");
      command = Console.ReadLine();
      Console.WriteLine("\n");
      if (command.Contains("cd"))
      {
        string directory=command.Replace("cd ", "");
        Environment.CurrentDirectory = directory;
      }
      else if (command=="whoami")
      {
        Console.WriteLine($"You are currently logged in as: {user}");
      }
      else if (command=="ver" || command=="version")
      {
        Console.WriteLine("Next TERM Alpha 1");
      }
      else if (command=="calc" || command=="calculator")
      {
          System.Diagnostics.Process.Start("programs/calc.exe")
      }
      else
      {
        try
        {
          Console.WriteLine("\n");
          System.Diagnostics.Process.Start(command);   
          Console.WriteLine("\n");
        }
        catch
        {
          Console.WriteLine("An error has occured.");
        }
      }
      
    }

  }
}