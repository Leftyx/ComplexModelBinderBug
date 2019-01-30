using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Serilog;
using WebApplication1.Models;

namespace WebApplication1
{
    /// <summary>
    /// Represents model binder provider for the creating NopModelBinder
    /// </summary>
    public class NopModelBinderProvider : IModelBinderProvider
    {
        /// <summary>
        /// Creates a nop model binder based on passed context
        /// </summary>
        /// <param name="context">Model binder provider context</param>
        /// <returns>Model binder</returns>
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            var modelType = context.Metadata.ModelType;
            if (!typeof(BaseNopModel).IsAssignableFrom(modelType))
                return null;

            //use NopModelBinder as a ComplexTypeModelBinder for BaseNopModel
            if (context.Metadata.IsComplexType && !context.Metadata.IsCollectionType)
            {
                // Log.Debug("{properties}", context.Metadata.Properties);

                //create binders for all model properties
                var propertyBinders = context.Metadata.Properties
                    .ToDictionary(modelProperty => modelProperty, modelProperty => context.CreateBinder(modelProperty));

                return new NopModelBinder(propertyBinders, new LoggerFactory());
            }

            //or return null to further search for a suitable binder
            return null;
        }
    }
}
