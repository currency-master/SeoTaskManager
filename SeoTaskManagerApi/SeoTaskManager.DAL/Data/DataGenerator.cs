using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SeoTaskManager.Domain.Models;
using System;
using System.Linq;

namespace SeoTaskManager.DAL.Data
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SeoTaskManagerContext(
                serviceProvider.GetRequiredService<DbContextOptions<SeoTaskManagerContext>>()))
            {
                if (context.UserTasks.Any())
                {
                    return;
                }

                context.UserTasks.Add(
                    new UserTask
                    {
                        Id = 1,
                        UserId = 1,
                        GoodName = "Giant inflatable ball",
                        KeyWord = "Striped",
                        WordRank = null,
                        AdsCount = null
                    });

                context.SaveChanges();
            }
        }
    }
}