
using c_class6;
using System.ComponentModel.DataAnnotations;

class Program
{
    public static void Main()
    {
        Annotations prop1 = new Annotations();
        prop1.getPropDetails();
        prop1.showPropDetails();

        //validate the model

        ValidationContext context = new ValidationContext(prop1);
        List<ValidationResult> validationResults = new List<ValidationResult>();
        bool valid = Validator.TryValidateObject(prop1, context, validationResults, true);
        if(!valid)
        {
            foreach(ValidationResult validationResult in validationResults)
            {
                Console.WriteLine("{0}", validationResult.ErrorMessage);
            }
        }
       
    }

  

}
