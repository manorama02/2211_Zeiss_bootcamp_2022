namespace ConsoleApp16
{

    class TataCar
    {
        //Dependency
        //RevtronEngine _engine=new RevtronEngine(); //composition
        public virtual void EngineName()
        {
            Console.WriteLine("No engine set ");
        }
        public void Ignite() {
        //_engine.Start();
        }
        public void Halt() {
            //_engine.Stop();
        }
    }
    class RevtronEngine:TataCar
    {
        public override void EngineName()
        {
            Console.WriteLine("Revtron Engine ");
        }
        //public void Start() { }
        //public void Stop() { }
    }
    class VericoreEngine:TataCar
    {
        public override void EngineName()
        {
            Console.WriteLine("Vericore Engine ");
        }

    }
    class KrytoechEngine:TataCar
    {
        public override void EngineName()
        {
            Console.WriteLine("Krytoech Engine ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TataCar _nexon = new RevtronEngine();
            _nexon.EngineName();

            TataCar _harrier = new KrytoechEngine(); //Kryotech engine
            _nexon.EngineName();

            TataCar _hexa = new VericoreEngine();//vericore engine
            _nexon.EngineName();

            FamilyOccassion _family = new FamilyOccassion();
            Parent _parentInstance = new Parent();
            _family.Visit(_parentInstance);

            _parentInstance = new Child_One(); //Runtime Polymorphism
            _family.Visit(_parentInstance);

            _parentInstance = new Child_Two();
            _family.Visit(_parentInstance);

            _parentInstance = new Child_Three();
            _family.Visit(_parentInstance);

        }
    }


    public class FamilyOccassion
    {

        public void Visit(Parent  familyMember)
        {
            familyMember.Participate(); //Runtime Polymorphism
            
        }
        
    }

    public class Parent {
    
        public virtual void Participate()
        {
            Console.WriteLine("Parent ...Participate ");
        }
    }
    public class Child_One:Parent {

        public override void Participate()
        {
            Console.WriteLine("ChildOne...Participate");
        }
        public void Smoke()
        {

        }
    }
    public class Child_Two:Parent {

        public override void Participate()
        {
            Console.WriteLine("ChildTwo...Participate");
        }

    }
    public class Child_Three : Parent {
        public override void Participate()
        {
            Console.WriteLine("ChildThree...Participate");
        }

    }



}
