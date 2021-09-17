 
 public class A0
 {
     private float a = 4.5;
     private float b = 3.7;
     public float C
     {
        a *= b;
        get { return a; }
     }
 }


  public class A1
 {
     private float a = 4.5;
     private float b = 3.7;
     public float C
     {
         get { return ++a; }
     }
 }


   public class A2
 {
     private float a = 4.5;
     private float b = 3.7;
     public float C
     {
         get { return a / b; }
     }
 }


 public class Programm
 {
     static void Main(string[] agrs)
     {
        A0 object0 = new A0();
        A1 object1 = new A1();
        A2 object2 = new A2();
        Console.WriteLine(object0.C);
     }
 }