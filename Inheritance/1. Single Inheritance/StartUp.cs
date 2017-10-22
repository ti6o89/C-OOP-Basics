namespace _1.Single_Inheritance
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var dog  = new Dog();
            dog.Eat();
            dog.Bark();

            var cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
