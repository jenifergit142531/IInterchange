
using c_class6;
using System.ComponentModel.DataAnnotations;

class Program
{
    public static void Main()
    {

        HashingSet.hashingSet();
       // HashSet<string> hs1 = HashingSet.hashingSet();

        //foreach (var i in hs1)
        //{
        //    Console.WriteLine(i);
        //}


        //List<int> result= Indexing.Listing();

        // foreach (var i in result)
        // {
        //     Console.WriteLine(i);
        // }
        //Indexing.ArrList();
        // Annotations prop1 = new Annotations();
        // prop1.getPropDetails();
        //// prop1.showPropDetails();

        // //validate the model

        // ValidationContext context = new ValidationContext(prop1);
        // List<ValidationResult> validationResults = new List<ValidationResult>();
        // bool valid = Validator.TryValidateObject(prop1, context, validationResults, true);
        // if(!valid)
        // {
        //     foreach(ValidationResult validationResult in validationResults)
        //     {
        //         Console.WriteLine("{0}", validationResult.ErrorMessage);
        //     }
        // }

    }



}
