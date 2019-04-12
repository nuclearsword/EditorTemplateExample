using EditorTemplateExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EditorTemplateExample.Repo
{
    public class FakeRepo
    {
        public Session[] GetSessions()
        {
            return new Session[] {
                new Session{ SessionID = 1, Name = "Azure Training", Cost = decimal.Parse("33.99") },
                new Session{ SessionID = 2, Name = "O365 Training", Cost = decimal.Parse("55.99")},
                new Session{ SessionID = 3, Name = "SQL Training", Cost = decimal.Parse("1001.99")},
                new Session{ SessionID = 4, Name = "DevOps Demo", Cost = decimal.Parse("9824.99")}
            };
        }
    }
}