using System;

public class Rat {
  static void Main(string[] args){
    if (args.Length > 1){
      Console.WriteLine("Usage: ratcs [script]");
      return;
    }
    else if (args.Length == 1) {
      runFile(args[0]);
    }
    else {
      runPrompt();
    }
  }

private static void runFile(string path) {
  
}

private static void runPrompt() {
  foreach (Token token : tokens) {
    Console.WriteLine(token);
  }
}
}