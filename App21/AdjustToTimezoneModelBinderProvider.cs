﻿using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace App21
{
    public class AdjustToTimezoneModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (!context.Metadata.IsComplexType && !string.IsNullOrEmpty(context.Metadata.PropertyName))
            {
                var propName = context.Metadata.PropertyName;

                if (propName == null)
                {
                    return null;
                }

                var propInfo = context.Metadata.ContainerType.GetProperty(propName);

                if (propInfo == null)
                {
                    return null;
                }

                //if (propInfo.GetCustomAttributes(typeof(AdjustToTimezoneAttribute), false).FirstOrDefault() is AdjustToTimezoneAttribute attribute)
                //{
                //    return new AdjustToTimeZoneModelBinder(context.Metadata.ModelType, attribute.TimeZoneIdPropertyName);
                //}
            }

            return null;
        }
    }
}
