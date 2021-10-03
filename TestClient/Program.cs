using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using FluentKusto;
using Newtonsoft.Json;

namespace FluentKusto.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var kql = Kusto.New();

            //kql.Update.Where(x => x.Approved == true);
            //kql = Kusto.New();

            // kql.AACAudit.Where(x => x._SubscriptionId.equal("wdwa"));
            // kql = Kusto.New();

            // kql.AACAudit
            // .Where(x => x._SubscriptionId.equal("231312-2312-13123") || x.EventCategory.equal("Event"))
            // kql = Kusto.New();

            //create dynamic expression outside and pass intp Extend to convert intp Expresion. b   /
            string q = kql.Update
                .Extend((t, c) =>
                    new {
                        ResourceArray = Kql.split(c.id_s, '/'),
                        SecondLastResourceElement = c.ResourceArray[Kql.array_length(c.ResourceArray) - 2],
                        Pro = Kql.parse_json(t.Product).resourceProviderValue
                    })
                .Where(t => t.TimeGenerated > Kql.ago("12h"))
                .QueryAsString();

                //.Project<Event>(evt => evt.Message, evt => evt.Role);


            kql = Kusto.New();

            // kql.Update.Where(x =>
            //     x._SubscriptionId.equalnoncase("DasdasdsaDASDASdasdas") &&
            //     x.TimeGenerated > Kql.ago("3h") || x.ApprovalSource.equal("AAB")
            //     && x.CVENumbers.notequal("B"));
            // kql = Kusto.New();

            kql.Update.Where(x =>
                x._SubscriptionId.notequal("DasdasdsaDASDASdasdas") &&
                x.TimeGenerated > Kql.ago("3h") || x.ApprovalSource.equal("Dsaa")
                && x.CVENumbers.equal("sfaaa") || x.Approved == true && x.Computer.notequal("sda"));



            kql = Kusto.New();

            // kql.Update.Where(x =>
            //     x._SubscriptionId.equalnoncase("DasdasdsaDASDASdasdas") &&
            //     x.TimeGenerated > Kql.ago("3h") || x.ApprovalSource.equal("AAB")
            //     && x.CVENumbers.notequal("B") || x.Approved == true && x.Computer.equal("saasd") ||
            //     x.Classification.notequal("B") && x.BulletinUrl == "http://url.com" || x.BulletinID == "A"
            //     && x.Approved == true);
            // kql = Kusto.New();
        }
    }
}
