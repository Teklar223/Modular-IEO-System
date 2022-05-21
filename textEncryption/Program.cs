using encryption_exercise;

ProcessRunner processRunner = new ProcessRunner();
IInput readlineInput = new FilePathInput();
IEncryptor stringEncryptor = new StringEncryptor();
IOutput writetofileOutput = new WriteToFileOutput();
AbstractProcess process = new Process(stringEncryptor, readlineInput, writetofileOutput);
processRunner.execute(process);