# Text Encryption Exercise

A .net oriented exercise for @SAP-Gigya

## What is the exercise?
Firstly, you can look at the `exercise_specifications.png` file to see the exact wording, but my understanding is that I was to create a modular system that inputs data, processes it, and outputs it, where the modularity is for each step and the data is text\files etc...

## The Solution
I created 3 interfaces representing input, encryption, and output as classes and not just methods, then I created an abstract class called `Process` which contains each of these as a protected class member, and this abstract class has a method which calls each of these respectively and in the expected order (in, process, out), to accomplish a Pipeline template class, where every step of that template is a Strategy, I will explain in the next section what these mean, but essentially this design allows for pretty extensive modularity, and every step is separate from the others in terms of implementation (no hard coded dependacy between any steps), and finally I added an executing class called `Process Runner` which allows me to choose between Synced or Asynced (using threads) execution of the program, as long as all 3 steps can be run asynchronously (and no restrictions on Synced execution).

## Design Patterns
`Strategy` - This design pattern defines a family of classes/methods which are used by another class, in this case I have not 1 but 3 strategies, these being `IInput`,`IEncryptor`, and `IOutput`, where each respectively defines the methods I expect to use in my process.
</br> </br>
`Template` - This design pattern lists a set of steps (like a recipe), which are not subject to change, but the implementation of each step is, so for my problem, the function in the `Process` class is not subject to change, but every step of it is a Strategy and can therefore be swapped at essentially any point in time.
</br> </br>
`Pipeline` - In my Template method, I expect to receive a string array from my input class, which then is passed by reference to be worked on by the encrypting class, which then gets passed by reference to the output class, however in my implemantion this is a small pipeline, but seeing as I can extend it, it is relevant.
