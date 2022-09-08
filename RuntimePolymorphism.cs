namespace ConsoleApp16
{

    class TataCar
    {
        //Dependency
        //RevtronEngine _engine=new RevtronEngine(); //composition
        
        public void Ignite(Engine Engtype) {
            Engtype.EngineName();
        }
        public void Halt() {
           
        }
    }
    class Engine{
        public virtual void EngineName()
        {
            Console.WriteLine("No engine set ");
        }
    }
    class RevtronEngine:Engine
    {
        public override void EngineName()
        {
            Console.WriteLine("Revtron Engine ");
        }
        //public void Start() { }
        //public void Stop() { }
    }
    class VericoreEngine:Engine
    {
        public override void EngineName()
        {
            Console.WriteLine("Vericore Engine ");
        }

    }
    class KrytoechEngine:Engine
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
            Tatacar _nexon = new TataCar();
            Engine revtron=new RevtronEngine();
            _nexon.ignite(revtron);

            TataCar _harrier = new TataCar(); //Kryotech engine
            Engine kryo=new KrytoechEngine();
            _nexon.ignite(kryo);

            TataCar _hexa = new TataCar();//vericore engine
            Engine vericore=new VericoreEngine();
            _nexon.ignite( vericore);

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
