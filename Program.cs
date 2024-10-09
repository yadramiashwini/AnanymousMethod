namespace AnanymousMethod
{
    public  class AnanymousMethod
    {
        public delegate string PrintDelegate(string name);     //declaring delegate function
       
        static void Main(string[] args)
        {
            string Name = "Avinash";
            PrintDelegate p = delegate (string name)          //ananymous object using delegate function
            {
                Console.WriteLine($"Name of the Singer is:{Name}");
                return name;
            };
            string str = p("Ashwini");
            Console.WriteLine("name is:"+str);   
            
        }
    }
}
