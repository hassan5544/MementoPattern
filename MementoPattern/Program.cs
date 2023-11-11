using MementoPattern;

class Program
{
    public static void Main()
    {
        Originator originator = new Originator("test");
        Caretaker caretaker = new Caretaker(originator);

        caretaker.Backup();

        originator.ChangeState("test1");

        caretaker.Backup();
        originator.ChangeState("test2");

        caretaker.Backup();
        originator.ChangeState("test3");



        caretaker.Undo();
        caretaker.Undo();
        caretaker.Undo();

    }
}