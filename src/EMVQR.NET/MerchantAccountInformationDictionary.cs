﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EMVQR
{
    public sealed class MerchantAccountInformationDictionary : Dictionary<int, MerchantAccountInformation>, IValidatableObject
    {
        private bool _validating;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (_validating)
            {
                return new ValidationResult[0];
            }

            try
            {
                _validating = true;

                var results = new List<ValidationResult>();
                foreach (var item in this)
                {
                    var context = new ValidationContext(item.Value, null, null);
                    Validator.TryValidateObject(item.Value, context, results, true);
                }

                return results;
            }
            finally
            {
                _validating = false;
            }
        }
    }
}
