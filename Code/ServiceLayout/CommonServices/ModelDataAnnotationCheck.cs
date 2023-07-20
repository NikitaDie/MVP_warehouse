using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CommonServices
{
    public class ModelDataAnnotationCheck
    {
        public void ValidateModel<TLoginModel>(TLoginModel loginModel)
        {

            ValidationContext validationContext = new ValidationContext(loginModel, null, null);
        }
    }
}
