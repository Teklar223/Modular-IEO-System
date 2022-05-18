//TODO: implements Encryption, and override the encrypting method, or the output to go to a file etc...

using encryption_exercise;

public class EncryptionV2 : Encryption
{
    override protected string Input()
    {
        // takes input from text
        return "stam";
    }
}