using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using HRMS_Project.Models.Cache;
using Microsoft.Extensions.Configuration;
using HRMS_Project.Models.Settings;

namespace HRMS_Project.Function
{

    public static class Cache
    {
        private static string ClassName = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName;
        public static void CreateCache(AppSettingsViewModel _configuration, IMemoryCache _cache, string NameKey, string username)
        {
            try
            {
                MemoryCacheEntryOptions cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(int.Parse(_configuration.CacheExpire)));
                
                List<CacheModel> cache = new List<CacheModel>();
                cache.Add(new CacheModel()
                {
                    username = username
                });

                _cache.Set(NameKey, cache, cacheEntryOptions);
            }
            catch (Exception ex)
            {
               
            }
        }


    }
}
