using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class LinksDbInitializer: DropCreateDatabaseIfModelChanges<LinkContext>
    {
        protected override void Seed(LinkContext context)
        {
            context.Links.Add(new Links
            {
                Name = "Тестовая ссылка", Link="test@mail.ru" });
            base.Seed(context);
        }

    }
}