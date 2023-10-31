

using C_Class10;

class Program
{
    public static void Main()
    {

        //Thread th = Thread.CurrentThread;
        //th.Name = "Main thread";
        //Console.WriteLine(th.Name);
        Console.WriteLine("Main thread starts");

        Thread bgthread = new Thread(FirstThread.BackgroundThread)
        {
            IsBackground = false
        };
        bgthread.Start();

        Console.WriteLine("Main thread quits");

        //Thread t2 = new Thread(FirstThread.child1)
        //{
        //    IsBackground = true
        //};

        //t2.Start();



        //  Thread t1 = new Thread(FirstThread.work1);
        //  t1.Start();





        //t3.Start();
        //t3.Join();


        //ScrapMethod sc = new ScrapMethod();
        //sc.oldMethod();
        //sc.newMethod();
        //Student st = new Student();
        //st.showJsonData();
        // Movie mv = new Movie();
        //mv.XMLSerialization();
        //  mv.XMLDeSerialization();

        // PropertyCare prop1 = new PropertyCare("Fera", 121212, "Chennai");
        // prop1.BinarySerializer();
        // prop1.BinaryDeserializer();
    }
}
