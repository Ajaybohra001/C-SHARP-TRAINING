using System.ComponentModel.DataAnnotations;

namespace FirstWebApi.Validator
{
    public class AgeValidator:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var age=(int )value;
            if(age<18)
            {
                return false;
            }
            return true;
        }
    }
}
