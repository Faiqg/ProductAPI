using System;
using Microsoft.Extensions.DependencyInjection;

namespace Refactored.This.Data
{
    public class RefactorDbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var serviceScope = serviceProvider.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<RefactorContext>();
        }
    }
}
