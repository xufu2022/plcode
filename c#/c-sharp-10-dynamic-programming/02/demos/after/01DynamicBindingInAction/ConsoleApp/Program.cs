using static System.Console;

OutputTimeStaticBinding();

OutputTimeDynamicBinding();

OutputTimeDynamicBindingRunTimeError();

WriteLine("\n\nPress enter to exit...");
ReadLine();


static void OutputTimeStaticBinding()
{
    DateTime dt = DateTime.Now;

    string time = dt.ToLongTimeString();

    WriteLine(time);
}

static void OutputTimeDynamicBinding()
{
    dynamic dt = DateTime.Now;

    string time = dt.ToLongTimeString();

    WriteLine(time);
}

static void OutputTimeDynamicBindingRunTimeError()
{
    dynamic dt = DateTime.Now;

    string time = dt.IsItCoffeeTime();

    WriteLine(time);
}