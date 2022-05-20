// See https://aka.ms/new-console-template for more information
using encryption_exercise;

//"MAIN"

ProcessRunner pr = new ProcessRunner();
IInput readlineInput = new ReadLineInput();
IEncryptor stringEncryptor = new StringEncryptor();
IOutput writelineOutput = new WriteLineOutput();
AbstractProcess ps = new Process(stringEncryptor, readlineInput, writelineOutput);
pr.executeStrategy(ps);