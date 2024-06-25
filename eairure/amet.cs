   public class MyClass
   {
       #pragma warning disable CS8618
       private string _nonNullableField;
       #pragma warning restore CS8618

       public MyClass()
       {
           // Field will be initialized elsewhere
       }
   }
   