using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiecheng.API.Services
{
    public interface IPropertyMappingService
    {
        Dictionary<string, PropertyMappingValue> GetPropertyMapping<TSource, TDestination>();
        public bool IsMappingExists<TSource, TDestination>(string fields);
    }
}