using LearnersDetails;
class Program
{
    static void Main (string[] args)
    {
        Learners learner1 = new Learners("Thabo", "Tauyatsoala", "Female", 34, 'T');

        Console.WriteLine(learner1.firstname + " " + learner1.lastname + " " + learner1.gender + " " + learner1.age + " " + learner1.initials);
    }
}
